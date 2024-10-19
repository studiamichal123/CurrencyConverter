namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAmountPLN = new Label();
            comboBoxCurrency = new TextBox();
            comboBox1 = new ComboBox();
            buttonConvert = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxAmountPLN
            // 
            textBoxAmountPLN.AutoSize = true;
            textBoxAmountPLN.Location = new Point(29, 44);
            textBoxAmountPLN.Name = "textBoxAmountPLN";
            textBoxAmountPLN.Size = new Size(77, 15);
            textBoxAmountPLN.TabIndex = 0;
            textBoxAmountPLN.Text = "Kwota w PLN";
            textBoxAmountPLN.UseWaitCursor = true;
            textBoxAmountPLN.Click += label1_Click;
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.Location = new Point(29, 71);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new Size(322, 23);
            comboBoxCurrency.TabIndex = 1;
            comboBoxCurrency.Text = "Do wpisania kwoty w PLN";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = " Do wyboru waluty docelowej (EUR, CHF, GBP).";
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(29, 109);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(75, 23);
            buttonConvert.TabIndex = 3;
            buttonConvert.Text = "Przelicz";
            buttonConvert.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(29, 196);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(150, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "Kwota po przewalutowaniu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(buttonConvert);
            Controls.Add(comboBox1);
            Controls.Add(comboBoxCurrency);
            Controls.Add(textBoxAmountPLN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textBoxAmountPLN;
        private TextBox comboBoxCurrency;
        private ComboBox comboBox1;
        private Button buttonConvert;
        private Label labelResult;
    }
}
