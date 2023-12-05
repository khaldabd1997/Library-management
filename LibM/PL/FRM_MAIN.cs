using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibM.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // here we can terminate our application.
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // here we can minimize the window size.
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if( WindowState == FormWindowState.Normal) //here make sure if the windows in normal state.
            {
                this.WindowState = FormWindowState.Maximized; //if yes ,maximize the window.
            }
            else
                this.WindowState = FormWindowState.Normal; //if no ,turn back the window to its normal state.
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width == 165)
            {
                pictureBox1.Visible = false;
                P_MB.Width = 50;
                bunifuImageButton6.Location = new Point(10, 3);



            }
            else
            {
                pictureBox1.Visible = true;
                P_MB.Width = 165;
                bunifuImageButton6.Location = new Point(10, 3);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
