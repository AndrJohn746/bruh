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

namespace bruh
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int randomNum;
        int scene;
        public Form1()
        {
            InitializeComponent();
            scene = 0;
            outputLabel.Text = "Welcome to the Bitchin Kitchin! press any key to start.";
            sceneBox.BackgroundImage = Properties.Resources.scene0;
            randomNum = rng.Next(1, 11);
           
            
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) 
            {
               if (scene == 0) { scene = 1; }
               else if (scene == 1) { scene = 3; }
               else if (scene ==4) { scene = 5; }
               else if (scene == 6) {
                    if (randomNum == 6)
                    {
                        scene = 9;
                    }
                    else
                    {
                        scene = 10;
                    }
                }
               else if (scene == 28) { scene = 0; }
            }

            else if (e.KeyCode == Keys.C)
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 28) { scene = 29; }
            }

            else if (e.KeyCode == Keys.J)
            {
                if (scene == 1) { scene = 0; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 10) { scene = 28; }
                else if (scene == 3) { scene = 28; }
            }
           
            switch (scene)
            {
                case 0:
                    //first scene, choose your path
                    outputLabel.Text = "\n this kitchen can get pretty crazy, so show your skills, try to keep up and you might get the job!";
                    outputLabel.Text += "\n\n first of all,would you like formal dining or casual dining?";
                    choiceLabel.Text = "press M for formal, and C for casual ";
                    sceneBox.BackgroundImage = Properties.Resources.scene1;
                    break;
                case 1:
                    //first scene of formal, matching wine and cheese
                    //another option if they change their mind
                    outputLabel.Text = "Welcome to formal dining. Only for the finest of chefs. Your first task is to pair wine with cheese.";
                    choiceLabel.Text = "press M for chardonay, C for pinot noir, and J if you want casual instead";
                    sceneBox.BackgroundImage = Properties.Resources.formalexcited;
                    break;
                case 2:
                    //first scene of casual, making pancakes
                    //another option if they change their mind
                    outputLabel.Text = "Welcome to casual dining! were looking for the great cooks and even better food! ";
                    outputLabel.Text += "\n First of all, lets see how you made a good classic pancake. ";
                    choiceLabel.Text = "press M for small and thin, C for large and thick, and J if you want formal instead";
                    sceneBox.BackgroundImage = Properties.Resources.scene0;

                    break;
                case 3:
                    outputLabel.Text = "hm. A white? with white cheese? That simply will not do. Au Revoir.";
                    sceneBox.BackgroundImage = Properties.Resources.formaldissapoint;
                    choiceLabel.Text = "press J to continue";
                   
                    break;
                case 4:
                    outputLabel.Text = "Excellent choice! Now to test your skills I would like to see you prepare puff pastery.";
                    choiceLabel.Text = "press M for a rolling pin, press C for the food processor";
                    sceneBox.BackgroundImage = Properties.Resources.formalnice;
                    break;
                case 5:
                    outputLabel.Text = "The air is squished out of your dough, the pastery is chewy and limp. The chef is disgusted.";
                    sceneBox.BackgroundImage = Properties.Resources.formalfancy;
                    choiceLabel.Text = ""
                    // you lose
                    break;
                case 6:
                    outputLabel.Text = "Your puff pastery is fluffy and delicious. Your peers eye you jealously. next, yu are asked to prepare filet mignon";
                    outputLabel.Text += "will you use the cast iron skillet provided, or ask to use the stone oven instead?";
                    choiceLabel.Text = "press M for the skillet, press C for the stone oven";
                    sceneBox.BackgroundImage = Properties.Resources.formaljealous;

                    break;
                case 7:
                    outputLabel.Text = "Hm, a bold move. You have a one in ten chance of the perfect dish. Best of luck.";
                    sceneBox.BackgroundImage = Properties.Resources.risky;

                    break;
                case 8:
                    outputLabel.Text = "Now thats what I like to see, I like your drive. ";
                    outputLabel.Text += "\n Your milet mignon is the best ive ever had. But alas, its still not good enough. Au Revoir";
                    sceneBox.BackgroundImage = Properties.Resources.formalwin;


                    //you lose

                    break;
                case 9:
                    outputLabel.Text = "This is the best filet mignon ive ever had. Incredible.";
                    outputLabel.Text += "\n The chef immiedietly hands over full ownership of the restaurant to you!";
                    sceneBox.BackgroundImage = Properties.Resources.goodsteak;
                   
                    break;
                case 10:
                    outputLabel.Text = "Your steak is terribly done. You leave out of shame.";
                    sceneBox.BackgroundImage = Properties.Resources.badsteak;
                    choiceLabel.Text = "press J to continue";

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
                    //ur ded scene
                    outputLabel.Text = "Game Over! Would you like to play again?";
                    choiceLabel.Text = "press M for yes and C for no";


                    break;
                case 29:
                    //goodbye
                    outputLabel.Text = "Thanks for playing! Happy cooking!";
                    choiceLabel.Text = "";

                    
                    Close();
                    break;
            }
        }
    }
}
