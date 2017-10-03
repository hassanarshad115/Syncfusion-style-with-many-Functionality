using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Media;
using WMPLib;


namespace Syncfusion_style
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void choosebutton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            try {

                //System.Media.SoundPlayer obj = new System.Media.SoundPlayer();
                //obj.SoundLocation = textBox1.Text;
                //obj.Load();
                //obj.PlaySync();

                WMPLib.WindowsMediaPlayer p = new WMPLib.WindowsMediaPlayer();
                p.URL = textBox1.Text;
                p.controls.play();


            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
    }
}

//OpenFileDialog ofd = new OpenFileDialog();

//            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
//            {
//                textBox1.Text = ofd.FileName;
////            }


//            WMPLib.WindowsMediaPlayer p = new WMPLib.WindowsMediaPlayer();
//             p.URL = textBox1.Text;
//                p.controls.play();