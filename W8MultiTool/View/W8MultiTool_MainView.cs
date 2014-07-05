using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class W8MultiTool_MainView : Form
    {
        public W8MultiTool_MainView()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width);
            TitleBar.Size = new System.Drawing.Size(200, 30);
            Exit_PicBox.Location = new System.Drawing.Point(170, 0);
            Max_PicBox.Location = new System.Drawing.Point(139, 0);
            this.Size = new System.Drawing.Size(200, 150);

            CpuRate_panel.Hide();
            RamRate_panel.Hide();
            HddRate_panel.Hide();

            Hdd_label.Location = new System.Drawing.Point(102, 35);
            HddCount_label.Location = new System.Drawing.Point(107, 61);
            Another_label.Location = new System.Drawing.Point(102, 90);
            AnotherCount_label.Location = new System.Drawing.Point(107, 120);
        }

        Point formloc, curloc = new Point(0, 0);
        private void setpositions()
        {
            formloc = this.Location;
            //
            curloc = Cursor.Position;
            //
        }
        private void timer_W8_Tick(object sender, EventArgs e)
        {           
            int exe = formloc.X - curloc.X + Cursor.Position.X;
            int eye = formloc.Y - curloc.Y + Cursor.Position.Y;
            this.Location = new Point(exe, eye);        
        }

        int i = 0;
        private void Max_PicBox_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                this.Size = new System.Drawing.Size(250, 272);
                i++;
                CpuRate_panel.Show();
                RamRate_panel.Show();
                HddRate_panel.Show();

                TitleBar.Size = new System.Drawing.Size(250, 30);
                Exit_PicBox.Location = new System.Drawing.Point(220, 0);
                Max_PicBox.Location = new System.Drawing.Point(189, 0);

                Hdd_label.Location = new System.Drawing.Point(4, 149);
                HddCount_label.Location = new System.Drawing.Point(9, 183);
                Another_label.Location = new System.Drawing.Point(8, 213);
                AnotherCount_label.Location = new System.Drawing.Point(15, 246);

                //Clock_label.Size = new System.Drawing.Size(113, 24);
                //Clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            }

            else
            {
                this.Size = new System.Drawing.Size(200, 150);
                i++;
                CpuRate_panel.Hide();
                RamRate_panel.Hide();
                HddRate_panel.Hide();

                TitleBar.Size = new System.Drawing.Size(200, 30);
                Exit_PicBox.Location = new System.Drawing.Point(170, 0);
                Max_PicBox.Location = new System.Drawing.Point(139, 0);

                Hdd_label.Location = new System.Drawing.Point(102, 35);
                HddCount_label.Location = new System.Drawing.Point(107, 61);
                Another_label.Location = new System.Drawing.Point(102, 90);
                AnotherCount_label.Location = new System.Drawing.Point(107, 120);

                //Clock_label.Size = new System.Drawing.Size(70, 25);
                //Clock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
            }
        }

        private void Max_PicBox_MouseEnter(object sender, EventArgs e)
        {
            Max_PicBox.BackColor = Color.Silver;
        }

        private void Max_PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            Max_PicBox.BackColor = Color.Gainsboro;
        }

        private void Max_PicBox_MouseLeave(object sender, EventArgs e)
        {
            Max_PicBox.BackColor = Color.Gray;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            setpositions();
            timer_W8.Start();
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            setpositions();
            timer_W8.Stop();
        }

        private void Exit_PicBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            Exit_PicBox.BackgroundImage = Properties.Resources.exit_click;
        }

        private void Exit_PicBox_MouseEnter(object sender, EventArgs e)
        {
            Exit_PicBox.BackgroundImage = Properties.Resources.exit_enter;
        }

        private void Exit_PicBox_MouseLeave(object sender, EventArgs e)
        {
            Exit_PicBox.BackgroundImage = Properties.Resources.exit;
        }
    }
}
