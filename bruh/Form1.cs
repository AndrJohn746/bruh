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
            outputLabel.Text = "Welcome to the Bitchin Kitchen! press any key to start.";
            sceneBox.BackgroundImage = Properties.Resources.scene0;
            SoundPlayer player = new SoundPlayer(Properties.Resources.chatter);
            player.Play();
            randomNum = rng.Next(1, 7);//for the random outcome of the steak
            randnum = rng.Next(1, 11);//for the random outcome of the pancake scene 

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 28) { scene = 0; } //if they want to play again this takes them to the first scene
                else if (scene == 2) { scene = 12; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 12) { scene = 15; }
                else if (scene == 16) { scene = 19; }
                else if (scene == 17) { scene = 22; }
            }

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
                else if (scene == 17) { scene = 23; }
            }

            else if (e.KeyCode == Keys.J)
            {
                if (scene == 1) { scene = 0; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 10) { scene = 28; }//all of these that go to scene 28 are just the explination scenes for why you lost, then the play again scene 
                else if (scene == 3) { scene = 28; }
                else if (scene == 8) { scene = 28; }
                else if (scene == 5) { scene = 28; }
                else if (scene == 9) { scene = 27; }
                else if (scene == 27) { scene = 28; }
                else if (scene == 14) { scene = 28; }
                else if (scene == 13) { scene = 17; }
                else if (scene == 15) { scene = 28; }
                else if (scene == 19) { scene = 28; }
                else if (scene == 18) { scene = 20; }
                else if (scene == 21) { scene = 28; }
                else if (scene == 22) { scene = 28; }
                else if (scene == 23) { scene = 28; }
                else if (scene == 24) { scene = 26; }
                else if (scene == 25) { scene = 26; }
                else if (scene == 26) { scene = 28; }
                else if (scene == 20) { scene = 28; }
                else if (scene == 18)//determines outcome, if Guy sees your pancakes or not
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
                else if (scene == 25) { scene = 28; }
                else if (scene == 17) { scene = 24; }
                else if (scene == 7)//determines outcome, weather steak is cookoed well or not
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

            }
            else if (e.KeyCode == Keys.D)
            {
                if (scene == 17) { scene = 25; }
            }

                switch (scene)
                {
                    case 0:
                        //first scene, choose your path
                        outputLabel.Text = "\n this kitchen can get pretty crazy, so show your skills, try to keep up and you might get the job!";
                        outputLabel.Text += "\n\n first of all,would you like formal dining or casual dining?";
                        choiceLabel.Text = "press M for formal, and C for casual ";
                        sceneBox.BackgroundImage = Properties.Resources.scene1;
                        SoundPlayer player = new SoundPlayer(Properties.Resources.chatter2);
                        player.Play();
                    break;
                    case 1:
                        //first scene of formal, matching wine and cheese
                        //another option if they change their mind
                        outputLabel.Text = "Welcome to formal dining. Only for the finest of chefs. Your first task is to pair wine with cheese.";
                        choiceLabel.Text = "press M for chardonay, C for pinot noir, and J if you want casual instead";
                        sceneBox.BackgroundImage = Properties.Resources.formalexcited;
                        SoundPlayer player1 = new SoundPlayer(Properties.Resources.musicnoise);
                        player1.Play();
                    break;
                    case 2:
                        //first scene of casual, making pancakes
                        //another option if they change their mind
                        outputLabel.Text = "Welcome to casual dining! were looking for the great cooks and even better food! ";
                        outputLabel.Text += "\n First of all, lets see how you make a good classic pancake. ";
                        choiceLabel.Text = "press M for small and thin, C for large and thick, and J if you want formal instead";
                        sceneBox.BackgroundImage = Properties.Resources.scene0;
                        SoundPlayer player2 = new SoundPlayer(Properties.Resources.chatterclink);
                        player2.Play();
                    break;
                    case 3:
                        //wrong choice of wine
                        outputLabel.Text = "hm. A white? with white cheese? That simply will not do. Au Revoir.";
                        sceneBox.BackgroundImage = Properties.Resources.formaldissapoint;
                        SoundPlayer player3 = new SoundPlayer(Properties.Resources.dishclatter);
                        player3.Play();
                        choiceLabel.Text = "press J to continue";
                        break;
                    case 4:
                        //right choice of wine
                        outputLabel.Text = "Excellent choice! Now to test your skills I would like to see you prepare puff pastery.";
                        choiceLabel.Text = "press M for a rolling pin, press C for the food processor";
                        sceneBox.BackgroundImage = Properties.Resources.formalnice;
                        SoundPlayer playerr = new SoundPlayer(Properties.Resources.chatternoise);
                        playerr.Play();
                    break;
                    case 5:
                        //wrong choice of pastery tool
                        outputLabel.Text = "The air is squished out of your dough, the pastery is chewy and limp. The chef is disgusted.";
                        sceneBox.BackgroundImage = Properties.Resources.formalfancy;
                        choiceLabel.Text = "press J to continue";
                        SoundPlayer playerd = new SoundPlayer(Properties.Resources.footsteps);//I accidentally named the rolling pin sound wrong they sound similar
                        playerd.Play();
                    break;
                    case 6:
                        //right choice of pastery tool
                        outputLabel.Text = "Your puff pastery is fluffy and delicious. Your peers eye you jealously. next, you are asked to prepare filet mignon";
                        outputLabel.Text += "will you use the cast iron skillet provided, or ask to use the stone oven instead?";
                        choiceLabel.Text = "press M for the skillet, press C for the stone oven";
                        sceneBox.BackgroundImage = Properties.Resources.formaljealous;
                        SoundPlayer playerdf = new SoundPlayer(Properties.Resources.pastrycut);
                        playerdf.Play();
                    break;
                    case 7:
                        //choose cast iron skillet
                        outputLabel.Text = "Hm, a bold move. You have a one in six chance of the perfect dish. Best of luck.";
                        sceneBox.BackgroundImage = Properties.Resources.risky;
                        choiceLabel.Text = "press J to continue";
                        SoundPlayer playera = new SoundPlayer(Properties.Resources.gasstove);
                        playera.Play();
                    break;
                    case 8:
                        //choose stone oven
                        outputLabel.Text = "Now thats what I like to see, I like your drive. ";
                        outputLabel.Text += "\n Your filet mignon is the best ive ever had. But alas, its still not good enough. Au Revoir";
                        sceneBox.BackgroundImage = Properties.Resources.formalwin;
                        choiceLabel.Text = "press J to continue";
                        SoundPlayer players = new SoundPlayer(Properties.Resources.chatter2);
                        players.Play();
                    break;
                    case 9:
                        //skillet works
                        outputLabel.Text = "This is the best filet mignon ive ever had. Incredible.";
                        outputLabel.Text += "\n The chef immiedietly hands over full ownership of the restaurant to you!";
                        sceneBox.BackgroundImage = Properties.Resources.goodsteak;
                        choiceLabel.Text = "press J too continue";
                        SoundPlayer playerc = new SoundPlayer(Properties.Resources.sizzlingsteak);
                        playerc.Play();
                    break;
                    case 10:
                        //skillet doesnt work
                        outputLabel.Text = "Your steak is terribly done. You leave out of shame.";
                        sceneBox.BackgroundImage = Properties.Resources.badsteak;
                        choiceLabel.Text = "press J to continue";
                        SoundPlayer playerv = new SoundPlayer(Properties.Resources.stirfry);
                        playerv.Play();
                    break;
                    case 11:
                        //you choose large pancakes, pan burns
                        outputLabel.Text = "Incredible. Off to a great start. Wait, do you hear that? ";
                        outputLabel.Text += "\n Theres smoke coming from the ther side of the kitchen! A pan was left unattended!";
                        outputLabel.Text += "\n Do you go and help?";
                        choiceLabel.Text = "press M to help and press C to not help";
                        sceneBox.BackgroundImage = Properties.Resources.casualsmoke;
                        SoundPlayer playerb = new SoundPlayer(Properties.Resources.frying);
                        playerb.Play();
                    break;
                    case 12:
                        //you choose small pancakes
                        outputLabel.Text = "Nicely done. Now, here in the kitchen we take safety very seriously. What percentage of kitchen fires are caused by unattended food?";
                        choiceLabel.Text = "press M for 60%, press C for 80%";
                        sceneBox.BackgroundImage = Properties.Resources.casualpleased;
                        SoundPlayer playern = new SoundPlayer(Properties.Resources.noisydiner);
                        playern.Play();
                    break;
                    case 13:
                        //you choose the correct percentage, Guy arrives
                        outputLabel.Text = "Great to see you take safety seriously! Oh man.. the boss is here!";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualguyenters;
                        SoundPlayer playerm= new SoundPlayer(Properties.Resources.footsteps);
                        playerm.Play();
                    break;
                    case 14:
                        //you dont help the burning pan
                        outputLabel.Text = "You are fired on the spot for lacking the safety skills required for casual dining. you should be ashamed.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualfired;
                        SoundPlayer playerf = new SoundPlayer(Properties.Resources.pplsounds);
                        playerf.Play();
                    break;
                    case 15:
                        //you choose the wrong percentage
                        outputLabel.Text = "Wow, they let you graduate cullinary school with that knowledge? Disgusting. Get out of my kitchen.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.notgoodenough;
                        SoundPlayer playert = new SoundPlayer(Properties.Resources.frying);
                        playert.Play();
                    break;
                    case 16:
                        //guy fieri enters
                        outputLabel.Text = "Excellent. Next, you must make me eggs benidict. Oh hello Mr Feiri! The owner of the establishment, Guy Fieri enters and asks that you make HIM the eggs benidict to prove your skills. ";
                        outputLabel.Text += "You are familiar with Guy's cullinary expertise, and know his favourite meal. Do you make the eggs bennidict, or make him his favourite meal?";
                        choiceLabel.Text = "press M for eggs benidict, press C for his favourite meal";
                        sceneBox.BackgroundImage = Properties.Resources.casualguyenters;
                        SoundPlayer playery = new SoundPlayer(Properties.Resources.chatternoise);
                        playery.Play();
                    break;
                    case 17:
                        //continued
                        outputLabel.Text = "Hello Guy! Chef Fieri, Sir, today Im testing the skills of this young chef to see if theyre fit for our team.";
                        outputLabel.Text += "\nGuy is impressed by your pancakes and is curious to see your full abilities, and asks you make him a meal. What do you make him?";
                        choiceLabel.Text = "press M for his trash can nachos, press C for pulled pork sandwich, press J for pancakes, press D for pizza";
                        sceneBox.BackgroundImage = Properties.Resources.casualguyishere;
                        SoundPlayer playerx = new SoundPlayer(Properties.Resources.cookingsound);
                        playerx.Play();
                    break;
                    case 18:
                        //continued
                        outputLabel.Text = "Guy is touched by the thoughtful gesture, but it is a well known fact he does not appriciate small, thin food, and your pancakes are only feet away from him";
                        outputLabel.Text += " There is a 30% chance he will see the pancakes, and not be pleased.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualguychats;
                        SoundPlayer playerz = new SoundPlayer(Properties.Resources.pplsounds);
                        playerz.Play();
                    break;
                    case 19:
                        //you make eggs benny
                        outputLabel.Text = "Guy has had many better eggs benidict in his day. He leaves to go find Americas greatest diners, drive ins and dives.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualguyleaves;
                        SoundPlayer playerq= new SoundPlayer(Properties.Resources.chatter);
                        playerq.Play();
                    break;
                    case 20:
                        //guy doesnt see your pancakes
                        outputLabel.Text = "Guy did not see your pathetic pancakes! Whew.";
                        outputLabel.Text += "\n You are hired on the spot, and he makes you his sous chef!";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualsouschef;
                        SoundPlayer playerp = new SoundPlayer(Properties.Resources.noisydiner);
                        playerp.Play();
                    break;
                    case 21:
                        //guy sees your pancakes
                        outputLabel.Text = "Guy saw your pancakes, and cut the cord.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualangryguy;
                        SoundPlayer player5 = new SoundPlayer(Properties.Resources.chatterclink);
                        player5.Play();
                    break;
                    case 22:
                        //you choose to make him nachos
                        outputLabel.Text = "Guy is insulted at your petty attempt to recreate his meal. He asks you to leave.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualangryguy;
                        SoundPlayer player6 = new SoundPlayer(Properties.Resources.chatter2);
                        player6.Play();
                    break;
                    case 23:
                        //you choose to make him pulled pork
                        outputLabel.Text = "Guy has had many better sandwiches, and tells you to pursue another career.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualangryguy;
                        SoundPlayer player0 = new SoundPlayer(Properties.Resources.stirfry);
                        player0.Play();
                    break;
                    case 24:
                        //you choose to make him pancakes
                        outputLabel.Text = "Guy is reminded of his childhood, filled with glee. ";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualhappyguy;
                        SoundPlayer pvlayer = new SoundPlayer(Properties.Resources.conversationdiner);
                        pvlayer.Play();
                    break;
                    case 25:
                        //you choose to make him pizza
                        outputLabel.Text = "Guy is almost moved to tears by the authenticity of the pizza.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualhappyguy;
                        SoundPlayer pltayer = new SoundPlayer(Properties.Resources.noisydiner);
                        pltayer.Play();
                    break;
                    case 26: 
                        //guy asks you to be his partner in crime and co own the restaurant
                        outputLabel.Text = "Guy reaches for your hand and asks if you would like to co-own his restaurant with him.";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.casualhappyguy;
                        SoundPlayer plavyer = new SoundPlayer(Properties.Resources.chatter);
                        plavyer.Play();
                    break;
                    case 27:
                        //you win formal dining with your perfect cooked steak
                        outputLabel.Text = "Congratulations, Youve won Formal Dining and have become not only an employee, but head chef!";
                        choiceLabel.Text = "press J to continue";
                        sceneBox.BackgroundImage = Properties.Resources.formalyouwin;
                        SoundPlayer playedr = new SoundPlayer(Properties.Resources.dishclatter);
                        playedr.Play();
                    break;
                    case 28:
                        //game over, play again?
                         outputLabel.Text = "Game Over! Would you like to play again?";
                         choiceLabel.Text = "press M for yes and C for no";
                         sceneBox.BackgroundImage = Properties.Resources.game_over;
                         SoundPlayer playesr = new SoundPlayer(Properties.Resources.musicnoise);
                         playesr.Play();
                    break;
                    case 29:
                         //goodbye
                         Close();
                    break;
                }           
        }

    }
}


