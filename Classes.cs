using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public enum QuestionType
    {
        SINGLE,
        MULTIPLE
    }

    public class Question
    {
        public int Number { get; private set; }
        public QuestionType Type { get; private set; }
        public String Text { get; private set; }
        public String[] Answers { get; private set; }
        public Image Image { get; private set;}
        public Boolean[] CorrectAnswers { get; private set; }

        public Question(int _Number, QuestionType _Type, String _Text, String[] _Answers, Boolean[] _CorrectAnswers)
        {
            Number = _Number;
            Type = _Type;
            Text = _Text;
            Answers = _Answers;
            Image = null;
            CorrectAnswers = _CorrectAnswers;
        }

        public Question(int _Number, QuestionType _Type, String _Text, String[] _Answers, String ImagePath, Boolean[] _CorrectAnswers)
        {
            Number = _Number;
            Type = _Type;
            Text = _Text;
            Answers = _Answers;

            try
            {
                Image = Bitmap.FromFile(Application.StartupPath + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Image = null;
            }

            CorrectAnswers = _CorrectAnswers;
        }

        public int testAnswers(List<Boolean> givenAnswers)
        {
            // 0 - wrong
            // 1 - partial
            // 2 - correct

            int correctCount = 0;
            int correctGiven = 0;

            for (int i = 0; i < givenAnswers.Count; i++)
            {
                correctGiven += givenAnswers[i] && CorrectAnswers[i] ? 1 : 0;
                correctCount += CorrectAnswers[i] ? 1 : 0;
            }

            if (correctGiven == correctCount) return 2;
            if (correctGiven == 0) return 0;
            return 1;
        }
    }
}
