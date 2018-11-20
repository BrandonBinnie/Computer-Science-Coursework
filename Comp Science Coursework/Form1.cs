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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {

            this.Visible = false; //stops showing the first form
            PlayerForm EnterNameForm = new PlayerForm();
            EnterNameForm.Visible = true; //loads up the new form to the player

            

        }
    }
}
