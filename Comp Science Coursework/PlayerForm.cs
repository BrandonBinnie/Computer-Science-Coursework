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
        public PlayerForm()
         
        {
            InitializeComponent();
            PlayerContinueButton.Visible = false;


        }

        private void EnterNameButton_Click(object sender, EventArgs e)
        {
            PlayerName = PlayerNameBox.Text; //saves the player name that the user has entered into the player name text box

            ContinueButtonCheck(); //checks to see if the data the user has entered is valid
        }

        private void PlayerNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            Class = Convert.ToString(ClassBox.SelectedItem); //when the user has selected an option from the list, it will save it in the class variable
            ContinueButtonCheck(); //checks if the data the user has entered is valid
        }

        private void PlayerContinueButton_Click(object sender, EventArgs e)
        {
            this.Visible = false; //stops showing this form
            FirstRoomForm NewForm = new FirstRoomForm(PlayerName , Class , false , 1 , 0 , 2 , 2 , 2); //loads up the game using the data the user has entered
            NewForm.Visible = true; //loads up the new form
        }

        public void ContinueButtonCheck()
        {

            if (PlayerName == "" || (Class == "" || Class == null)) //if the player hasn't entered a name or selected a class, they won't be able to continue
            {
                PlayerContinueButton.Visible = false; //won't show the continue button
            }
            else
            {
                PlayerContinueButton.Visible = true; //will show the continue button so the user can play the game
            }


        }
    }
}
