using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp_ziya_3_zadaniya_srazy_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightPink;
            this.Size = new Size(300, 300);


            this.Load += (s, e) =>
            {
                MessageBox.Show("Добро пожаловать!", "Приветствие");
            };

            
            this.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    MessageBox.Show("Щёлкнули правой кнопкой мыши!", "Сообщение");
                }
            };

            
            this.Resize += (s, e) => UpdateCircleRegion();
            UpdateCircleRegion();

            
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            };
        }

        private void UpdateCircleRegion()
        {
            int size = Math.Min(this.ClientSize.Width, this.ClientSize.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size, size);
            this.Region = new Region(path);
        }
    }
}

