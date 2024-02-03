using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileChecker
{
    public partial class Form1 : Form
    {

        // フォルダパスを保存するための変数
        private string selectedFolderPath;

        // 選択されたファイルのパスを保存するためのリスト
        private List<string> selectedFiles = new List<string>();

        private FileInfo mostRecentFile;

        public Form1()
        {
            InitializeComponent();

            // テキストボックスを非表示に設定
            textBoxEditSetName.Visible = false;
        }

        
        //ファイルから復元
        private List<SettingsSet> LoadSettingsSets()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<SettingsSet>));
            using (StringReader reader = new StringReader(Properties.Settings.Default.SettingsSetsXml))
            {
                return (List<SettingsSet>)serializer.Deserialize(reader);
            }
        }

        // アプリケーション起動時に設定を読み込む
        private void Form1_Load(object sender, EventArgs e)
        {

            //設定ファイルから復元
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SettingsSetsXml))
            {
                List<SettingsSet> settingsSets = LoadSettingsSets();

                foreach (SettingsSet set in settingsSets)
                {
                    comboBoxSets.Items.Add(set);
                }

                // 必要に応じて最初のアイテムを選択状態に設定
                if (comboBoxSets.Items.Count > 0)
                {
                    comboBoxSets.SelectedIndex = 0;
                }
            }

            // コンボボックスにセットが存在しない場合、デフォルトのセットを作成
            //MessageBox.Show("セットつくる", "test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (comboBoxSets.Items.Count == 0)
            {
                var defaultSet = new SettingsSet("デフォルトセット");
                // ここでデフォルトセットのプロパティを初期化する
                defaultSet.SelectedFolderPath = "C:\\";
                defaultSet.FileSizeLimit = 1;
                defaultSet.TotalSizeLimit = 1;
                defaultSet.Name = "Default";

                comboBoxSets.Items.Add(defaultSet);
                comboBoxSets.SelectedIndex = 0; // デフォルトセットを選択状態にする
            }

            //ListView初期化
          　 listView1.Columns.Add("");
            listView1.Columns.Add("");
            listView1.Columns.Add("");
            // ListViewのクライアント領域の幅を取得（スクロールバーの幅を考慮）
            int listViewWidth = listView1.ClientSize.Width;

            // カラム幅を割合で設定
            int column1Width = (int)(listViewWidth * 0.04); // アイコンカラム
            int column2Width = (int)(listViewWidth * 0.76); // ファイル名カラム
            int column3Width = (int)(listViewWidth * 0.2); // 容量カラム

            listView1.Columns[0].Width = column1Width;
            listView1.Columns[1].Width = column2Width;
            listView1.Columns[2].Width = column3Width;

            //右揃え用にカスタム描画を出来るようにする
            listView1.OwnerDraw = true;

            // ImageListにフォルダの画像を追加
            imageList1.Images.Add("folderIcon", Properties.Resources.PL_Folder);

            // ListViewにImageListを関連付ける
            listView1.SmallImageList = imageList1;

            // 現在選択されているセットにテキストボックスのテキストを設定
            comboBoxSets.DisplayMember = "Name";

            UpdateListView();
            UpdateRecentFilel();
            updateLabelSetName();
            updateLabelsTarget();

        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            //ブラウザを開いて最新ファイルを取得する
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                //開始パスを selectedFolderpathに
                folderBrowserDialog.SelectedPath = selectedFolderPath;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;
                }
                SaveSelectedSetValues(); //SelectedSetに適用
                UpdateRecentFilel(); // 最新ファイルを更新

            }
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All files (*.*)|*.*"; // 必要に応じてフィルターを設定

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 選択されたファイルをリストに追加
                    selectedFiles.AddRange(openFileDialog.FileNames);
                    UpdateListView();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                // ListViewからアイテムを削除
                listView1.Items.Remove(item);

                // selectedFilesから対応するファイルパスを検索して削除
                string fileName = item.SubItems[1].Text; // 2番目のサブアイテムのテキストを取得
                string fileToRemove = selectedFiles.FirstOrDefault(f => new FileInfo(f).Name == fileName);
                if (fileToRemove != null)
                {
                    selectedFiles.Remove(fileToRemove);
                }
            }
            UpdateListView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateRecentFilel();
        }

        private void addMostRecentFileButton_Click(object sender, EventArgs e)
        {
            if (mostRecentFile != null)
            {
                // selectedFilesリストに最新のファイルを追加
                if (!selectedFiles.Contains(mostRecentFile.FullName))
                {
                    selectedFiles.Add(mostRecentFile.FullName);
                    UpdateListView();
                }
            }
        }

        private void UpdateListView()
        {
            // リストボックスを更新
            listView1.Items.Clear();
            foreach (string path in selectedFiles)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = -1; // デフォルトで画像なし

                // ファイル名と容量をサブアイテムとして追加
                long size = 0;
                if (File.Exists(path)) // パスがファイルの場合
                {
                    FileInfo fileInfo = new FileInfo(path);
                    size = fileInfo.Length;
                    // 2つ目のカラムにファイル名を追加
                    item.SubItems.Add(fileInfo.Name);
                    // 3つ目のカラムにサイズを追加
                    item.SubItems.Add($"{size / 1024.0 / 1024.0:F2} MB");
                }
                else if (Directory.Exists(path)) // パスがフォルダの場合
                {
                    size = GetDirectorySize(path);
                    // 2つ目のカラムにフォルダ名を追加
                    item.SubItems.Add(new DirectoryInfo(path).Name);
                    // 3つ目のカラムにサイズを追加
                    item.SubItems.Add($"{size / 1024.0 / 1024.0:F2} MB");

                    // フォルダ画像を設定
                    item.ImageIndex = imageList1.Images.IndexOfKey("folderIcon");
                }
                item.SubItems.Add($"{size / 1024.0 / 1024.0:F2} MB");
                listView1.Items.Add(item);
            }

            UpdateTotalSizeLabel();
            SaveSelectedSetValues();
        }

        private void UpdateRecentFilel()
        {
            //最新のファイルを取得
            if (!string.IsNullOrEmpty(selectedFolderPath))
            {
                // 最新のファイルを追加
                var directory = new DirectoryInfo(selectedFolderPath);
                mostRecentFile = directory.GetFiles()
                                          .OrderByDescending(f => f.LastWriteTime)
                                          .FirstOrDefault();
            }
            UpdateRecentFileLabels();

        }

        //フォルダの容量を計算するメソッド
        private long GetDirectorySize(string folderPath)
        {
            long size = 0;
            // フォルダ内の全ファイルのサイズを合計
            string[] fileNames = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
            foreach (string fileName in fileNames)
            {
                var fileInfo = new FileInfo(fileName);
                size += fileInfo.Length;
            }
            return size;
        }

        private void UpdateRecentFileLabels()
        {

            if (mostRecentFile != null)
            {
                double fileSizeMB = mostRecentFile.Length / 1024.0 / 1024.0;

                // ラベルにファイル情報を表示
                labelFileName.Text = mostRecentFile.Name;
                labelFileSize.Text = fileSizeMB.ToString("F2") + " /";

                // ファイルサイズが大きい場合、背景を赤くする
                double limitSizeMB = double.Parse(textBoxFileSizeLimit.Text);
                if (fileSizeMB > limitSizeMB)
                {
                    labelFileSize.ForeColor = Color.Red;
                }
                else
                {
                    labelFileSize.ForeColor = Color.White;
                }
            }
            labelFolderPath.Text = selectedFolderPath;
        }

        private void UpdateTotalSizeLabel()
        {
            double totalSizeMB = 0;
            foreach (string path in selectedFiles) // selectedFilesはファイルとフォルダのパスが含まれていると仮定
            {
                // ファイルの場合
                if (File.Exists(path))
                {
                    var fileInfo = new FileInfo(path);
                    totalSizeMB += fileInfo.Length / 1024.0 / 1024.0;
                }
                // フォルダの場合
                else if (Directory.Exists(path))
                {
                    long folderSize = GetDirectorySize(path);
                    totalSizeMB += folderSize / 1024.0 / 1024.0;
                }
            }
            totalSizeLabel.Text = $"{totalSizeMB:F2} /";

            // テキストボックスの値を数値に変換し、サイズ比較
            if (double.TryParse(textBoxTotalSizeLimit.Text, out double sizeLimit) && totalSizeMB > sizeLimit)
            {
                totalSizeLabel.ForeColor = Color.Red;
            }
            else
            {
                totalSizeLabel.ForeColor = Color.White;
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Zipファイル (*.zip)|*.zip";
                saveFileDialog.InitialDirectory = selectedFolderPath; // 初期フォルダを設定

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ZipArchive zip = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Create))
                    {
                        foreach (string path in selectedFiles)
                        {
                            string baseFolderName = Path.GetFileName(path); // フォルダの名前を取得
                            if (File.Exists(path))
                            {
                                // ファイルをZipアーカイブに追加
                                zip.CreateEntryFromFile(path, baseFolderName);
                            }
                            else if (Directory.Exists(path))
                            {
                                // フォルダをZipアーカイブに追加（再帰的にファイルを処理）
                                AddFolderToZip(zip, path, baseFolderName);
                            }
                        }
                    }
                }
            }
        }

        private void AddFolderToZip(ZipArchive zip, string folderPath, string entryName)
        {
            // フォルダ内の全ファイルをZIPに追加
            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                string fileEntryName = entryName + "/" + Path.GetFileName(filePath); // 修正: parentEntryName を entryName に変更
                zip.CreateEntryFromFile(filePath, fileEntryName);
            }

            // サブフォルダも同様に処理
            foreach (string subFolderPath in Directory.GetDirectories(folderPath))
            {
                string subFolderName = Path.GetFileName(subFolderPath);
                string subFolderEntryName = string.IsNullOrEmpty(entryName) ? subFolderName : entryName + "/" + subFolderName; // 修正: parentEntryName を entryName に変更

                // サブフォルダ内のファイルを再帰的に追加
                AddFolderToZip(zip, subFolderPath, subFolderEntryName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // 新しい設定セットを作成
            var newSet = new SettingsSet($"Set {comboBoxSets.Items.Count + 1}");
            newSet.SelectedFolderPath = selectedFolderPath;
            newSet.SelectedFiles = new List<string>(selectedFiles);
            newSet.FileSizeLimit = int.TryParse(textBoxFileSizeLimit.Text, out int fileSizeLimit) ? fileSizeLimit : 0;
            newSet.TotalSizeLimit = int.TryParse(textBoxTotalSizeLimit.Text, out int totalSizeLimit) ? totalSizeLimit : 0;

            // コンボボックスに追加
            comboBoxSets.Items.Add(newSet);

            // 新しいアイテムを選択状態に設定
            comboBoxSets.SelectedIndex = comboBoxSets.Items.Count - 1;
            // UI更新
            UpdateListView();
            UpdateTotalSizeLabel();
            updateLabelSetName();
            updateLabelsTarget();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            // 現在選択されているインデックスを取得
            int selectedIndex = comboBoxSets.SelectedIndex;

            if (selectedIndex != -1)
            {
                // 選択されているアイテムを削除
                comboBoxSets.Items.RemoveAt(selectedIndex);

                // コンボボックスがまだアイテムを持っているか確認
                if (comboBoxSets.Items.Count > 0)
                {
                    // 削除されたアイテムのインデックスがリストの範囲内にあるか、
                    // それとも新しいリストの最後のインデックスを使うべきかを確認
                    comboBoxSets.SelectedIndex = (selectedIndex < comboBoxSets.Items.Count) ? selectedIndex : comboBoxSets.Items.Count - 1;
                }
            }
            // UI更新
            UpdateListView();
            UpdateTotalSizeLabel();
            updateLabelSetName();
            updateLabelsTarget();
        }

        private void comboBoxSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSets.SelectedItem is SettingsSet selectedSet)
            {
                selectedFolderPath = selectedSet.SelectedFolderPath;
                selectedFiles = new List<string>(selectedSet.SelectedFiles);
                textBoxFileSizeLimit.Text = selectedSet.FileSizeLimit.ToString();
                textBoxTotalSizeLimit.Text = selectedSet.TotalSizeLimit.ToString();

                UpdateRecentFilel();

                // UIを更新する必要がある場合はここで行う
                UpdateListView();
                UpdateTotalSizeLabel();
                updateLabelSetName();
                updateLabelsTarget();
            }
            comboBoxSets.Visible = false;
        }

        //作業用のUI用変数の値をコンボボックスの現在のインデックスの値に上書きする
        private void SaveSelectedSetValues()
        {
            if (comboBoxSets.SelectedItem is SettingsSet selectedSet)
            {
                // 現在のUIから値を取得して選択されているセットを更新
                selectedSet.SelectedFolderPath = selectedFolderPath; // 選択されたフォルダのパス
                selectedSet.SelectedFiles = new List<string>(selectedFiles); // 選択されたファイルのリスト
                selectedSet.FileSizeLimit = int.TryParse(textBoxFileSizeLimit.Text, out int fileSizeLimit) ? fileSizeLimit : 0; // ファイルサイズ制限
                selectedSet.TotalSizeLimit = int.TryParse(textBoxTotalSizeLimit.Text, out int totalSizeLimit) ? totalSizeLimit : 0; // 全体のサイズ制限
                SaveComboBoxSettingsSets();
            }
            else
            {
                // 選択されているセットがない場合の処理、例えばエラーメッセージを表示
                MessageBox.Show("更新するセットが選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveComboBoxSettingsSets()
        {
            List<SettingsSet> settingsSets = new List<SettingsSet>();
            foreach (var item in comboBoxSets.Items)
            {
                if (item is SettingsSet set)
                {
                    settingsSets.Add(set);
                }
            }

            SaveSettingsSets(settingsSets); // 保存メソッドにリストを渡す
        }

        private void SaveSettingsSets(List<SettingsSet> settingsSets)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<SettingsSet>));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, settingsSets);
                Properties.Settings.Default.SettingsSetsXml = writer.ToString();
                Properties.Settings.Default.Save();
            }
        }

        //メインラベルにセット名を表示する
        private void updateLabelSetName()
        {
            if (comboBoxSets.SelectedItem is SettingsSet selectedSet)
            {
                // ラベルに選択されているセットの名前を表示
                labelSetName.Text = selectedSet.Name;
            }
            else
            {
                // セットが選択されていない場合、ラベルをクリア
                labelSetName.Text = "";
            }
        }

        //ターゲット容量を示すラベル2つを更新
        private void updateLabelsTarget()
        {
            if (comboBoxSets.SelectedItem is SettingsSet selectedSet)
            {
                // ラベルに選択されているセットの名前を表示
                labelFileSizeLimit.Text = selectedSet.FileSizeLimit.ToString();
                labelTotalSizeLimit.Text = selectedSet.TotalSizeLimit.ToString();
            }
            else
            {
                // セットが選択されていない場合、ラベルをクリア
                labelSetName.Text = "";
            }
        }

        private void labelSetName_DoubleClick(object sender, EventArgs e)
        {
            // テキストボックスを表示し、ラベルのテキストを設定
            textBoxEditSetName.Text = labelSetName.Text;
            textBoxEditSetName.Visible = true;
            textBoxEditSetName.Focus();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                //開始パスを selectedFolderpathに
                folderDialog.SelectedPath = selectedFolderPath;
                // フォルダ選択ダイアログの設定
                folderDialog.Description = "圧縮するフォルダを選択してください。";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 選択されたフォルダのパスを取得
                    string selectedFolderPath = folderDialog.SelectedPath;

                    // selectedFilesリストにフォルダパスを追加
                    selectedFiles.Add(selectedFolderPath);

                    UpdateListView();
                }
            }
        }

        private void textBoxEditSetName_KeyDown(object sender, KeyEventArgs e)
        {
            // Enterキーが押されたかどうかを確認
            if (e.KeyCode == Keys.Enter)
            {
                // 現在選択されているセットにテキストボックスのテキストを設定
                if (comboBoxSets.SelectedItem is SettingsSet selectedSet)
                {
                    selectedSet.Name = textBoxEditSetName.Text;
                    // コンボボックスの表示を更新するために、アイテムの再設定を行う
                    int selectedIndex = comboBoxSets.SelectedIndex;
                    comboBoxSets.Items[selectedIndex] = selectedSet;

                    //コンボボックスの表示プロパティをNameにする
                    comboBoxSets.DisplayMember = "Name";

                    // コンボボックスの選択を元に戻す
                    comboBoxSets.SelectedIndex = selectedIndex;

                    //ラベルの更新
                    labelSetName.Text = textBoxEditSetName.Text;
                }

                // テキストボックスを非表示に
                textBoxEditSetName.Visible = false;

                // Enterキーのデフォルトの動作を抑制（ビープ音防止）
                e.SuppressKeyPress = true;

                SaveSelectedSetValues();
            }
        }

        private void textBoxFileSizeLimit_KeyDown(object sender, KeyEventArgs e)
        {
            // Enterキーが押されたかどうかを確認
            if (e.KeyCode == Keys.Enter)
            {
                // ここに更新処理を記述
                UpdateRecentFileLabels();
                SaveSelectedSetValues();
                updateLabelsTarget();
                textBoxFileSizeLimit.Visible = false;

                // Enterキーのデフォルトの動作を抑制（ビープ音防止）
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxTotalSizeLimit_KeyDown(object sender, KeyEventArgs e)
        {
            // Enterキーが押されたかどうかを確認
            if (e.KeyCode == Keys.Enter)
            {
                // ここに更新処理を記述
                UpdateTotalSizeLabel();
                SaveSelectedSetValues();
                updateLabelsTarget();
                textBoxTotalSizeLimit.Visible = false;

                // Enterキーのデフォルトの動作を抑制（ビープ音防止）
                e.SuppressKeyPress = true;
            }
        }

        private void labelFileSizeLimit_DoubleClick(object sender, EventArgs e)
        {
            textBoxFileSizeLimit.Visible = true;
            textBoxFileSizeLimit.Focus();
        }

        private void labelTotalSizeLimit_DoubleClick(object sender, EventArgs e)
        {
            textBoxTotalSizeLimit.Visible = true;
            textBoxTotalSizeLimit.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            comboBoxSets.Visible = true;
            comboBoxSets.Focus();
            comboBoxSets.DroppedDown = true;
        }

        private void comboBoxSets_Leave(object sender, EventArgs e)
        {
            comboBoxSets.Visible = false;
        }

        private void comboBoxSets_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxSets.Visible = false;
        }

        //ListView右揃え用1。ListViewのプロパティから参照
        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        //ListView右揃え用2。ListViewのプロパティから参照。
        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // 3番目のカラムのテキストを右揃えにする
            if (e.ColumnIndex == 2)
            {
                TextFormatFlags flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter;
                e.DrawText(flags);
            }
            else
            {
                e.DrawDefault = true;
            }

        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null && button.Tag != null)
            {
                string baseName = button.Tag.ToString();
                var overlayImage = (Image)Properties.Resources.ResourceManager.GetObject(baseName + "_On");
                if (overlayImage != null)
                {
                    button.BackgroundImage = overlayImage;
                }
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null && button.Tag != null)
            {
                string baseName = button.Tag.ToString();
                var baseImage = (Image)Properties.Resources.ResourceManager.GetObject(baseName);
                if (baseImage != null)
                {
                    button.BackgroundImage = baseImage;
                }
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }

    [Serializable] //設定ファイルに保存するために必要
    public class SettingsSet
    {
        // デフォルトコンストラクター
        public SettingsSet()
        {
        }

        public string SelectedFolderPath { get; set; }
        public List<string> SelectedFiles { get; set; } = new List<string>();
        public int FileSizeLimit { get; set; }
        public int TotalSizeLimit { get; set; }
        public string Name { get; set; } // コンボボックスで表示するための名前

        public SettingsSet(string name)
        {
            Name = name;
        }
    }
}
