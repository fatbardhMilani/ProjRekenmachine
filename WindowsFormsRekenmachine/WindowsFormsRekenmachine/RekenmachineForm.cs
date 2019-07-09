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

        //////// doet maal voor delen ////////////
        private void Button_click(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;
            //textBox1.Text += buttonClick.Text;

            //if (textBox1.Text == "0")
            //{

            //}


            if (buttonClick.Text == "+" || buttonClick.Text == "-" || buttonClick.Text == "*" || buttonClick.Text == "/")
            {

                if (!displayTextBox.Text.EndsWith(buttonClick.Text))
                {

                    textBox1.Text += buttonClick.Text;
                    
                }


                displayTextBox.Text += textBox1.Text;
                textBox1.Clear();

            }
            else
            {
                textBox1.Text += buttonClick.Text;
            }


            //if (buttonClick.Text == "+" || buttonClick.Text == "-" || buttonClick.Text == "*" || buttonClick.Text == "/") 
            //{
            //    if (!textBox1.Text.EndsWith(buttonClick.Text))
            //    {

            //        //int index = textBox1.Text.Length - 1;
            //        textBox1.Text += buttonClick.Text;

            //    }

            //}
            //else
            //{
            //    textBox1.Text += buttonClick.Text;
            //}

            //if (buttonClick.Text =="+" || buttonClick.Text =="-" || buttonClick.Text == "*" || buttonClick.Text =="/")
            //{
            //    if (textBox1.Text.Substring(textBox1.Text.Length-1) == buttonClick.Text)
            //    {
            //        int index = textBox1.Text.Length-1;

            //        textBox1.Text.Insert(index, buttonClick.Text);
            //        //MessageBox.Show("ssup");
            //    } 


            //}

        }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            textBox1.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           
        }

        

        //private void PlusButton_Click(object sender, EventArgs e)
        //{
        //    //if (textBox1.Text.All("++") )
        //    //{
        //    //    textBox1.Text += "+";
        //    //}
            
        //    //char teken = '+';
        //    //textBox1.Text.SingleOrDefault(teken)
        //    //if (textBox1.Text)
        //    //{

        //    //}

        //    textBox1.Text += "+";
        //}

        //private void MinButton_Click(object sender, EventArgs e)
        //{
        //    displayTextBox.Text += "-";
        //}

        //private void MaalButton_Click(object sender, EventArgs e)
        //{

        //    textBox1.Text += "*";
        //}

        //private void DeelButton_Click(object sender, EventArgs e)
        //{
        //    displayTextBox.Text += "/";
        //}

        private void GelijkaanButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += textBox1.Text;

            Berekening bewerking = new Berekening(displayTextBox.Text);
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

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }




}
