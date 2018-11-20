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
    public partial class FirstRoomForm : Form
    {

        public int Room;
        public string NamePlayer;
        public string Class;
        public bool EnemyDefeated;
        public int XP;

        public FirstRoomForm(string PlayerName, string PlayerClass , bool EnemyDefeated , int RoomNum)
        {
            InitializeComponent();
            PlayerNameBox.Text = PlayerClass + " " + PlayerName;
            PlayerXP.Text = XP.ToString();
            Class = PlayerClass;
            Room = RoomNum;
            NamePlayer = PlayerName;

            if (EnemyDefeated == true)
            {
                Enemy1Button.Visible = false;
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

            this.Visible = false;
            BattleScene BattleScene = new BattleScene(Class , Room , NamePlayer , XP);
            BattleScene.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room = Room + 1;
            EnemyDefeated = false;
            this.Visible = false;
            FirstRoomForm NewForm = new FirstRoomForm(NamePlayer, Class , EnemyDefeated , Room);
            NewForm.Visible = true;
        }

        private void PlayerName_Click(object sender, EventArgs e)
        {

        }
    }
}
