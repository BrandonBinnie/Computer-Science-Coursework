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

        public string[] Abilities = new string[4]; //creates the array where the ability names will be stored
        public int[] AbilityEnergy = new int[4]; //creates the array where the ability energies will be stored
        public int[] AbilityHealth = { 20, 30, 40 };
        public int[] PotionNumber = { 50, 75, 20 };

        public int PlayerHealth;
        public int EnemyHealth;
        public int PlayerEnergy;
        public string Playername;
        public int PlayerHitChance = 50;
        public int EnemyDodgeChance;
        public int PlayerDodgeChance;
        public string PlayerClass;
        public bool EnemyDefeated;
        public int Room;
        public int EnemyHitChance;
        public int XP;
        public int HealthPotionCount;
        public int EnergyPotionCount;
        public int HitChancePotionCount;
        public int EnemyDamage;

        public BattleScene(string Class , int NumRoom , string NamePlayer , int PlayerXP , int HealthPotioncount , int EnergyPotioncount , int HitChancePotioncount)
        {
            InitializeComponent();
            Playername = NamePlayer;
            PlayerClass = Class;
            Room = NumRoom;
            XP = PlayerXP;
            HealthPotionCount = HealthPotioncount;
            EnergyPotionCount = EnergyPotioncount;
            HitChancePotionCount = HitChancePotioncount;

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
                PlayerEnergy = 100;
            }
            else if (Class == "Agent")
            {
                Abilities[0] = "Standard Shot";
                Abilities[1] = "Rapid Fire";
                Abilities[2] = "Power Shot";
                Abilities[3] = "Dodge";
                PlayerHealth = 100;
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
                PlayerEnergy = 100;
                PlayerHealth = 100;
            }

            if (Room == 1)
            {
                EnemyHealth = 100;
                EnemyNameLabel.Text = "Stormshocker";
                EnemyHealthLabel.Text = "100";
                EnemyDodgeChance = 10;
                EnemyHitChance = 20;
                EnemyDamage = 10;
            }
            else if (Room == 2)
            {
                EnemyHealth = 100;
                EnemyNameLabel.Text = "BoneCrusher";
                EnemyHealthLabel.Text = "100";
                EnemyDodgeChance = 20;
                EnemyHitChance = 30;
                EnemyDamage = 20;
            }
            else if (Room == 3)
            {
                EnemyHealth = 120;
                EnemyNameLabel.Text = "SkullBreaker";
                EnemyHealthLabel.Text = "120";
                EnemyDodgeChance = 30;
                EnemyHitChance = 40;
                EnemyDamage = 30;
            }
            else if (Room == 4)
            {
                EnemyHealth = 130;
                EnemyNameLabel.Text = "DeathKnight";
                EnemyHealthLabel.Text = "130";
                EnemyDodgeChance = 35;
                EnemyHitChance = 45;
                EnemyDamage = 35;
            }
            else if (Room == 5)
            {
                EnemyHealth = 150;
                EnemyNameLabel.Text = "Overlord";
                EnemyHealthLabel.Text = "150";
                EnemyDodgeChance = 50;
                EnemyHitChance = 50;
                EnemyDamage = 40;
            }

            AbilityVisible(false);
            BackButton.Visible = false;
            HealthPotionLabel.Visible = false;
            EnergyPotionLabel.Visible = false;
            HitChanceLabel.Visible = false;

            PlayerName.Text = Playername;
            PlayerHealthBox.Text = "Health : " + PlayerHealth.ToString();
            PlayerEnergyBox.Text = "Energy : " + PlayerEnergy.ToString();

        }

        private void AbilityButton_Click(object sender, EventArgs e)
        {
            AbilityButton.Visible = false;
            PotionButton.Visible = false;

            Ability1Button.Text = Abilities[0];
            Ability2Button.Text = Abilities[1];
            Ability3Button.Text = Abilities[2];
            Ability4Button.Text = Abilities[3];

            AbilityVisible(true);
            BackButton.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AbilityButton.Visible = true;
            PotionButton.Visible = true;

            AbilityVisible(false);
            BackButton.Visible = false;

            HealthPotionLabel.Visible = false;
            EnergyPotionLabel.Visible = false;
            HitChanceLabel.Visible = false;


        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FirstRoomForm NewForm = new FirstRoomForm(Playername , PlayerClass , EnemyDefeated , Room , XP , HealthPotionCount , EnergyPotionCount , HitChancePotionCount);
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

            if (EnemyHealth <= 0)
            {
                AbilityHitLabel.Text = EnemyNameLabel.Text + " has been defeated! ";
                AbilityVisible(false);
                EnemyDefeated = true;
                XP = XP + 20;
                EndTurnButton.Visible = false;
                HealthPotionCount = HealthPotionCount + 1;
                EnergyPotionCount = EnergyPotionCount + 1;
                HitChancePotionCount = HitChancePotionCount + 1;
                RunButton.Text = "Continue";
                GameWon();
            }
            else
            {
                AbilityVisible(false);
                EndTurnButton.Visible = true;
            }
            EnemyHealthLabel.Text = "Health : " + EnemyHealth.ToString();
            PlayerEnergyBox.Text = "Energy : " + PlayerEnergy.ToString();
            PlayerHealthBox.Text = "Health : " + PlayerHealth.ToString();

            



        }

        public void EnemyTurn()
        {
            EnemyHitChance = EnemyHitChance - PlayerDodgeChance;
            Random RNG = new Random();
            int EnemyHit = RNG.Next(100);
            if (EnemyHit < EnemyHitChance)
            {
                PlayerHealth = PlayerHealth - EnemyDamage;
                PlayerHealthBox.Text = "Health : " + PlayerHealth;
                AbilityHitLabel.Text = EnemyNameLabel.Text + " hit you!";
            }
            else
            {
                AbilityHitLabel.Text = EnemyNameLabel.Text + " missed you!";
            }
            GameLost();
            
            EndTurnButton.Visible = false;
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            EnemyTurn();
            AbilityButton.Visible = true;
            PotionButton.Visible = true;

            AbilityVisible(false);
            BackButton.Visible = false;
        }

        private void AbilityVisible(bool Visible)
        {

            Ability1Button.Visible = Visible;
            Ability2Button.Visible = Visible;
            Ability3Button.Visible = Visible;
            Ability4Button.Visible = Visible;


        }

        private void Ability1Button_Click(object sender, EventArgs e)
        {
            if (Ability1Button.Text == "Health" && HealthPotionCount != 0)
            {
                PlayerHealth = PlayerHealth + 50;
                PlayerHealthBox.Text = "Health : " + PlayerHealth.ToString();
                HealthPotionCount = HealthPotionCount - 1;
                HealthPotionLabel.Text = "Health Potions : " + HealthPotionCount;
                
            }
            else if (Ability1Button.Text == Abilities[0] && PlayerEnergy >= AbilityEnergy[0])
            {
                PlayerMove(0);
            }
            
        }

        private void Ability2Button_Click(object sender, EventArgs e)
        {
            if (Ability2Button.Text == "Energy" && EnergyPotionCount != 0)
            {
                PlayerEnergy = PlayerEnergy + 75;
                PlayerEnergyBox.Text = "Energy : " + PlayerEnergy.ToString();
                EnergyPotionCount = EnergyPotionCount - 1;        
                EnergyPotionLabel.Text = "Energy Potions : " + EnergyPotionCount;
            }
            else if (Ability2Button.Text == Abilities[1] && PlayerEnergy >= AbilityEnergy[1])
            {
                PlayerMove(1);
            }
        }

        private void Ability3Button_Click(object sender, EventArgs e)
        {
            if (Ability3Button.Text == "Hit Chance" && HitChancePotionCount != 0)
            {
                PlayerHitChance = PlayerHitChance + 30;
                HitChancePotionCount = HitChancePotionCount - 1;
                HitChanceLabel.Text = "Hit Chance Potions : " + HitChancePotionCount;
            }
            else if (Ability3Button.Text == Abilities[2] && PlayerEnergy >= AbilityEnergy[2])
            {
                PlayerMove(2);
            }
        }

        private void Ability4Button_Click(object sender, EventArgs e)
        {
            PlayerDodgeChance = PlayerDodgeChance + 100;
            PlayerEnergy = PlayerEnergy - 50;
            UpdateLabels();
        }

        public void PlayerMove(int AbilityNumber)
        {

            PlayerEnergy = PlayerEnergy - AbilityEnergy[AbilityNumber];
            PlayerHitChance = PlayerHitChance + 50 - EnemyDodgeChance;

            Random RNG = new Random();
            int AbilityHit = RNG.Next(100);
            if (AbilityHit < PlayerHitChance)
            {
                EnemyHealth = EnemyHealth - AbilityHealth[AbilityNumber];
                AbilityHitLabel.Text = Abilities[AbilityNumber] + " Hit!";
                AbilityHitLabel.Visible = true;
            }
            else
            {
                AbilityHitLabel.Text = Abilities[AbilityNumber] + " Missed!";
                AbilityHitLabel.Visible = true;
            }

            PlayerHitChance = 50;
            BackButton.Visible = false;
            UpdateLabels();

        }

        private void PotionButton_Click(object sender, EventArgs e)
        {
            AbilityVisible(true);
            Ability1Button.Text = "Health";
            Ability2Button.Text = "Energy";
            Ability3Button.Text = "Hit Chance";
            Ability4Button.Visible = false;
            BackButton.Visible = true;
            AbilityButton.Visible = false;
            PotionButton.Visible = false;
            HealthPotionLabel.Visible = true;
            EnergyPotionLabel.Visible = true;
            HitChanceLabel.Visible = true;
            HealthPotionLabel.Text = "Health Potions : " + HealthPotionCount;
            EnergyPotionLabel.Text = "Energy Potions : " + EnergyPotionCount;
            HitChanceLabel.Text = "Hit Chance Potions : " + HitChancePotionCount;
        }

        public void GameWon()
        {
            if (Room == 5 && EnemyHealth <= 0)
            {
                this.Visible = false;
                EndScreen NewForm = new EndScreen();
                NewForm.Visible = true;

            }
           
        }

        public void GameLost()
        {

            if (PlayerHealth <= 0)
            {
                AbilityHitLabel.Text = EnemyNameLabel.Text + "has defeated you! Press continue to go back and try again!";
            }
            RunButton.Text = "Continue";
            RunButton.Visible = true;
            AbilityVisible(false);
            PotionButton.Visible = false;
            EndTurnButton.Visible = false;


        }
    }
}
