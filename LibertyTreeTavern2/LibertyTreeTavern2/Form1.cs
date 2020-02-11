using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyTreeTavern2
{
    public partial class Form1 : Form
    {
        double food;
        double cost;
        int numV;
        int numN;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainTitle_Click(object sender, EventArgs e)
        {

        }

        private void numVisLabel_Click(object sender, EventArgs e)
        {

        }

        private void numVisBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numV = Convert.ToInt32(numVisBox.Text);
                errorLabel.Text = "Number is valid!";
            }
            catch (FormatException)
            {
                errorLabel.Text = "Not a valid Number!";
            }

            
        }

        private void numNightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numN = Convert.ToInt32(numNightBox.Text);
                errorLabel.Text = "Number is valid!";
            }
            catch (FormatException)
            {
                errorLabel.Text = "Not a valid Number!";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex == 0)
            {
                food = 0 * numV;
            }
            if (listBox1.SelectedIndex == 1)
            {
                food = 6.99 * numV;
            }
            if (listBox1.SelectedIndex == 2)
            {
                food = 10.99 * numV;
            }

            label2.Text = "$ " + Convert.ToString(cost + food);

        }

        private void roomCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int room = 0;

           

            if (roomCheckBox.GetItemCheckState(0) == CheckState.Checked)
            {
                room = 110;

            }
            if (roomCheckBox.GetItemCheckState(1) == CheckState.Checked)
            {
                room += 120;

            }
            if (roomCheckBox.GetItemCheckState(2) == CheckState.Checked)
            {
                room += 150;

            }






            cost = numN * room;
            label2.Text = "$ " + Convert.ToString(cost);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 linc = new Form2();
            linc.ShowDialog();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 cont = new Form3();
            cont.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 jeff = new Form4();
            jeff.ShowDialog();
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
