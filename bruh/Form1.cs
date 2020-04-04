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
        int randnum;
        int scene;
        public Form1()
        {
            InitializeComponent();
            scene = 0;
            outputLabel.Text = "Welcome to the Bitchin Kitchin! press any key to start.";
            sceneBox.BackgroundImage = Properties.Resources.scene0;
            randomNum = rng.Next(1, 7);
            randnum = rng.Next(1, 11);

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 6)
                {
                    if (randomNum == 6)
                    {
                        scene = 9;//scene where the food is perfect
                    }
                    else
                    {
                        scene = 10;//scene where food is not
                    }
                }
                else if (scene == 28) { scene = 0; } //if they want to play again this takes them to the first scene
                else if (scene == 2) { scene = 12; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 12) { scene = 15; }
                else if (scene ==16) { scene = 19; }


                else if (e.KeyCode == Keys.C)
                {
                    if (scene == 0) { scene = 2; }
                    else if (scene == 2) { scene = 11; }
                    else if (scene == 1) { scene = 4; }
                    else if (scene == 4) { scene = 6; }
                    else if (scene == 6) { scene = 8; }
                    else if (scene == 28) { scene = 29; }//if they dont want to play again this closes the program
                    else if (scene == 11) { scene = 14; }
                    else if (scene == 12) { scene = 16; }
                    else if (scene == 16) { scene = 18; }
                }

                else if (e.KeyCode == Keys.J)
                {
                    if (scene == 1) { scene = 0; }
                    else if (scene == 2) { scene = 0; }
                    else if (scene == 10) { scene = 28; }
                    else if (scene == 3) { scene = 28; }
                    else if (scene == 8) { scene = 28; }
                    else if (scene == 5) { scene = 28; }
                    else if (scene == 9) { scene = 27; }
                    else if (scene == 27) { scene = 28; }
                    else if (scene == 14) { scene = 28; }
                    else if (scene == 13) { scene = 17; }
                    else if (scene == 15) { scene = 28; }
                    else if (scene ==19) { scene = 28; }
                    else if (scene == 18) { scene = 20; }
                    else if (scene == 21) { scene = 28; }
                    else if (scene == 18)
                    {
                        if (randnum <= 3)
                        {
                            scene = 21;//he sees the pancakes you lose
                        }
                        else
                        {
                            scene = 20;//he doesnt see the pancakes
                        }
                    }

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
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 6:
                        outputLabel.Text = "Your puff pastery is fluffy and delicious. Your peers eye you jealously. next, you are asked to prepare filet mignon";
                        outputLabel.Text += "will you use the cast iron skillet provided, or ask to use the stone oven instead?";
                        choiceLabel.Text = "press M for the skillet, press C for the stone oven";
                        sceneBox.BackgroundImage = Properties.Resources.formaljealous;

                        break;
                    case 7:
                        outputLabel.Text = "Hm, a bold move. You have a one in six chance of the perfect dish. Best of luck.";
                        sceneBox.BackgroundImage = Properties.Resources.risky;

                        break;
                    case 8:
                        outputLabel.Text = "Now thats what I like to see, I like your drive. ";
                        outputLabel.Text += "\n Your filet mignon is the best ive ever had. But alas, its still not good enough. Au Revoir";
                        sceneBox.BackgroundImage = Properties.Resources.formalwin;
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 9:
                        outputLabel.Text = "This is the best filet mignon ive ever had. Incredible.";
                        outputLabel.Text += "\n The chef immiedietly hands over full ownership of the restaurant to you!";
                        sceneBox.BackgroundImage = Properties.Resources.goodsteak;
                        choiceLabel.Text = "press J too continue";

                        break;
                    case 10:
                        outputLabel.Text = "Your steak is terribly done. You leave out of shame.";
                        sceneBox.BackgroundImage = Properties.Resources.badsteak;
                        choiceLabel.Text = "press J to continue";

                        break;

                    //above is all formal
                    //below is all casual

                    case 11:
                        outputLabel.Text = "Incredible. Off to a great start. Wait, do you hear that?";
                        outputLabel.Text += "\n Theres smoke coming from the ther side of the kitchen! A pan was left unattended!";
                        outputLabel.Text += "\n Do you go and help?";
                        choiceLabel.Text = "press M to help and press C to not help";


                        break;
                    case 12:
                        outputLabel.Text = "Nicely done. Now, here in the kitchen we take safety very seriously. What percentage of kitchen fires are caused by unattended food?";
                        choiceLabel.Text = "press M for 60%, press C for 80%";


                        break;
                    case 13:
                        outputLabel.Text = "Great to see you take safety seriously! Oh man.. the boss is here!";
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 14:
                        outputLabel.Text = "You are fired on the spot for lacking the safety skills required for casual dining. you should be shamed.";
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 15:
                        outputLabel.Text = "Wow, they let you graduate cullinary school with that knowledge? Disgusting. Get out of my kitchin.";
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 16:
                        outputLabel.Text = "Excellent. Next, you must make me eggs benidict. Oh hello Mr Feiri! ";
                        outputLabel.Text += "\n The owner of the establishment, Guy Fieri enters and asks whats going on. He asks that you make HIM the eggs benidict to prove your skills.";
                        outputLabel.Text += "You are familiar with Guy's cullinary expertise, and know his favourite meal. Do you make the eggs bennidict, or make him his favourite meal?";
                        choiceLabel.Text = "press M for eggs benidict, press C for his favourite meal";


                        break;
                    case 17:
                        outputLabel.Text = "Hello Guy! Chef Fieri, Sir, today Im testing the skills of this young chef to see if theyre fit for our team.";
                        outputLabel.Text += "\nGuy glances back at your beautifully cooked pancakes still plated, and is impressed.";
                        outputLabel.Text += "\nHe is curious to see your full abilities, and ask you make him a meal. What do you make him?";
                        choiceLabel.Text = "press M for his classic trash can nachos";
                        choiceLabel.Text += "\npress C for a pulled pork sandwich";
                        choiceLabel.Text += "\npress J for a stack of those pancakes he liked";
                        choiceLabel.Text += "\npress D for a traditional pizza from scratch";

                        break;
                    case 18:
                        outputLabel.Text = "Guy is touched by the thoughtful gesture, but it is a well known fact he des not appriciate small, thin food, and your pancakes are only feet away from him";
                        outputLabel.Text += "There is a 30% chance he will see the pancakes, and not be pleased.";
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 19:
                        outputLabel.Text = "Guy has had many better eggs benidict in his day. He leaves to go find Americas greatest diners, drive ins and dives.";
                        choiceLabel.Text = "press J to continue";

                        break;
                    case 20:
                        outputLabel.Text = "Guy did not see your pathetic pancakes! Whew.";
                        outputLabel.Text += "\n You are hired on the spot, and he makes you his sous chef!";
                        choiceLabel.Text = "press J to continue";
                        //you win
                        break;
                    case 21:
                        outputLabel.Text = "Guy saw your pancakes, and cut the cord.";
                        choiceLabel.Text = "press J to continue";

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
                        //formal you win scene
                        outputLabel.Text = "Congratulations, Youve won Formal Dining and have become not only an employee, but head chef!";
                        choiceLabel.Text = "press J to continue";
                        //needs win image

                        break;
                    case 28:
                        //ur ded scene
                        outputLabel.Text = "Game Over! Would you like to play again?";
                        choiceLabel.Text = "press M for yes and C for no";
                        //needs win image

                        break;
                    case 29:
                        //goodbye
                        outputLabel.Text = "Thanks for playing! Happy cooking!";
                        choiceLabel.Text = "";
                        //needs thanks image

                        Close();
                        break;
                }
            }
        }
    }
}
