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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            LoadGameFiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1); //ends the program
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false; //stops showing the first form
            PlayerForm EnterNameForm = new PlayerForm();
            EnterNameForm.Visible = true; //loads up the new form to the player
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            if (LoadGameTextBox.Text != "") //if the textbox is empty it will skip past everything
            {
                if (File.Exists(LoadGameTextBox.Text + ".txt")) //this checks if the file actually exists in the folder, this is to stop the program from breaking if an invalid name is entered.
                {
                    using (StreamReader GameLoad = new StreamReader(LoadGameTextBox.Text + ".txt")) //loads up the file using the name the user has entered
                    {

                        string PlayerName;
                        string PlayerClass;
                        int PlayerXP;
                        int Room;
                        bool EnemyDefeated;
                        int HealthPotionCount;
                        int EnergyPotionCount;
                        int HitChancePotionCount;

                        PlayerName = GameLoad.ReadLine(); //saves the lines from the file and stores it in the respective variables (all save files will have the same format)
                        PlayerClass = GameLoad.ReadLine();
                        PlayerXP = int.Parse(GameLoad.ReadLine());
                        Room = int.Parse(GameLoad.ReadLine());
                        EnemyDefeated = bool.Parse(GameLoad.ReadLine());
                        HealthPotionCount = int.Parse(GameLoad.ReadLine());
                        EnergyPotionCount = int.Parse(GameLoad.ReadLine());
                        HitChancePotionCount = int.Parse(GameLoad.ReadLine());
                        if (PlayerName != null && PlayerClass != null) //this will now load up the game using the data from the save file, if for some reason there isn't a name or class, the game won't load properly, therefore a check is needed.
                        {
                            this.Visible = false; //stops showing this form
                            FirstRoomForm LoadRoom = new FirstRoomForm(PlayerName, PlayerClass, EnemyDefeated, Room, PlayerXP , HealthPotionCount , EnergyPotionCount , HitChancePotionCount); //creates a new form using the 'FirstRoomForm' layout
                            LoadRoom.Visible = true; //loads the new room
                        }
                    }
                }
                else
                {
                    LoadGameTextBox.Text = "Document not found."; //if the user entered a file that does not exist an error message will be displayed
                }
            }
          
        }
        public void LoadGameFiles()
        {
            //goes into the debug folder to the location of the save files
            DirectoryInfo gameFolder = new DirectoryInfo("C:/Users/ed/Documents/Visual Studio 2015/Projects/Comp Science Coursework/Comp Science Coursework/bin/Debug");
            //searches for all files in folder of .txt file type
            FileInfo[] Files = gameFolder.GetFiles("*.txt");
            string ListOfFiles = Files[0].Name; //puts first file from directory into array
            for (int i = 1; i < Files.Length; i++) //loops for remaining files
            {
                ListOfFiles = ListOfFiles + ", " + Files[i].Name; //adds next file, but includes .txt in name
            }
            ListOfFiles = ListOfFiles.Replace(".txt", ""); //removes all .txt from the end of the names
            ListOfFiles = ListOfFiles.Replace("Answers,", ""); //removes the answers and definitions list (these aren't game files) 
            ListOfFiles = ListOfFiles.Replace("Definitions,", "");
            ListOfFilesLabel.Text = "List of Files : " + ListOfFiles; //displays files
        }
    }
}
