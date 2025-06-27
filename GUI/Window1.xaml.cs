using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI
{

    public partial class Window1 : Window
    {

        string input;

        

        static string GetSafeArrayValue(string[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                MessageBox.Show("Invalid choice. Please pick a valid number next time.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;
            }
            return array[index];
        }

        public Window1()
        {
            InitializeComponent();
        }

        private void User_Enter(object sender, RoutedEventArgs e)
        {
            ProcessUserMessage();

        }

        public void ProcessUserMessage()
        {
            input = TypingBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Input cannot be empty. Please try again.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            UInput.Content += " User: " + input + "\n";
            TypingBox.Clear();

        }

        private void Quiz_btn(object sender, RoutedEventArgs e)
        {
            QuizApp.Quiz quizWindow = new QuizApp.Quiz(); // Create instance of Quiz.xaml
            quizWindow.Show();            // Show the Quiz window
            this.Close();

        }

        
        private void LogOut_btn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Tasks_btn(object sender, RoutedEventArgs e)
        {
            Tasks tk = new Tasks();
            tk.Show();
            this.Close();
        }
    }
}