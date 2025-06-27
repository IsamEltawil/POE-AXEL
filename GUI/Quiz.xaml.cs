using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace QuizApp
{
    public partial class Quiz : Window
    {
        

        private int currentQuestionIndex = 0;
        private int score = 0;
        private static int highScore = 0;
        private List<Question> questions = new List<Question>
{
    new Question
    {
        Text = "What does HTTPS stand for?",
        Options = new[] { "HyperText Transfer Protocol Secure", "High Transfer Text Protocol Secure", "HyperType Transfer Protocol Secure", "Host Text Transfer Protocol Security" },
        CorrectAnswerIndex = 0,
        IsTrueFalse = false
    },
    new Question
    {
        Text = "True or False: Using the same password for multiple accounts is safe.",
        Options = new[] { "True", "False" },
        CorrectAnswerIndex = 1,
        IsTrueFalse = true
    },
    new Question
    {
        Text = "Which of these is a good tip to avoid phishing?",
        Options = new[] { "Share your password with trusted friends", "Ignore website URLs", "Check for spelling mistakes and suspicious links", "Always click on attachments" },
        CorrectAnswerIndex = 2,
        IsTrueFalse = false
    },
    new Question
    {
        Text = "True or False: HTTPS is safer than HTTP.",
        Options = new[] { "True", "False" },
        CorrectAnswerIndex = 0,
        IsTrueFalse = true
    },
    new Question
    {
        Text = "What is a strong password example?",
        Options = new[] { "123456", "password", "MyDogIs4wesome!", "qwerty" },
        CorrectAnswerIndex = 2,
        IsTrueFalse = false
    },
    new Question
    {
        Text = "Which of the following is considered multi-factor authentication?",
        Options = new[] { "Password + PIN", "Fingerprint + password", "Username + password", "PIN + pattern" },
        CorrectAnswerIndex = 1,
        IsTrueFalse = false
    },
    new Question
    {
        Text = "True or False: Public Wi-Fi is always safe for banking.",
        Options = new[] { "True", "False" },
        CorrectAnswerIndex = 1,
        IsTrueFalse = true
    },
    new Question
    {
        Text = "What should you do if you receive a suspicious email link?",
        Options = new[] { "Click it quickly", "Ignore it", "Verify the sender first", "Forward it to everyone" },
        CorrectAnswerIndex = 2,
        IsTrueFalse = false
    },
    new Question
    {
        Text = "Which of these is a sign of a phishing website?",
        Options = new[] { "No padlock icon in the address bar", "Grammatical errors", "Strange URLs", "All of the above" },
        CorrectAnswerIndex = 3,
        IsTrueFalse = false
    },
    new Question
    {
        Text = "True or False: Antivirus software should be updated regularly.",
        Options = new[] { "True", "False" },
        CorrectAnswerIndex = 0,
        IsTrueFalse = true
    }
};

        public Quiz()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                ShowScore();
                return;
            }

            var question = questions[currentQuestionIndex];
            QuestionText.Text = question.Text;
            OptionsPanel.Children.Clear();

            for (int i = 0; i < question.Options.Length; i++)
            {
                var radio = new RadioButton
                {
                    Content = question.Options[i],
                    GroupName = "Options",
                    Tag = i
                };
                OptionsPanel.Children.Add(radio);
            }
        }

        private void SubmitAnswer_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = -1;
            foreach (RadioButton option in OptionsPanel.Children)
            {
                if (option.IsChecked == true)
                {
                    selectedIndex = (int)option.Tag;
                    break;
                }
            }

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            if (selectedIndex == questions[currentQuestionIndex].CorrectAnswerIndex)
            {
                score++;
            }

            currentQuestionIndex++;
            LoadQuestion();
        }

        private void ShowScore()
        {
            ScoreText.Text = $"Your score: {score}/{questions.Count}";
            if (score > highScore)
            {
                highScore = score;
            }
            HighScoreText.Text = $"High score: {highScore}/{questions.Count}";

            MessageBox.Show("Quiz complete!");
            score = 0;
            currentQuestionIndex = 0;
            LoadQuestion();
        }

        public class Question
        {
            public string Text { get; set; }
            public string[] Options { get; set; }
            public int CorrectAnswerIndex { get; set; }
            public bool IsTrueFalse { get; set; }
        }
    }
}