using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roullete_russian
{
    public partial class maingame : Form
    {
        
        public maingame()
        {
            InitializeComponent();
        }

         spin obj_spin = new spin();

        private void button2_Click(object sender, EventArgs e)
        {   //the code below is for the gif and sound
            Image img = Image.FromFile(@"C:\Users\PC\source\repos\roullete russian\res\shoot.gif");
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PC\source\repos\roullete russian\res\shoot.wav");

            player.Play();


            for (obj_spin.shot = 0; obj_spin.shot <= 2; obj_spin.shot++)// its is for loop 
            {
                if (obj_spin.shot == 1 && obj_spin.load == obj_spin.spiner)
                {
                    obj_spin.shot = 5;
                    MessageBox.Show("You Won 100 is your score");//this is for the message pop up
                    shot_button.Enabled = false;

                    break;
                }
                else if (obj_spin.shot == 2 && obj_spin.load != obj_spin.spiner)
                {
                    MessageBox.Show("You loose");//this is for the message pop up
                    shot_button.Enabled = false;
                    
                    break;
                }

                else if (obj_spin.shot == 2 && obj_spin.load == obj_spin.spiner)
                {
                    obj_spin.shot = 5;
                    MessageBox.Show("You Won 50 is your score");//this is for the message pop up
                    shot_button.Enabled = false;

                    break;

                }

                else
                {
                    obj_spin.shot = 1;
                    obj_spin.spiner = spiner_Chamber(obj_spin.spiner);
                }

            }

        }

        private void load_button_Click(object sender, EventArgs e)
        {    // this code below is fo enabeling and disableing the button
            spin_button.Enabled = true;
            load_button.Enabled = false;
            pictureBox1.Visible = true;
            obj_spin.load = 1;
            //the code below is for the gif and sound
            pictureBox1.Image = Image.FromFile(@"C:\Users\PC\source\repos\roullete russian\res\load.gif");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PC\source\repos\roullete russian\res\load.wav");
            player.Play();


        }

        private void spin_button_Click(object sender, EventArgs e)
        {   //the code below is for the gif and sound
            Image img = Image.FromFile(@"C:\Users\PC\source\repos\roullete russian\res\spin.gif");
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\PC\source\repos\roullete russian\res\spin.wav");
            player.Play();


            obj_spin.spiner = obj_spin.spin_rnd(obj_spin.spiner);
            // this code below is fo enabeling and disableing the button
            shot_button.Enabled = true;
            spin_button.Enabled = false;
        }

        private void rety_button_Click(object sender, EventArgs e)
        {
            (new maingame()).Show();
            this.Hide();
        }
        public int spiner_Chamber(int Spin)
        {
            if (Spin == 6)//this code below sets the value of spine to 1 if the value of spin is 6
            {
                Spin = 1;

            }
            else
            {
                Spin++;

            }
            return Spin;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maingame_Load(object sender, EventArgs e)
        {

        }
    }
}
