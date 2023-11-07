namespace Exercise_5
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
            this.btnDecode = new Button();
            this.btnClear = new Button();
            this.btnClose = new Button();
            this.txtBoxInput = new RichTextBox();
            buttonPanel = new Panel();
            this.txtBoxOutput = new RichTextBox();
            this.labelInputText = new Label();
            labelOutputText = new Label();
            txtCodeWord = new TextBox();
            labelCodeWord = new Label();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new Point(14, 12);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new Size(306, 76);
            this.btnDecode.TabIndex = 0;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += this.btnDecode_Click;
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(449, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(306, 76);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += this.btnClear_Click;
            // 
            // btnClose
            // 
            this.btnClose.Location = new Point(872, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(306, 76);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += this.btnClose_Click;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new Point(238, 122);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new Size(970, 87);
            this.txtBoxInput.TabIndex = 3;
            this.txtBoxInput.Text = "";
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = SystemColors.ActiveCaption;
            buttonPanel.BorderStyle = BorderStyle.Fixed3D;
            buttonPanel.Controls.Add(this.btnDecode);
            buttonPanel.Controls.Add(this.btnClose);
            buttonPanel.Controls.Add(this.btnClear);
            buttonPanel.Location = new Point(12, 331);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(1196, 107);
            buttonPanel.TabIndex = 4;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new Point(238, 229);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new Size(970, 87);
            this.txtBoxOutput.TabIndex = 5;
            this.txtBoxOutput.Text = "";
            // 
            // labelInputText
            // 
            this.labelInputText.AutoSize = true;
            this.labelInputText.Location = new Point(155, 122);
            this.labelInputText.Name = "labelInputText";
            this.labelInputText.Size = new Size(77, 20);
            this.labelInputText.TabIndex = 8;
            this.labelInputText.Text = "Input Text:";
            // 
            // labelOutputText
            // 
            labelOutputText.AutoSize = true;
            labelOutputText.Location = new Point(143, 232);
            labelOutputText.Name = "labelOutputText";
            labelOutputText.Size = new Size(89, 20);
            labelOutputText.TabIndex = 9;
            labelOutputText.Text = "Output Text:";
            // 
            // txtCodeWord
            // 
            txtCodeWord.Location = new Point(238, 47);
            txtCodeWord.Name = "txtCodeWord";
            txtCodeWord.Size = new Size(187, 27);
            txtCodeWord.TabIndex = 6;
            // 
            // labelCodeWord
            // 
            labelCodeWord.AutoSize = true;
            labelCodeWord.BackColor = SystemColors.ButtonFace;
            labelCodeWord.Location = new Point(145, 50);
            labelCodeWord.Name = "labelCodeWord";
            labelCodeWord.Size = new Size(87, 20);
            labelCodeWord.TabIndex = 7;
            labelCodeWord.Text = "Code Word:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 450);
            Controls.Add(txtCodeWord);
            Controls.Add(labelCodeWord);
            Controls.Add(labelOutputText);
            Controls.Add(this.labelInputText);
            Controls.Add(this.txtBoxOutput);
            Controls.Add(this.txtBoxInput);
            Controls.Add(buttonPanel);
            Name = "Form1";
            Text = "Enigma Machine";
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Panel buttonPanel;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label labelOutputText;
        private TextBox txtCodeWord;
        private Label labelCodeWord;
        private Panel panel1;
    }
}