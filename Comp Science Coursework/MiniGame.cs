using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Comp_Science_Coursework
{
    public partial class MiniGame : Form
    {

        public string[] AllDefinitions = new string[30];
        public string[] AllAnswers = new string[30];

        public string[] Answers = new string[10];
        public string[] Definitions = new string[10];

        public MiniGame()
        {

             using (StreamReader DefinitionLoad = new StreamReader("Definitions.txt"))
            {
                int i = 0;
                while ((AllDefinitions[i] = DefinitionLoad.ReadLine()) != null)
                {
                   
                    i++;
                }
                
                

            }
            using (StreamReader AnswerLoad = new StreamReader("Answers.txt"))
            {

                int i = 0;
                    while ((AllAnswers[i] = AnswerLoad.ReadLine()) != null)
                {

                 
                    i++;
                }
                
            }

            Random MiniGameRandom = new Random();

            int temp;

            for (int i = 0; i < 10; i++)
            {
                temp = MiniGameRandom.Next(25);
                for (int j = 0; j < 10; j++)
                {
                    while (AllAnswers[temp] == Answers[j])
                    {
                        temp = MiniGameRandom.Next(25);
                    }
                }


                Answers[i] = AllAnswers[temp];
                Definitions[i] = AllDefinitions[temp];
            }

            int temp2;
            for (int i = 0; i < 10; i++)
            {
                temp = MiniGameRandom.Next(1, 20);
                temp2 = MiniGameRandom.Next(2);
                if (temp == 1 && temp2 == 1)
                {
                    MiniGameButton1.Text = Answers[i];
                }
                else if(temp == 1 && temp2 == 2)
                {
                MiniGameButton1.Text = Definitions[i];
            }
                else if (temp == 2 && temp2 == 1)
                {
                    MiniGameButton2.Text = Answers[i];
                }
                else if (temp == 2 && temp2 == 2)
                {
                    MiniGameButton2.Text = Definitions[i];
                }
                else if (temp == 3 && temp2 == 1)
                {
                    MiniGameButton3.Text = Answers[i];
                }
                else if (temp == 3 && temp2 == 2)
                {
                    MiniGameButton3.Text = Definitions[i];
                }
                else if (temp == 4 && temp2 == 1)
                {
                    MiniGameButton4.Text = Answers[i];
                }
                else if (temp == 4 && temp2 == 2)
                {
                    MiniGameButton4.Text = Definitions[i];
                }
                else if (temp == 5 && temp2 == 1)
                {
                    MiniGameButton5.Text = Answers[i];
                }
                else if (temp == 5 && temp2 == 2)
                {
                    MiniGameButton5.Text = Definitions[i];
                }
                else if (temp == 6 && temp2 == 1)
                {
                    MiniGameButton6.Text = Answers[i];
                }
                else if (temp == 6 && temp2 == 2)
                {
                    MiniGameButton6.Text = Definitions[i];
                }
                else if (temp == 7 && temp2 == 1)
                {
                    MiniGameButton7.Text = Answers[i];
                }
                else if (temp == 7 && temp2 == 2)
                {
                    MiniGameButton7.Text = Definitions[i];
                }
                else if (temp == 8 && temp2 == 1)
                {
                    MiniGameButton8.Text = Answers[i];
                }
                else if (temp == 8 && temp2 == 2)
                {
                    MiniGameButton8.Text = Definitions[i];
                }
                else if (temp == 9 && temp2 == 1)
                {
                    MiniGameButton2.Text = Answers[i];
                }
                else if (temp == 9 && temp2 == 2)
                {
                    MiniGameButton9.Text = Definitions[i];
                }
                else if (temp == 10 && temp2 == 1)
                {
                    MiniGameButton9.Text = Answers[i];
                }
                else if (temp == 10 && temp2 == 2)
                {
                    MiniGameButton10.Text = Definitions[i];
                }
                else if (temp == 11 && temp2 == 1)
                {
                    MiniGameButton10.Text = Answers[i];
                }
                else if (temp == 11 && temp2 == 2)
                {
                    MiniGameButton11.Text = Definitions[i];
                }
                else if (temp == 12 && temp2 == 1)
                {
                    MiniGameButton11.Text = Answers[i];
                }
                else if (temp == 12 && temp2 == 2)
                {
                    MiniGameButton12.Text = Definitions[i];
                }
                else if (temp == 13 && temp2 == 1)
                {
                    MiniGameButton12.Text = Answers[i];
                }
                else if (temp == 13 && temp2 == 2)
                {
                    MiniGameButton13.Text = Definitions[i];
                }
                else if (temp == 14 && temp2 == 1)
                {
                    MiniGameButton13.Text = Answers[i];
                }
                else if (temp == 14 && temp2 == 2)
                {
                    MiniGameButton14.Text = Definitions[i];
                }
                else if (temp == 15 && temp2 == 1)
                {
                    MiniGameButton14.Text = Answers[i];
                }
                else if (temp == 15 && temp2 == 2)
                {
                    MiniGameButton15.Text = Definitions[i];
                }
                else if (temp == 16 && temp2 == 1)
                {
                    MiniGameButton15.Text = Answers[i];
                }
                else if (temp == 16 && temp2 == 2)
                {
                    MiniGameButton16.Text = Definitions[i];
                }
                else if (temp == 17 && temp2 == 1)
                {
                    MiniGameButton17.Text = Answers[i];
                }
                else if (temp == 17 && temp2 == 2)
                {
                    MiniGameButton17.Text = Definitions[i];
                }
                else if (temp == 18 && temp2 == 1)
                {
                    MiniGameButton18.Text = Answers[i];
                }
                else if (temp == 18 && temp2 == 2)
                {
                    MiniGameButton18.Text = Definitions[i];
                }
                else if (temp == 19 && temp2 == 1)
                {
                    MiniGameButton19.Text = Answers[i];
                }
                else if (temp == 19 && temp2 == 2)
                {
                    MiniGameButton19.Text = Definitions[i];
                }
                else if (temp == 20 && temp2 == 1)
                {
                    MiniGameButton20.Text = Answers[i];
                }
                else if (temp == 20 && temp2 == 2)
                {
                    MiniGameButton20.Text = Definitions[i];
                }
            }
          

            


                InitializeComponent();

            

        }

        private void MiniGame_Load(object sender, EventArgs e)
        {

        }
    }
}
