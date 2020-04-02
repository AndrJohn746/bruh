using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruh
{
    public partial class Form1 : Form
    {
        string chefName;
        int scene;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            chefName = textBox1.Text;
            scene = 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                outputLabel.Text = "you chose left or whatever";
            }
            else
            {
                outputLabel.Text = "this ones right";
            }

            //ignore this its just for each scene still figuring it out
            switch (scene)
            {
                case 0:
                    //first scene, choose your path
                    outputLabel.Text = "welcome chef " + chefName + " !!";
                    outputLabel.Text = "\n this kitchen can get pretty crazy, so show your skills, try to keep up and you might get the job!";
                    outputLabel.Text = "\n first of all,would you like formal dining or casual dining?";
                    //if M key formal, if C key casual 
                    if (e.KeyCode == Keys.M)
                    {
                        outputLabel.Text = "formal";
                        scene = 1;
                    }
                    if (e.KeyCode == Keys.C)
                    {
                        outputLabel.Text = "casual";
                        scene = 2;
                    }
                    startButton.Visible = false;
                    textBox1.Visible = false;
                    break;
                case 1:
                   
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
            }
        }
    }
}
