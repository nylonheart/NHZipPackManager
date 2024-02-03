namespace FileChecker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxFileSizeLimit = new System.Windows.Forms.TextBox();
            this.comboBoxSets = new System.Windows.Forms.ComboBox();
            this.textBoxEditSetName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.textBoxTotalSizeLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.updateButton = new System.Windows.Forms.Button();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addMostRecentFileButton = new System.Windows.Forms.Button();
            this.compressButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFileSizeLimit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTotalSizeLimit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.totalSizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSetName = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileSizeLimit
            // 
            this.textBoxFileSizeLimit.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFileSizeLimit.Location = new System.Drawing.Point(482, 129);
            this.textBoxFileSizeLimit.Name = "textBoxFileSizeLimit";
            this.textBoxFileSizeLimit.Size = new System.Drawing.Size(80, 27);
            this.textBoxFileSizeLimit.TabIndex = 8;
            this.textBoxFileSizeLimit.Visible = false;
            this.textBoxFileSizeLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFileSizeLimit_KeyDown);
            // 
            // comboBoxSets
            // 
            this.comboBoxSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSets.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Bold);
            this.comboBoxSets.FormattingEnabled = true;
            this.comboBoxSets.Location = new System.Drawing.Point(18, 17);
            this.comboBoxSets.Name = "comboBoxSets";
            this.comboBoxSets.Size = new System.Drawing.Size(461, 32);
            this.comboBoxSets.TabIndex = 17;
            this.comboBoxSets.Visible = false;
            this.comboBoxSets.SelectedIndexChanged += new System.EventHandler(this.comboBoxSets_SelectedIndexChanged);
            this.comboBoxSets.DropDownClosed += new System.EventHandler(this.comboBoxSets_DropDownClosed);
            // 
            // textBoxEditSetName
            // 
            this.textBoxEditSetName.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxEditSetName.Location = new System.Drawing.Point(18, 17);
            this.textBoxEditSetName.Name = "textBoxEditSetName";
            this.textBoxEditSetName.Size = new System.Drawing.Size(416, 31);
            this.textBoxEditSetName.TabIndex = 22;
            this.textBoxEditSetName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEditSetName_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBoxTotalSizeLimit
            // 
            this.textBoxTotalSizeLimit.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTotalSizeLimit.Location = new System.Drawing.Point(482, 17);
            this.textBoxTotalSizeLimit.Name = "textBoxTotalSizeLimit";
            this.textBoxTotalSizeLimit.Size = new System.Drawing.Size(80, 27);
            this.textBoxTotalSizeLimit.TabIndex = 12;
            this.textBoxTotalSizeLimit.Visible = false;
            this.textBoxTotalSizeLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTotalSizeLimit_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(10, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Packaging List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(10, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Recent File";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.BackgroundImage = global::FileChecker.Properties.Resources.BG_PackagingList;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 209);
            this.panel1.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.panel7.Location = new System.Drawing.Point(-8, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(637, 27);
            this.panel7.TabIndex = 25;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 4);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(619, 203);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.updateButton.BackgroundImage = global::FileChecker.Properties.Resources.Rnt_Sync;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.updateButton.Location = new System.Drawing.Point(70, 235);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(40, 40);
            this.updateButton.TabIndex = 9;
            this.updateButton.Tag = "Rnt_Sync";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            this.updateButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.updateButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.SelectFolderButton.BackgroundImage = global::FileChecker.Properties.Resources.Rnt_Folder;
            this.SelectFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.SelectFolderButton.Location = new System.Drawing.Point(25, 189);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(40, 40);
            this.SelectFolderButton.TabIndex = 0;
            this.SelectFolderButton.Tag = "Rnt_Folder";
            this.SelectFolderButton.UseVisualStyleBackColor = false;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolder_Click);
            this.SelectFolderButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.SelectFolderButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddFolder.BackgroundImage = global::FileChecker.Properties.Resources.LC_Folder;
            this.btnAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddFolder.Location = new System.Drawing.Point(20, 13);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(26, 26);
            this.btnAddFolder.TabIndex = 13;
            this.btnAddFolder.Tag = "LC_Folder";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            this.btnAddFolder.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnAddFolder.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Black;
            this.AddButton.BackgroundImage = global::FileChecker.Properties.Resources.Tl_Add;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(511, 33);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 60);
            this.AddButton.TabIndex = 19;
            this.AddButton.Tag = "Tl_Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.BackgroundImage = global::FileChecker.Properties.Resources.Tl_Delete;
            this.deleteItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteItemButton.Location = new System.Drawing.Point(574, 33);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(60, 60);
            this.deleteItemButton.TabIndex = 18;
            this.deleteItemButton.Tag = "Tl_Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            this.deleteItemButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.deleteItemButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // addMostRecentFileButton
            // 
            this.addMostRecentFileButton.BackgroundImage = global::FileChecker.Properties.Resources.ArrowButton;
            this.addMostRecentFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addMostRecentFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMostRecentFileButton.Location = new System.Drawing.Point(300, 358);
            this.addMostRecentFileButton.Name = "addMostRecentFileButton";
            this.addMostRecentFileButton.Size = new System.Drawing.Size(48, 48);
            this.addMostRecentFileButton.TabIndex = 16;
            this.addMostRecentFileButton.Tag = "ArrowButton";
            this.addMostRecentFileButton.UseVisualStyleBackColor = true;
            this.addMostRecentFileButton.Click += new System.EventHandler(this.addMostRecentFileButton_Click);
            this.addMostRecentFileButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.addMostRecentFileButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // compressButton
            // 
            this.compressButton.BackgroundImage = global::FileChecker.Properties.Resources.ZIP;
            this.compressButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.compressButton.ForeColor = System.Drawing.Color.Black;
            this.compressButton.Location = new System.Drawing.Point(240, 799);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(160, 60);
            this.compressButton.TabIndex = 13;
            this.compressButton.Tag = "ZIP";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            this.compressButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.compressButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.BackgroundImage = global::FileChecker.Properties.Resources.BG_Recent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.textBoxFileSizeLimit);
            this.panel2.Controls.Add(this.labelFileSizeLimit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelFileSize);
            this.panel2.Controls.Add(this.labelFolderPath);
            this.panel2.Location = new System.Drawing.Point(12, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 174);
            this.panel2.TabIndex = 25;
            // 
            // labelFileSizeLimit
            // 
            this.labelFileSizeLimit.BackColor = System.Drawing.Color.Black;
            this.labelFileSizeLimit.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFileSizeLimit.ForeColor = System.Drawing.Color.White;
            this.labelFileSizeLimit.Location = new System.Drawing.Point(480, 129);
            this.labelFileSizeLimit.Margin = new System.Windows.Forms.Padding(0);
            this.labelFileSizeLimit.Name = "labelFileSizeLimit";
            this.labelFileSizeLimit.Size = new System.Drawing.Size(84, 27);
            this.labelFileSizeLimit.TabIndex = 9;
            this.labelFileSizeLimit.Text = "Target";
            this.labelFileSizeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFileSizeLimit.Click += new System.EventHandler(this.labelFileSizeLimit_DoubleClick);
            this.labelFileSizeLimit.DoubleClick += new System.EventHandler(this.labelFileSizeLimit_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FileChecker.Properties.Resources._75_BG_Filesize;
            this.pictureBox1.Location = new System.Drawing.Point(476, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::FileChecker.Properties.Resources.Rnt_Line;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(32, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 26);
            this.panel6.TabIndex = 8;
            // 
            // labelFileName
            // 
            this.labelFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelFileName.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.labelFileName.ForeColor = System.Drawing.Color.White;
            this.labelFileName.Location = new System.Drawing.Point(108, 80);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(499, 15);
            this.labelFileName.TabIndex = 6;
            this.labelFileName.Text = "FileName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BIZ UDPゴシック", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(575, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "MB";
            // 
            // labelFileSize
            // 
            this.labelFileSize.BackColor = System.Drawing.Color.Transparent;
            this.labelFileSize.Font = new System.Drawing.Font("BIZ UDゴシック", 20F);
            this.labelFileSize.ForeColor = System.Drawing.Color.White;
            this.labelFileSize.Location = new System.Drawing.Point(216, 123);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(257, 38);
            this.labelFileSize.TabIndex = 7;
            this.labelFileSize.Text = "FileSize";
            this.labelFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.BackColor = System.Drawing.Color.Transparent;
            this.labelFolderPath.Font = new System.Drawing.Font("BIZ UDPゴシック", 11F);
            this.labelFolderPath.ForeColor = System.Drawing.Color.White;
            this.labelFolderPath.Location = new System.Drawing.Point(59, 33);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(548, 15);
            this.labelFolderPath.TabIndex = 10;
            this.labelFolderPath.Text = "Path";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::FileChecker.Properties.Resources.BG_ListControl;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnAddFolder);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Location = new System.Drawing.Point(12, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 53);
            this.panel3.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button2.BackgroundImage = global::FileChecker.Properties.Resources.LC_Add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button2.Location = new System.Drawing.Point(77, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 4;
            this.button2.Tag = "LC_Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SelectFile_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.deleteButton.BackgroundImage = global::FileChecker.Properties.Resources.LC_Trash;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.deleteButton.Location = new System.Drawing.Point(581, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 26);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Tag = "LC_Trash";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::FileChecker.Properties.Resources.BG_TotalSize;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.textBoxTotalSizeLimit);
            this.panel4.Controls.Add(this.labelTotalSizeLimit);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.totalSizeLabel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 703);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 59);
            this.panel4.TabIndex = 27;
            // 
            // labelTotalSizeLimit
            // 
            this.labelTotalSizeLimit.BackColor = System.Drawing.Color.Black;
            this.labelTotalSizeLimit.Font = new System.Drawing.Font("BIZ UDPゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSizeLimit.ForeColor = System.Drawing.Color.White;
            this.labelTotalSizeLimit.Location = new System.Drawing.Point(484, 17);
            this.labelTotalSizeLimit.Name = "labelTotalSizeLimit";
            this.labelTotalSizeLimit.Size = new System.Drawing.Size(78, 25);
            this.labelTotalSizeLimit.TabIndex = 14;
            this.labelTotalSizeLimit.Text = "Target";
            this.labelTotalSizeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalSizeLimit.Click += new System.EventHandler(this.labelTotalSizeLimit_DoubleClick);
            this.labelTotalSizeLimit.DoubleClick += new System.EventHandler(this.labelTotalSizeLimit_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FileChecker.Properties.Resources._75_BG_Filesize;
            this.pictureBox2.Location = new System.Drawing.Point(476, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 40);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // totalSizeLabel
            // 
            this.totalSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalSizeLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 20F);
            this.totalSizeLabel.ForeColor = System.Drawing.Color.White;
            this.totalSizeLabel.Location = new System.Drawing.Point(212, 10);
            this.totalSizeLabel.Name = "totalSizeLabel";
            this.totalSizeLabel.Size = new System.Drawing.Size(257, 38);
            this.totalSizeLabel.TabIndex = 11;
            this.totalSizeLabel.Text = "TotalSize";
            this.totalSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BIZ UDPゴシック", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(575, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "MB";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::FileChecker.Properties.Resources.BG_Title;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.textBoxEditSetName);
            this.panel5.Controls.Add(this.comboBoxSets);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.labelSetName);
            this.panel5.Location = new System.Drawing.Point(12, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 60);
            this.panel5.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.button1.BackgroundImage = global::FileChecker.Properties.Resources.Tl_Arrow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(27)))), ((int)(((byte)(8)))));
            this.button1.Location = new System.Drawing.Point(446, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 22);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelSetName
            // 
            this.labelSetName.AutoSize = true;
            this.labelSetName.BackColor = System.Drawing.Color.Transparent;
            this.labelSetName.Font = new System.Drawing.Font("BIZ UDPゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSetName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSetName.Location = new System.Drawing.Point(17, 19);
            this.labelSetName.Name = "labelSetName";
            this.labelSetName.Size = new System.Drawing.Size(97, 24);
            this.labelSetName.TabIndex = 21;
            this.labelSetName.Text = "label3";
            this.labelSetName.DoubleClick += new System.EventHandler(this.labelSetName_DoubleClick);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(643, 898);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addMostRecentFileButton);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NHZipPackManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFolderButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.TextBox textBoxFileSizeLimit;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button addMostRecentFileButton;
        private System.Windows.Forms.ComboBox comboBoxSets;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label labelSetName;
        private System.Windows.Forms.TextBox textBoxEditSetName;
        private System.Windows.Forms.Label labelFileSizeLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalSizeLimit;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.TextBox textBoxTotalSizeLimit;
        private System.Windows.Forms.Label totalSizeLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

