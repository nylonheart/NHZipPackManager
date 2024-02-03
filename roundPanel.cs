using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class RoundPanel : Panel
{
    private int cornerRadius = 10; // 角丸の半径

    public int CornerRadius
    {
        get { return cornerRadius; }
        set
        {
            if (cornerRadius != value)
            {
                cornerRadius = value;
                Invalidate(); // コントロールを再描画
            }
        }
    }

    public RoundPanel()
    {
        // アウトラインを非表示に設定
        this.BorderStyle = BorderStyle.None;

        // ダブルバッファリングを有効にする（オプション）
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // アンチエイリアスを有効にする
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // 角丸の描画
        using (GraphicsPath path = new GraphicsPath())
        {
            int radius = cornerRadius * 2;
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            Region = new Region(path);
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}