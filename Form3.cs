using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Random randomGenerator = new Random();
        int value;
        public Form3()
        {
            InitializeComponent();
            value = randomGenerator.Next(1, 100);
        }

        private void Btn_Guess_Click(object sender, EventArgs e)
        {
            int counter = int.Parse(Lbl_counter.Text);
           
            int guess = int.Parse(Txt_Number.Text);
            if (guess > value)
            {
                Lbl_Result.Text = "Enter Lower Number";
            }
            else if (guess < value)
            {
                Lbl_Result.Text = "Enter Higher Number";
            }
            else
            {
                MessageBox.Show("You Win :)))");
            }
            Txt_Number.Text = string.Empty;

            Lbl_counter.Text = (counter - 1).ToString();
            if (guess== value)
            {
                Btn_Guess.Text = "Try Again";
          
                Lbl_counter.Text = "7";
                value = randomGenerator.Next(1, 100);
            }

           else if (Lbl_counter.Text=="0")
            {
                MessageBox.Show("Game Over ");
           
                Lbl_counter.Text = "7";
                Btn_Guess.Text = "Try Again";              
                Lbl_Result.Text = "";
                Txt_Number.Text = "";
                value = randomGenerator.Next(1, 100);

            }
        }
  
        

     
    }
}
