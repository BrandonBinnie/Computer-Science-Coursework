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
    public partial class PlayerForm : Form
    {
        public string PlayerName;
        public string Class;
        public int Room = 1;
        public bool EnemyDefeated;
        public PlayerForm()
         
        {
            InitializeComponent();
            PlayerContinueButton.Visible = false;


        }

        private void EnterNameButton_Click(object sender, EventArgs e)
        {
            PlayerName = PlayerNameBox.Text;

            ContinueButtonCheck();
        }

        private void PlayerNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            Class = Convert.ToString(ClassBox.SelectedItem);
            ContinueButtonCheck();
        }

        private void PlayerContinueButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FirstRoomForm NewForm = new FirstRoomForm(PlayerName , Class , EnemyDefeated , Room);
            NewForm.Visible = true;
        }

        public void ContinueButtonCheck()
        {

            if (PlayerName != null && Class != null)
            {
                PlayerContinueButton.Visible = true;
            }
            else
            {
                PlayerContinueButton.Visible = false;
            }


        }
    }
}
