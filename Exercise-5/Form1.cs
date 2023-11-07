namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Assignment must dos!
         1. 2d array therefore must use a nested loop
         2. Use methods when possible
         3. clear button to clear all text boxes
         4. user inputs a keyword and text that they wish to encrypt or decrypt
         5. Use a playfair cypher (substitution cypher) but simpler, simple substitution method
         6. It must only encrypt alphabetic letters, not nums or punct
         7. playfair matrix 5x5 to which 25 of the 26 letters are loaded, one letter will have to represent two
         8. The keyword is what determines the order in which letters are loaded (key)
         9. non- duplicating letters loaded into the matrix first from left to right starting at the top row
            then all remaining unused letters are loaded into matrix, in normal order. Must drop duplicate letters*/

        private void codeArray()
        {
            txtCodeWord.TextBox

            string[,] myArray = {
                { "", "", "", "", "" },
                { "", "", "", "", "" },
                { "", "", "", "", "" },
                { "", "", "", "", "" },
                { "", "", "", "", "" },
            };
            

        private void btnDecode_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (Control is TextBox) ;
                {
                    Control.Text = string.Empty;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}