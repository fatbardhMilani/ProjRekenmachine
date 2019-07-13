namespace WindowsFormsRekenmachine
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plusMinButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.gelijkaanButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.drieButton = new System.Windows.Forms.Button();
            this.tweeButton = new System.Windows.Forms.Button();
            this.eenButton = new System.Windows.Forms.Button();
            this.maalButton = new System.Windows.Forms.Button();
            this.negenButton = new System.Windows.Forms.Button();
            this.achtButton = new System.Windows.Forms.Button();
            this.zevenButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.zesButton = new System.Windows.Forms.Button();
            this.vijfButton = new System.Windows.Forms.Button();
            this.vierButton = new System.Windows.Forms.Button();
            this.deelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vierkantswortelButton = new System.Windows.Forms.Button();
            this.procButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.geschiedenisComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // plusMinButton
            // 
            this.plusMinButton.BackColor = System.Drawing.Color.Teal;
            this.plusMinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinButton.ForeColor = System.Drawing.Color.Silver;
            this.plusMinButton.Location = new System.Drawing.Point(12, 478);
            this.plusMinButton.Name = "plusMinButton";
            this.plusMinButton.Size = new System.Drawing.Size(87, 47);
            this.plusMinButton.TabIndex = 0;
            this.plusMinButton.UseVisualStyleBackColor = false;
            this.plusMinButton.Click += new System.EventHandler(this.Button_click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Teal;
            this.zeroButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.ForeColor = System.Drawing.Color.Silver;
            this.zeroButton.Location = new System.Drawing.Point(105, 478);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(87, 47);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.Button_click);
            // 
            // commaButton
            // 
            this.commaButton.BackColor = System.Drawing.Color.Teal;
            this.commaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commaButton.ForeColor = System.Drawing.Color.Silver;
            this.commaButton.Location = new System.Drawing.Point(198, 478);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(87, 47);
            this.commaButton.TabIndex = 2;
            this.commaButton.Text = ",";
            this.commaButton.UseVisualStyleBackColor = false;
            this.commaButton.Click += new System.EventHandler(this.Button_click);
            // 
            // gelijkaanButton
            // 
            this.gelijkaanButton.BackColor = System.Drawing.Color.Teal;
            this.gelijkaanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gelijkaanButton.ForeColor = System.Drawing.Color.Silver;
            this.gelijkaanButton.Location = new System.Drawing.Point(289, 478);
            this.gelijkaanButton.Name = "gelijkaanButton";
            this.gelijkaanButton.Size = new System.Drawing.Size(87, 47);
            this.gelijkaanButton.TabIndex = 3;
            this.gelijkaanButton.Text = "=";
            this.gelijkaanButton.UseVisualStyleBackColor = false;
            this.gelijkaanButton.Click += new System.EventHandler(this.GelijkaanButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Teal;
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.Color.Silver;
            this.plusButton.Location = new System.Drawing.Point(289, 424);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(87, 47);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.Button_click);
            // 
            // drieButton
            // 
            this.drieButton.BackColor = System.Drawing.Color.Teal;
            this.drieButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drieButton.ForeColor = System.Drawing.Color.Silver;
            this.drieButton.Location = new System.Drawing.Point(198, 424);
            this.drieButton.Name = "drieButton";
            this.drieButton.Size = new System.Drawing.Size(87, 47);
            this.drieButton.TabIndex = 6;
            this.drieButton.Text = "3";
            this.drieButton.UseVisualStyleBackColor = false;
            this.drieButton.Click += new System.EventHandler(this.Button_click);
            // 
            // tweeButton
            // 
            this.tweeButton.BackColor = System.Drawing.Color.Teal;
            this.tweeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweeButton.ForeColor = System.Drawing.Color.Silver;
            this.tweeButton.Location = new System.Drawing.Point(105, 424);
            this.tweeButton.Name = "tweeButton";
            this.tweeButton.Size = new System.Drawing.Size(87, 47);
            this.tweeButton.TabIndex = 5;
            this.tweeButton.Text = "2";
            this.tweeButton.UseVisualStyleBackColor = false;
            this.tweeButton.Click += new System.EventHandler(this.Button_click);
            // 
            // eenButton
            // 
            this.eenButton.BackColor = System.Drawing.Color.Teal;
            this.eenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eenButton.ForeColor = System.Drawing.Color.Silver;
            this.eenButton.Location = new System.Drawing.Point(12, 424);
            this.eenButton.Name = "eenButton";
            this.eenButton.Size = new System.Drawing.Size(87, 47);
            this.eenButton.TabIndex = 4;
            this.eenButton.Text = "1";
            this.eenButton.UseVisualStyleBackColor = false;
            this.eenButton.Click += new System.EventHandler(this.Button_click);
            // 
            // maalButton
            // 
            this.maalButton.BackColor = System.Drawing.Color.Teal;
            this.maalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maalButton.ForeColor = System.Drawing.Color.Silver;
            this.maalButton.Location = new System.Drawing.Point(289, 316);
            this.maalButton.Name = "maalButton";
            this.maalButton.Size = new System.Drawing.Size(87, 47);
            this.maalButton.TabIndex = 15;
            this.maalButton.Text = "*";
            this.maalButton.UseVisualStyleBackColor = false;
            this.maalButton.Click += new System.EventHandler(this.Button_click);
            // 
            // negenButton
            // 
            this.negenButton.BackColor = System.Drawing.Color.Teal;
            this.negenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negenButton.ForeColor = System.Drawing.Color.Silver;
            this.negenButton.Location = new System.Drawing.Point(198, 316);
            this.negenButton.Name = "negenButton";
            this.negenButton.Size = new System.Drawing.Size(87, 47);
            this.negenButton.TabIndex = 14;
            this.negenButton.Text = "9";
            this.negenButton.UseVisualStyleBackColor = false;
            this.negenButton.Click += new System.EventHandler(this.Button_click);
            // 
            // achtButton
            // 
            this.achtButton.BackColor = System.Drawing.Color.Teal;
            this.achtButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achtButton.ForeColor = System.Drawing.Color.Silver;
            this.achtButton.Location = new System.Drawing.Point(105, 316);
            this.achtButton.Name = "achtButton";
            this.achtButton.Size = new System.Drawing.Size(87, 47);
            this.achtButton.TabIndex = 13;
            this.achtButton.Text = "8";
            this.achtButton.UseVisualStyleBackColor = false;
            this.achtButton.Click += new System.EventHandler(this.Button_click);
            // 
            // zevenButton
            // 
            this.zevenButton.BackColor = System.Drawing.Color.Teal;
            this.zevenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zevenButton.ForeColor = System.Drawing.Color.Silver;
            this.zevenButton.Location = new System.Drawing.Point(12, 316);
            this.zevenButton.Name = "zevenButton";
            this.zevenButton.Size = new System.Drawing.Size(87, 47);
            this.zevenButton.TabIndex = 12;
            this.zevenButton.Text = "7";
            this.zevenButton.UseVisualStyleBackColor = false;
            this.zevenButton.Click += new System.EventHandler(this.Button_click);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.Teal;
            this.minButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.Silver;
            this.minButton.Location = new System.Drawing.Point(289, 370);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(87, 47);
            this.minButton.TabIndex = 11;
            this.minButton.Text = "-";
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.Button_click);
            // 
            // zesButton
            // 
            this.zesButton.BackColor = System.Drawing.Color.Teal;
            this.zesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zesButton.ForeColor = System.Drawing.Color.Silver;
            this.zesButton.Location = new System.Drawing.Point(198, 370);
            this.zesButton.Name = "zesButton";
            this.zesButton.Size = new System.Drawing.Size(87, 47);
            this.zesButton.TabIndex = 10;
            this.zesButton.Text = "6";
            this.zesButton.UseVisualStyleBackColor = false;
            this.zesButton.Click += new System.EventHandler(this.Button_click);
            // 
            // vijfButton
            // 
            this.vijfButton.BackColor = System.Drawing.Color.Teal;
            this.vijfButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vijfButton.ForeColor = System.Drawing.Color.Silver;
            this.vijfButton.Location = new System.Drawing.Point(105, 370);
            this.vijfButton.Name = "vijfButton";
            this.vijfButton.Size = new System.Drawing.Size(87, 47);
            this.vijfButton.TabIndex = 9;
            this.vijfButton.Text = "5";
            this.vijfButton.UseVisualStyleBackColor = false;
            this.vijfButton.Click += new System.EventHandler(this.Button_click);
            // 
            // vierButton
            // 
            this.vierButton.BackColor = System.Drawing.Color.Teal;
            this.vierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vierButton.ForeColor = System.Drawing.Color.Silver;
            this.vierButton.Location = new System.Drawing.Point(12, 370);
            this.vierButton.Name = "vierButton";
            this.vierButton.Size = new System.Drawing.Size(87, 47);
            this.vierButton.TabIndex = 8;
            this.vierButton.Text = "4";
            this.vierButton.UseVisualStyleBackColor = false;
            this.vierButton.Click += new System.EventHandler(this.Button_click);
            // 
            // deelButton
            // 
            this.deelButton.BackColor = System.Drawing.Color.Teal;
            this.deelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deelButton.ForeColor = System.Drawing.Color.Silver;
            this.deelButton.Location = new System.Drawing.Point(289, 260);
            this.deelButton.Name = "deelButton";
            this.deelButton.Size = new System.Drawing.Size(87, 47);
            this.deelButton.TabIndex = 19;
            this.deelButton.Text = "/";
            this.deelButton.UseVisualStyleBackColor = false;
            this.deelButton.Click += new System.EventHandler(this.Button_click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Teal;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.ForeColor = System.Drawing.Color.Silver;
            this.deleteButton.Location = new System.Drawing.Point(198, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 47);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "<-";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Teal;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Silver;
            this.clearButton.Location = new System.Drawing.Point(105, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 47);
            this.clearButton.TabIndex = 17;
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.Teal;
            this.ClearAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllButton.ForeColor = System.Drawing.Color.Silver;
            this.ClearAllButton.Location = new System.Drawing.Point(12, 260);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(87, 47);
            this.ClearAllButton.TabIndex = 16;
            this.ClearAllButton.Text = "CE";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.Ivory;
            this.displayTextBox.Enabled = false;
            this.displayTextBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(12, 105);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(364, 96);
            this.displayTextBox.TabIndex = 21;
            this.displayTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(289, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 47);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(198, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 47);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // vierkantswortelButton
            // 
            this.vierkantswortelButton.BackColor = System.Drawing.Color.Teal;
            this.vierkantswortelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vierkantswortelButton.ForeColor = System.Drawing.Color.Silver;
            this.vierkantswortelButton.Location = new System.Drawing.Point(105, 207);
            this.vierkantswortelButton.Name = "vierkantswortelButton";
            this.vierkantswortelButton.Size = new System.Drawing.Size(87, 47);
            this.vierkantswortelButton.TabIndex = 23;
            this.vierkantswortelButton.UseVisualStyleBackColor = false;
            // 
            // procButton
            // 
            this.procButton.BackColor = System.Drawing.Color.Teal;
            this.procButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procButton.ForeColor = System.Drawing.Color.Silver;
            this.procButton.Location = new System.Drawing.Point(12, 207);
            this.procButton.Name = "procButton";
            this.procButton.Size = new System.Drawing.Size(87, 47);
            this.procButton.TabIndex = 22;
            this.procButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(364, 36);
            this.textBox1.TabIndex = 26;
            // 
            // geschiedenisComboBox
            // 
            this.geschiedenisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.geschiedenisComboBox.FormattingEnabled = true;
            this.geschiedenisComboBox.Location = new System.Drawing.Point(12, 54);
            this.geschiedenisComboBox.Name = "geschiedenisComboBox";
            this.geschiedenisComboBox.Size = new System.Drawing.Size(364, 38);
            this.geschiedenisComboBox.TabIndex = 27;
            // 
            // CalculatorForm
            // 
            this.AcceptButton = this.gelijkaanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(388, 533);
            this.Controls.Add(this.geschiedenisComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vierkantswortelButton);
            this.Controls.Add(this.procButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.deelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.maalButton);
            this.Controls.Add(this.negenButton);
            this.Controls.Add(this.achtButton);
            this.Controls.Add(this.zevenButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.zesButton);
            this.Controls.Add(this.vijfButton);
            this.Controls.Add(this.vierButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.drieButton);
            this.Controls.Add(this.tweeButton);
            this.Controls.Add(this.eenButton);
            this.Controls.Add(this.gelijkaanButton);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.plusMinButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Opacity = 0.8D;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.Click += new System.EventHandler(this.Button_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusMinButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button gelijkaanButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button drieButton;
        private System.Windows.Forms.Button tweeButton;
        private System.Windows.Forms.Button eenButton;
        private System.Windows.Forms.Button maalButton;
        private System.Windows.Forms.Button negenButton;
        private System.Windows.Forms.Button achtButton;
        private System.Windows.Forms.Button zevenButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button zesButton;
        private System.Windows.Forms.Button vijfButton;
        private System.Windows.Forms.Button vierButton;
        private System.Windows.Forms.Button deelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.RichTextBox displayTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button vierkantswortelButton;
        private System.Windows.Forms.Button procButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox geschiedenisComboBox;
    }
}

