using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Grila : Form
    {
        String numeParticipant;
        String cnpParticipant;
        public Form parentForm;

        String questionFilePath = "questions.txt";
        List<Question> questions;

        int questionIndex = 0;
        int points = 0;

        public Grila(String NumeParticipant, String CNPParticipant)
        {
            numeParticipant = NumeParticipant;
            cnpParticipant = CNPParticipant;

            InitializeComponent();

            numeTB.Text = numeParticipant;
            loadQuestions();
            intrebariTB.Text = questions.Count.ToString();

            fillQuestion(questions[questionIndex]);

        }

        private void loadQuestions()
        {
            StreamReader f = new StreamReader(Application.StartupPath + "\\" + questionFilePath);
            questions = new List<Question>();

            while(!f.EndOfStream)
            {
                int number = int.Parse(f.ReadLine());
                String type = f.ReadLine();
                QuestionType qtype = type.Equals("multiple") ? QuestionType.MULTIPLE : QuestionType.SINGLE;
                String text = f.ReadLine() ;
                int answerCount = int.Parse(f.ReadLine());
                String[] answers = new string[answerCount];
                for (int i = 0; i < answerCount; i++)
                {
                    answers[i] = f.ReadLine();
                }
                string imagePath = f.ReadLine();
                Boolean[] correctAnswers = new Boolean[answerCount];
                string[] correctAnswersStrings = f.ReadLine().Split(",");
                f.ReadLine();
                for (int i = 0; i < answerCount; i++)
                {
                    correctAnswers[i] = correctAnswersStrings.Contains<String>((i + 1).ToString());
                }

                if (imagePath.Equals("0"))
                    questions.Add(new Question(number, qtype, text, answers, correctAnswers));
                else
                    questions.Add(new Question(number, qtype, text, answers, imagePath, correctAnswers));
            }


            // Randomize list
            Random rnd = new Random();
            int qCount = questions.Count;
            while(qCount > 1)
            {
                qCount--;
                int randomIndex = rnd.Next(qCount + 1);
                Question aux = questions[qCount];
                questions[qCount] = questions[randomIndex];
                questions[randomIndex] = aux;
            }
        }

        void clearScreen()
        {
            textLB.Text = "";
            answersFL.Controls.Clear();
            pictureIB.Image = null;
        }

        void fillQuestion(Question q)
        {
            textLB.Text = q.Text;
            Type answerType;
            if (q.Type == QuestionType.SINGLE)
                answerType = typeof(RadioButton);
            else
                answerType = typeof(CheckBox);
            
            foreach (String ansText in q.Answers)
            {
                Object ans = Activator.CreateInstance(answerType);
                ((Control)ans).Text = ansText;
                ((Control)ans).MinimumSize = new Size(512, 16);
                ((Control)ans).ForeColor = Color.White;
                answersFL.Controls.Add((Control)ans);
            }

            pictureIB.Image = q.Image;
        }

        private void Grila_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void nextBT_Click(object sender, EventArgs e)
        {
            List<Boolean> selectedAnswers = new List<Boolean>();

            Type answerType;
            if (questions[questionIndex].Type == QuestionType.SINGLE)
                answerType = typeof(RadioButton);
            else
                answerType = typeof(CheckBox);

            foreach(var ans in answersFL.Controls)
            {
                if(answerType == typeof(RadioButton))
                    selectedAnswers.Add(((RadioButton)ans).Checked);
                if(answerType == typeof(CheckBox))
                    selectedAnswers.Add(((CheckBox)ans).Checked);
            }

            if (questions[questionIndex].testAnswers(selectedAnswers) == 2)
            {
                points += 2;
                MessageBox.Show("Răspuns corect!\n", "Bravo", MessageBoxButtons.OK);
            }
            else if (questions[questionIndex].testAnswers(selectedAnswers) == 1)
            {
                points += 1;
                MessageBox.Show("Răspuns parțial corect!\n", "Dar și parțial greșit", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Răspuns greșit!\n", "Of :(", MessageBoxButtons.OK);
            }

            punctajTB.Text = points.ToString();

            clearScreen();


            if(questionIndex < questions.Count-1)
                fillQuestion(questions[++questionIndex]);
            else
            {
                MessageBox.Show("Punctaj final: " + points.ToString(), "Chestionarul s-a sfârșit!", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
