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
        
        int scene;
        public Form1()
        {
            InitializeComponent();
            scene = 0;
            outputLabel.Text = "Welcome to the Bitchin Kitchin! press any key to start.";
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);

            switch (scene)
            {
                case 0:
                    //first scene, choose your path
                    outputLabel.Text = "\n this kitchen can get pretty crazy, so show your skills, try to keep up and you might get the job!";
                    outputLabel.Text += "\n\n first of all,would you like formal dining or casual dining?";
                    choiceLabel.Text = "press M for formal, and C for casual ";
                    
                    if (e.KeyCode == Keys.M)
                    {
                        scene = 1;
                    }
                   
                    if (e.KeyCode == Keys.C)
                    {
                        scene = 2;
                    }
                  
                    break;
                case 1:
                    //first scene of formal, matching wine and cheese
                    //another option if they change their mind
                    outputLabel.Text = "Welcome to formal dining. Only for the finest of chefs. Your first task is to pair wine with cheese.";
                    choiceLabel.Text = "press M for chardonay, C for pinot noir, and J if you want casual instead";
                  
                   
                    if (e.KeyCode == Keys.M)
                    {
                        scene = 3;
                    }
                   
                    if (e.KeyCode == Keys.C)
                    {
                        scene = 4;
                    }
                   
                    break;
                case 2:
                    //first scene of casual, making pancakes
                    //another option if they change their mind
                    outputLabel.Text = "Welcome to casual dining! were looking for the great cooks and even better food! ";
                    outputLabel.Text += "\n First of all, lets see how you made a good classic pancake. ";
                    choiceLabel.Text = "press M for small and thin, C for large and thick, and J if you want formal instead";

                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                   
                    break;
                case 3:
                    outputLabel.Text = "hm. A white? with white cheese? That simply will not do. Au Revoir.";
                    //you lose
                    break;
                case 4:
                    outputLabel.Text = "Excellent choice! Now to test your skills I would like to see you prepare puff pastery.";
                    choiceLabel.Text = "Choose M for a rolling pin, choose C for the food processor";
                    if (e.KeyCode == Keys.M)
                    {
                        scene = 6;
                    }
                    if (e.KeyCode == Keys.C)
                    {
                        scene = 7;
                    }
                    break;
                case 5:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 6:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 7:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 8:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 9:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 10:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 11:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 12:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 13:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 14:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 15:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 16:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 17:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 18:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 19:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 20:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
                    break;
                case 21:
                    if (e.KeyCode == Keys.M)
                    {

                    }
                    if (e.KeyCode == Keys.C)
                    {

                    }
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
