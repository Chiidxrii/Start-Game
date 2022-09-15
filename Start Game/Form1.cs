using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace Start_Game
{
    public partial class Form1 : Form
    {
        private object countdonwLabel3;
        private object beep6Player;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer blopPlayer = new SoundPlayer(Properties.Resources.blop);

            blopPlayer.Play();
            Thread.Sleep(800);

         startButton.Visible = false; 

         cloudjumperLabel.Visible = false;

         saveoneButton.Visible = true;

         savetwoButton.Visible = true;

         savesLabel.Visible = true;
        }

        private void saveoneButton_Click(object sender, EventArgs e)
        {
            saveoneButton.Visible = false;

            savetwoButton.Visible = false;

            savesLabel.Visible = false;

            SoundPlayer blopPlayer = new SoundPlayer(Properties.Resources.blop);

            blopPlayer.Play();
            Thread.Sleep(800);

            countdownLabel3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel3.Visible = false;

            countdownLabel2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel2.Visible = false;

            countdownLabel1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel1.Visible = false;

            goLabel.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            goLabel.Visible = false;

        }

        private void savesLabel_Click(object sender, EventArgs e)
        {

        }

        private void savetwoButton_Click(object sender, EventArgs e)
        {
            saveoneButton.Visible = false;

            savetwoButton.Visible = false;

            savesLabel.Visible = false;

            SoundPlayer blopPlayer = new SoundPlayer(Properties.Resources.blop);

            blopPlayer.Play();
            Thread.Sleep(800);

            
            blopPlayer.Play();
            Refresh(); 

            countdownLabel3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel3.Visible = false;
            //create a sound player and load the alert.wav sound, then play it 


            blopPlayer.Play();
            Refresh();

            countdownLabel2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel2.Visible = false;


            blopPlayer.Play();
            Refresh();

            countdownLabel1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel1.Visible = false;


            blopPlayer.Play();
            Refresh();

            goLabel.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            goLabel.Visible = false;

        }
    }
}
