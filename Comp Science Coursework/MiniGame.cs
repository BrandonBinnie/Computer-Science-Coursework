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

            for (int i = 0; i < 20; i++)
            {
                temp = MiniGameRandom.Next(10);
                if (MiniGameButton1.Name == "null")
                {
                    MiniGameButton1.Text = Answers[temp];
                }
            }

                InitializeComponent();

            

        }

        private void MiniGame_Load(object sender, EventArgs e)
        {

        }
    }
}
