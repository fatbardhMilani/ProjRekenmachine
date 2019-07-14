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
        private void Button_click(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;
            
            if (textBox1.Text.EndsWith("+") || textBox1.Text.EndsWith("-") || textBox1.Text.EndsWith("/") || textBox1.Text.EndsWith("*")|| textBox1.Text.EndsWith(","))
            {
                if (buttonClick.Text == "+" || buttonClick.Text == "-" || buttonClick.Text == "*" || buttonClick.Text == "/" || buttonClick.Text == ",")
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
                    textBox1.Text += buttonClick.Text;
                }
                else
                {
                    textBox1.Text += buttonClick.Text;
                }
            }
            else if(buttonClick != null)
            {
                textBox1.Text += buttonClick.Text;
            }
        }
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            textBox1.Clear();
            geschiedenisComboBox.Items.Clear();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            } 
        }
        private void GelijkaanButton_Click(object sender, EventArgs e)
        {
            Berekening bewerking = new Berekening(textBox1.Text);
            string oplossing = bewerking.Main();

            displayTextBox.Text = oplossing;

            geschiedenisComboBox.Items.Add(textBox1.Text+" "+"=" +oplossing);
            textBox1.Clear();
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
