using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//media add krny k lye ye 2 librries add ki ha
using System.Media;
using WMPLib;

namespace Syncfusion_style
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //media k lye
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

            //player.URL = @"C:\Users\Hassan\Downloads\Music\s.mp3";
            //ak class bnae ha class1 jsmy  ye @"C:\Users\Hassan\Downloads\Music\s.mp3"; daldia 

            player.URL = Class1.media();

            player.controls.play();

        }








        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                progressBar1.Value = 20;

                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                progressBar1.Value = 40;

                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                progressBar1.Value = 60;

                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                progressBar1.Value = 80;

                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if(pictureBox5.Visible== true)
            {
                progressBar1.Value = 100;

                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
               
        }

        private void pictureBox5_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
    }
}
