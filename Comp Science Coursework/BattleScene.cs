using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Science_Coursework
{
    public partial class BattleScene : Form
    {

        public string[] Abilities = new string[4];

        public int PlayerHealth;
        public int EnemyHealth;
        public int PlayerEnergy;
        public string Playername;
        public int[] AbilityEnergy = new int[4];
        public int PlayerHitChance = 50;
        public int EnemyDodgeChance;
        public int PlayerDodgeChance;
        public string PlayerClass;
        public bool EnemyDefeated;
        public int Room;
        public int EnemyHitChance;
        public int XP;
        public int[] AbilityHealth = {20, 30, 40};

        public BattleScene(string Class , int NumRoom , string NamePlayer , int PlayerXP)
        {
            InitializeComponent();
        
            EnemyHealth = 100;
            PlayerHealth = 100;
            PlayerEnergy = 100;
            Playername = NamePlayer;
            PlayerClass = Class;
            Room = NumRoom;
            XP = PlayerXP;

            if (Class == "Fighter")
            {
                Abilities[0] = "Punch";
                Abilities[1] = "Slash";
                Abilities[2] = "Stab";
                Abilities[3] = "Dodge";

                AbilityEnergy[0] = 10;
                AbilityEnergy[1] = 20;
                AbilityEnergy[2] = 25;
                AbilityEnergy[3] = 30;
                PlayerHealth = 150;
            }
            else if (Class == "Agent")
            {
                Abilities[0] = "Standard Shot";
                Abilities[1] = "Rapid Fire";
                Abilities[2] = "Power Shot";
                Abilities[3] = "Dodge";

                PlayerEnergy = 150;
                AbilityEnergy[0] = 10;
                AbilityEnergy[1] = 20;
                AbilityEnergy[2] = 25;
                AbilityEnergy[3] = 30;
            }
            else if (Class == "Mystic")
            {
                Abilities[0] = "Lightning";
                Abilities[1] = "Choke";
                Abilities[2] = "Mind Tear";
                Abilities[3] = "Dodge";

                AbilityEnergy[0] = 5;
                AbilityEnergy[1] = 10;
                AbilityEnergy[2] = 15;
                AbilityEnergy[3] = 20;
            }

            if (Room == 1)
            {
                EnemyHealth = 100;
                EnemyNameLabel.Text = "Stormshocker";
                EnemyHealthLabel.Text = "100";
                EnemyDodgeChance = 10;
                EnemyHitChance = 20;
            }
            else if (Room == 2)
            {
                EnemyHealth = 100;
                EnemyNameLabel.Text = "BoneCrusher";
                EnemyHealthLabel.Text = "100";
                EnemyDodgeChance = 20;
                EnemyHitChance = 30;
            }
            else if (Room == 3)
            {
                EnemyHealth = 120;
                EnemyNameLabel.Text = "SkullBreaker";
                EnemyHealthLabel.Text = "120";
                EnemyDodgeChance = 30;
                EnemyHitChance = 40;
            }
            else if (Room == 4)
            {
                EnemyHealth = 130;
                EnemyNameLabel.Text = "DeathKnight";
                EnemyHealthLabel.Text = "130";
                EnemyDodgeChance = 35;
                EnemyHitChance = 45;
            }
            else if (Room == 5)
            {
                EnemyHealth = 150;
                EnemyNameLabel.Text = "Overlord";
                EnemyHealthLabel.Text = "150";
                EnemyDodgeChance = 50;
                EnemyHitChance = 50;
            }

            AbiltiyVisible(false);
            BackButton.Visible = false;

            Ability1Button.Text = Abilities[0];
            Ability2Button.Text = Abilities[1];
            Ability3Button.Text = Abilities[2];
            Ability4Button.Text = Abilities[3];

            PlayerName.Text = Playername;
            PlayerHealthBox.Text = "Health : " + PlayerHealth.ToString();
            PlayerEnergyBox.Text = "Energy : " + PlayerEnergy.ToString();

        }

        private void AbilityButton_Click(object sender, EventArgs e)
        {
            AbilityButton.Visible = false;
            PotionButton.Visible = false;

            AbiltiyVisible(true);
            BackButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerEnergy = PlayerEnergy - AbilityEnergy[0];
            PlayerHitChance = PlayerHitChance + 50 - EnemyDodgeChance;

            Random RNG = new Random();
            int AbilityHit = RNG.Next(100);
            if (AbilityHit < PlayerHitChance)
            {
                EnemyHealth = EnemyHealth - 20;
                AbilityHitLabel.Text = Abilities[0] + " Hit!";
                AbilityHitLabel.Visible = true;
            }
            else
            {
                AbilityHitLabel.Text = Abilities[0] + " Missed!";
                AbilityHitLabel.Visible = true;
            }
            
            PlayerHitChance = 50;
            UpdateLabels();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AbilityButton.Visible = true;
            PotionButton.Visible = true;

            AbiltiyVisible(false);
            BackButton.Visible = false;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FirstRoomForm NewForm = new FirstRoomForm(Playername , PlayerClass , EnemyDefeated , Room);
            NewForm.Visible = true;
        }

        private void PlayerHealthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerName_Click(object sender, EventArgs e)
        {
           
        }

        private void PlayerHealthBox_Click(object sender, EventArgs e)
        {
            
        }

        private void PlayerEnergyBox_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateLabels()
        {

            if (EnemyHealth == 0)
            {
                AbilityHitLabel.Text = EnemyNameLabel.Text + " has been defeated! ";
                AbiltiyVisible(false);
                EnemyDefeated = true;
                XP = XP + 20;
            }

            EnemyHealthLabel.Text = EnemyHealth.ToString();
            PlayerEnergyBox.Text = PlayerEnergy.ToString();
            PlayerHealthBox.Text = PlayerHealth.ToString();

            AbiltiyVisible(false);

            EndTurnButton.Visible = true;

        }

        public void EnemyTurn()
        {
            EnemyHitChance = EnemyHitChance - PlayerDodgeChance;
            Random RNG = new Random();
            int EnemyHit = RNG.Next(100);
            if (EnemyHit < EnemyHitChance)
            {
                PlayerHealth = PlayerHealth - 10;
                AbilityHitLabel.Text = EnemyNameLabel.Text + " hit you!";
            }
            else
            {
                AbilityHitLabel.Text = EnemyNameLabel.Text + " missed you!";
            }

            EndTurnButton.Visible = false;
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            EnemyTurn();
            AbiltiyVisible(true);
        }

        private void AbiltiyVisible(bool Visible)
        {

            Ability1Button.Visible = Visible;
            Ability2Button.Visible = Visible;
            Ability3Button.Visible = Visible;
            Ability4Button.Visible = Visible;


        }

        private void Ability2Button_Click(object sender, EventArgs e)
        {

        }

        private void Ability3Button_Click(object sender, EventArgs e)
        {

        }

        private void Ability4Button_Click(object sender, EventArgs e)
        {

        }

        public void PlayerMove()
        {

            PlayerEnergy = PlayerEnergy - AbilityEnergy[0];
            PlayerHitChance = PlayerHitChance + 50 - EnemyDodgeChance;

            Random RNG = new Random();
            int AbilityHit = RNG.Next(100);
            if (AbilityHit < PlayerHitChance)
            {
                EnemyHealth = EnemyHealth;
                AbilityHitLabel.Text = Abilities[0] + " Hit!";
                AbilityHitLabel.Visible = true;
            }
            else
            {
                AbilityHitLabel.Text = Abilities[0] + " Missed!";
                AbilityHitLabel.Visible = true;
            }

            PlayerHitChance = 50;
            UpdateLabels();

        }

    }
}
