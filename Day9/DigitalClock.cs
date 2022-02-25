using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day9
{
    public partial class DigitalClock : Control
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics gr = pe.Graphics;
            gr.FillRectangle(Brushes.Yellow, 0, 0, this.Width, this.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            string time = DateTime.Now.ToString("hh:mm:ss");

            SizeF stringSize = gr.MeasureString(time, this.Font);

            gr.Clear(Color.Yellow);
            gr.DrawString(time, this.Font,
                Brushes.Black, (this.Width / 2) - stringSize.Width /2,
                (this.Height / 2) - stringSize.Height / 2);
        }
    }
}
