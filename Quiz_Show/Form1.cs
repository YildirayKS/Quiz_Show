using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNumber = 1, correctAnswer = 0, wrongAnswer = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "What year was the very first model of the iPhone released?";

            btn_A.Text = "2003";
            btn_B.Text = "2005";
            btn_C.Text = "2007";
            btn_D.Text = "2009";

            label1.Text = "2007";

            btn_NextQuestion.Enabled = false;

            pictureBox_Correct.Visible = false;
            pictureBox_False.Visible = false;

            lbl_QuestionNumber.Text = "Question Number: " + questionNumber.ToString();
        }

        private void btn_NextQuestion_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;

            btn_NextQuestion.Enabled = false;

            pictureBox_Correct.Visible = false;
            pictureBox_False.Visible = false;

            questionNumber++;

            lbl_QuestionNumber.Text = "Question Number: " + questionNumber.ToString();

            if (questionNumber == 2)
            {
                richTextBox1.Text = "What’s the shortcut for the “copy” function on most computers?";

                btn_A.Text = "Ctrl + W";
                btn_B.Text = "Ctrl + C";
                btn_C.Text = "Ctrl + X";
                btn_D.Text = "Ctrl + S";

                label1.Text = "Ctrl + C";
            }

            else if (questionNumber == 3)
            {
                richTextBox1.Text = "'OS' computer abbreviation usually means ?";

                btn_A.Text = "Order of Significance";
                btn_B.Text = "Open Software";
                btn_C.Text = "Operating System";
                btn_D.Text = "Optical Sensor";

                label1.Text = "Operating System";
            }

            else if (questionNumber == 4)
            {
                richTextBox1.Text = "Who developed Yahoo?";

                btn_A.Text = "Dennis Ritchie & Ken Thompson";
                btn_B.Text = "David Filo & Jerry Yang";
                btn_C.Text = "Vint Cerf & Robert Kahn";
                btn_D.Text = "Steve Case & Jeff Bezos";

                label1.Text = "David Filo & Jerry Yang";
            }

            else if (questionNumber == 5)
            {
                richTextBox1.Text = "'DB' computer abbreviation usually means ?";

                btn_A.Text = "Database";
                btn_B.Text = "Double Byte";
                btn_C.Text = "Data Block";
                btn_D.Text = "Driver Boot";

                label1.Text = "Database";

                btn_NextQuestion.Text = "Results";
            }

            else
            {
                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;
                btn_D.Enabled = false;

                questionNumber = 5;

                btn_NextQuestion.Enabled = false;

                pictureBox_Correct.Visible = false;
                pictureBox_False.Visible = false;

                lbl_QuestionNumber.Text = "Question Number: " + questionNumber.ToString();

                MessageBox.Show("Correct Answers: " + correctAnswer.ToString() + "\n" + "Wrong Answers: " + wrongAnswer.ToString());
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;

            btn_NextQuestion.Enabled = true;

            label2.Text = btn_A.Text;

            if (label1.Text == label2.Text)
            {
                correctAnswer++;

                lbl_CorrectAnswer.Text = "Correct Answer: " + correctAnswer.ToString();

                pictureBox_Correct.Visible = true;

            }

            else
            {
                wrongAnswer++;

                lbl_WrongAnswer.Text = "Wrong Answer: " + wrongAnswer.ToString();

                pictureBox_False.Visible = true;
            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;

            btn_NextQuestion.Enabled = true;

            label2.Text = btn_B.Text;

            if (label1.Text == label2.Text)
            {
                correctAnswer++;

                lbl_CorrectAnswer.Text = "Correct Answer: " + correctAnswer.ToString();

                pictureBox_Correct.Visible = true;

            }

            else
            {
                wrongAnswer++;

                lbl_WrongAnswer.Text = "Wrong Answer: " + wrongAnswer.ToString();

                pictureBox_False.Visible = true;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;

            btn_NextQuestion.Enabled = true;

            label2.Text = btn_C.Text;

            if (label1.Text == label2.Text)
            {
                correctAnswer++;

                lbl_CorrectAnswer.Text = "Correct Answer: " + correctAnswer.ToString();

                pictureBox_Correct.Visible = true;

            }

            else
            {
                wrongAnswer++;

                lbl_WrongAnswer.Text = "Wrong Answer: " + wrongAnswer.ToString();

                pictureBox_False.Visible = true;
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;

            btn_NextQuestion.Enabled = true;

            label2.Text = btn_D.Text;

            if (label1.Text == label2.Text)
            {
                correctAnswer++;

                lbl_CorrectAnswer.Text = "Correct Answer: " + correctAnswer.ToString();

                pictureBox_Correct.Visible = true;

            }

            else
            {
                wrongAnswer++;

                lbl_WrongAnswer.Text = "Wrong Answer: " + wrongAnswer.ToString();

                pictureBox_False.Visible = true;
            }
        }
    }
}
