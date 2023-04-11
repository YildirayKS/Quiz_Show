namespace Quiz_Show
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.lbl_QuestionNumber = new System.Windows.Forms.Label();
            this.lbl_CorrectAnswer = new System.Windows.Forms.Label();
            this.lbl_WrongAnswer = new System.Windows.Forms.Label();
            this.btn_NextQuestion = new System.Windows.Forms.Button();
            this.pictureBox_Correct = new System.Windows.Forms.PictureBox();
            this.pictureBox_False = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_False)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(421, 202);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(13, 238);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(202, 46);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(232, 238);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(202, 46);
            this.btn_B.TabIndex = 1;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(14, 290);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(202, 46);
            this.btn_C.TabIndex = 2;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.Location = new System.Drawing.Point(233, 290);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(202, 46);
            this.btn_D.TabIndex = 3;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // lbl_QuestionNumber
            // 
            this.lbl_QuestionNumber.AutoSize = true;
            this.lbl_QuestionNumber.Location = new System.Drawing.Point(449, 29);
            this.lbl_QuestionNumber.Name = "lbl_QuestionNumber";
            this.lbl_QuestionNumber.Size = new System.Drawing.Size(204, 28);
            this.lbl_QuestionNumber.TabIndex = 2;
            this.lbl_QuestionNumber.Text = "Question Number: 0";
            // 
            // lbl_CorrectAnswer
            // 
            this.lbl_CorrectAnswer.AutoSize = true;
            this.lbl_CorrectAnswer.Location = new System.Drawing.Point(449, 69);
            this.lbl_CorrectAnswer.Name = "lbl_CorrectAnswer";
            this.lbl_CorrectAnswer.Size = new System.Drawing.Size(181, 28);
            this.lbl_CorrectAnswer.TabIndex = 2;
            this.lbl_CorrectAnswer.Text = "Correct Answer: 0";
            // 
            // lbl_WrongAnswer
            // 
            this.lbl_WrongAnswer.AutoSize = true;
            this.lbl_WrongAnswer.Location = new System.Drawing.Point(449, 113);
            this.lbl_WrongAnswer.Name = "lbl_WrongAnswer";
            this.lbl_WrongAnswer.Size = new System.Drawing.Size(174, 28);
            this.lbl_WrongAnswer.TabIndex = 2;
            this.lbl_WrongAnswer.Text = "Wrong Answer: 0";
            // 
            // btn_NextQuestion
            // 
            this.btn_NextQuestion.Location = new System.Drawing.Point(454, 159);
            this.btn_NextQuestion.Name = "btn_NextQuestion";
            this.btn_NextQuestion.Size = new System.Drawing.Size(237, 56);
            this.btn_NextQuestion.TabIndex = 4;
            this.btn_NextQuestion.Text = "Next Question";
            this.btn_NextQuestion.UseVisualStyleBackColor = true;
            this.btn_NextQuestion.Click += new System.EventHandler(this.btn_NextQuestion_Click);
            // 
            // pictureBox_Correct
            // 
            this.pictureBox_Correct.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Correct.Image")));
            this.pictureBox_Correct.Location = new System.Drawing.Point(454, 238);
            this.pictureBox_Correct.Name = "pictureBox_Correct";
            this.pictureBox_Correct.Size = new System.Drawing.Size(109, 98);
            this.pictureBox_Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Correct.TabIndex = 3;
            this.pictureBox_Correct.TabStop = false;
            this.pictureBox_Correct.Visible = false;
            // 
            // pictureBox_False
            // 
            this.pictureBox_False.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_False.Image")));
            this.pictureBox_False.Location = new System.Drawing.Point(582, 238);
            this.pictureBox_False.Name = "pictureBox_False";
            this.pictureBox_False.Size = new System.Drawing.Size(109, 98);
            this.pictureBox_False.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_False.TabIndex = 3;
            this.pictureBox_False.TabStop = false;
            this.pictureBox_False.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_False);
            this.Controls.Add(this.pictureBox_Correct);
            this.Controls.Add(this.lbl_WrongAnswer);
            this.Controls.Add(this.lbl_CorrectAnswer);
            this.Controls.Add(this.lbl_QuestionNumber);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_NextQuestion);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_False)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Label lbl_QuestionNumber;
        private System.Windows.Forms.Label lbl_CorrectAnswer;
        private System.Windows.Forms.Label lbl_WrongAnswer;
        private System.Windows.Forms.Button btn_NextQuestion;
        private System.Windows.Forms.PictureBox pictureBox_Correct;
        private System.Windows.Forms.PictureBox pictureBox_False;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

