using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Comp_Science_Coursework
{
    public partial class FirstRoomForm : Form
    {

        public int Room;
        public string NamePlayer;
        public string Class;
        public bool EnemyDefeated;
        public int XP;
        public int HealthPotionCount;
        public int EnergyPotionCount;
        public int HitChancePotionCount;

        public FirstRoomForm(string PlayerName, string PlayerClass , bool Enemydefeated , int RoomNum , int PlayXP , int HealthPotioncount , int EnergyPotioncount , int HitChancePotioncount)
        {
            InitializeComponent();
            PlayerNameBox.Text = PlayerClass + " " + PlayerName; //Displays the users name 
            PlayerXP.Text = "XP : " + XP.ToString(); //displays the user xp

            NamePlayer = PlayerName;
            Class = PlayerClass;
            XP = PlayXP;
            Room = RoomNum;
            EnemyDefeated = Enemydefeated;
            HealthPotionCount = HealthPotioncount;
            EnergyPotionCount = EnergyPotioncount;
            HitChancePotionCount = HitChancePotioncount;

            if (EnemyDefeated == true) //if the enemy in this room has been defeated, it will stop showing up in the room so the user can continue with the game
            {
                Enemy1Button.Visible = false;
                ContinueButton.Visible = true;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void Enemy1Button_Click(object sender, EventArgs e)
        {

            this.Visible = false; //stops showing this form
            BattleScene BattleScene = new BattleScene(Class , Room , NamePlayer , XP , HealthPotionCount , EnergyPotionCount , HitChancePotionCount); //loads up the battle scene 
            BattleScene.Visible = true; //shows the battle scene
        }

        private void ContinueButton_click(object sender, EventArgs e)
        {
            Room = Room + 1; //player has now moved room
            EnemyDefeated = false; //the new enemy hasn't been defeated yet
            this.Visible = false; //stops showing this form
            FirstRoomForm NewForm = new FirstRoomForm(NamePlayer, Class , EnemyDefeated , Room , XP , HealthPotionCount , EnergyPotionCount , HitChancePotionCount); //loads up the next room
            NewForm.Visible = true; //shows the new room
        }

        private void PlayerName_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter Save = new StreamWriter(NamePlayer + ".txt")) //saves the new file using the name the user has entered 
            {

                Save.WriteLine(NamePlayer); //saves the data that is needed for the game to load in this order (so there are no errors when loading this save file)
                Save.WriteLine(Class);
                Save.WriteLine(XP);
                Save.WriteLine(Room);
                Save.WriteLine(EnemyDefeated);
                Save.WriteLine(HealthPotionCount);
                Save.WriteLine(EnergyPotionCount);
                Save.WriteLine(HitChancePotionCount);

            }
        }

        private void MiniGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false; //stops showing this form
            MiniGame NewForm = new MiniGame(); //loads the mini game
            NewForm.Visible = true; //shows the mini game
        }
    }
}
