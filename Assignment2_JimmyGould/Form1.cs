using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Jimmy Gould
/// Assignment 2
/// 8/29/16
/// To fufill assignment requirements
/// </summary>
namespace Assignment2_JimmyGould
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Closes program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //clears label text
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblName.Text = "";
        }

        //I am adding commets to see if this works ;lkasdjf;lawjf;lawkjewl;aejf
        //asd;lkfja;wjfa;lsdjf;alk
        //Hides images
        private void btnHide_Click(object sender, EventArgs e)
        {
            picDeadpool.Visible = false;
            picHulk.Visible = false;
            picIronMan.Visible = false;
            picSpiderman.Visible = false;

            //asdl;kfjasd;lfjiawen;zljse;roiajwe;ofja;lksejralkja

        }

        //shows images
        private void btnShow_Click(object sender, EventArgs e)
        {
            picDeadpool.Visible = true;
            picHulk.Visible = true;
            picIronMan.Visible = true;
            picSpiderman.Visible = true;
        }

        //displays text when spiderman is clicked
        private void picSpiderman_Click(object sender, EventArgs e)
        {
            lblName.Text = "Spiderman";
        }

        //displays text when iron man is clicked
        private void picIronMan_Click(object sender, EventArgs e)
        {
            lblName.Text = "Iron Man";
        }

        //displays text when the hulk is clicked
        private void picHulk_Click(object sender, EventArgs e)
        {
            lblName.Text = "The Incredible Hulk";
        }

        //displays text when deadpool is clicked
        private void picDeadpool_Click(object sender, EventArgs e)
        {
            lblName.Text = "Deadpool";
        }


    }
}
