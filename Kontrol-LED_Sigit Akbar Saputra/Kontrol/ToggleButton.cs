using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;



namespace Kontrol_LED_Sigit_Akbar_Saputra.Kontrol
{
    public class ToggleButton : CheckBox
    {
        // Field
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private Color onTextColor = Color.White;
        private Color offTextColor = Color.Silver;

        // Properties
        public Color OnBackColor { get => onBackColor; set { onBackColor = value; this.Invalidate(); } }
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); } }
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }
        public Color OnTextColor { get => onTextColor; set { onTextColor = value; this.Invalidate(); } }
        public Color OffTextColor { get => offTextColor; set { offTextColor = value; this.Invalidate(); } }

        public override string Text
        {
            get { return base.Text; }
            set {  }
        }

        // Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        // Method
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));

                // Draw "ON" text centered in the left part with bold font
                DrawCenteredText(pevent.Graphics, "ON", new Font(this.Font, FontStyle.Bold), onTextColor, new Rectangle(0, 0, this.Width - toggleSize, this.Height));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));

                DrawCenteredText(pevent.Graphics, "OFF", new Font(this.Font, FontStyle.Bold), offTextColor, new Rectangle(toggleSize, 0, this.Width - toggleSize, this.Height));
            }
        }

        private void DrawCenteredText(Graphics g, string text, Font font, Color color, Rectangle bounds)
        {
            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                using (Brush textBrush = new SolidBrush(color))
                {
                    g.DrawString(text, font, textBrush, bounds, stringFormat);
                }
            }
        }
    }
}
