namespace WindowsFormsApp1
{
    partial class Form3
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
            this.Btn_Guess = new System.Windows.Forms.Button();
            this.Lbl_Result = new System.Windows.Forms.Label();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Guess
            // 
            this.Btn_Guess.Location = new System.Drawing.Point(130, 112);
            this.Btn_Guess.Name = "Btn_Guess";
            this.Btn_Guess.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guess.TabIndex = 0;
            this.Btn_Guess.Text = "Guess";
            this.Btn_Guess.UseVisualStyleBackColor = true;
            this.Btn_Guess.Click += new System.EventHandler(this.Btn_Guess_Click);
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.AutoSize = true;
            this.Lbl_Result.Location = new System.Drawing.Point(147, 150);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Result.TabIndex = 1;
            // 
            // Txt_Number
            // 
            this.Txt_Number.Location = new System.Drawing.Point(91, 62);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(170, 20);
            this.Txt_Number.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "count :";
            // 
            // Lbl_counter
            // 
            this.Lbl_counter.AutoSize = true;
            this.Lbl_counter.Location = new System.Drawing.Point(184, 255);
            this.Lbl_counter.Name = "Lbl_counter";
            this.Lbl_counter.Size = new System.Drawing.Size(13, 13);
            this.Lbl_counter.TabIndex = 4;
            this.Lbl_counter.Text = "7";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 286);
            this.Controls.Add(this.Lbl_counter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Number);
            this.Controls.Add(this.Lbl_Result);
            this.Controls.Add(this.Btn_Guess);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Guess;
        private System.Windows.Forms.Label Lbl_Result;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_counter;
    }
}