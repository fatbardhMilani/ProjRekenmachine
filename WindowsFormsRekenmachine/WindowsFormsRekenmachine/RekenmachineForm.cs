using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RekenmachineLogic;

namespace WindowsFormsRekenmachine
{
    public partial class CalculatorForm : Form
    {

        
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "0";
        }

        private void EenButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "1";
        }

        private void TweeButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void DrieButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "3";
        }

        private void VierButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "4";
        }

        private void VijfButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "5";
        }

        private void ZesButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "6";
        }

        private void ZevenButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "7";
        }

        private void AchtButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void NegenButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            textBox1.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           
        }

        

        private void PlusButton_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.All("++") )
            //{
            //    textBox1.Text += "+";
            //}
            
            //char teken = '+';
            //textBox1.Text.SingleOrDefault(teken)
            //if (textBox1.Text)
            //{

            //}

            textBox1.Text += "+";
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "-";
        }

        private void MaalButton_Click(object sender, EventArgs e)
        {

            textBox1.Text += "*";
        }

        private void DeelButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "/";
        }

        private void GelijkaanButton_Click(object sender, EventArgs e)
        {
            Berekening bewerking = new Berekening(textBox1.Text);
            string oplossing = bewerking.Main();

            displayTextBox.Text = oplossing;
            textBox1.Clear();
        }

        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {
            Berekening bewerking = new Berekening(textBox1.Text);
            string input = textBox1.Text;


            //this.displayTextBox.
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //if ()
            //{

            //}
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
        }
    }




}
