using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class Tasks : Window
    {
        private List<TaskItem> taskItems = new List<TaskItem>();

        public Tasks()
        {
            InitializeComponent();
            StatusSelector.SelectedIndex = 0;
        }

        private void SubmitTask_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskInput.Text.Trim();
            string status = ((ComboBoxItem)StatusSelector.SelectedItem).Content.ToString();

            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Please enter a task before submitting.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            TaskItem newTask = new TaskItem
            {
                Description = task,
                Status = status
            };

            taskItems.Add(newTask);
            TaskList.Items.Add(newTask);
            TaskInput.Clear();
            StatusSelector.SelectedIndex = 0;
        }

        private void UpdateTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to update.");
                return;
            }

            TaskItem selectedTask = taskItems[TaskList.SelectedIndex];
            selectedTask.Description = TaskInput.Text.Trim();
            selectedTask.Status = ((ComboBoxItem)StatusSelector.SelectedItem).Content.ToString();
            TaskList.Items[TaskList.SelectedIndex] = selectedTask;

            TaskInput.Clear();
            StatusSelector.SelectedIndex = 0;
        }

        private async void SetReminder_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedIndex == -1)
            {
                MessageBox.Show("Select a task to set a reminder.");
                return;
            }

            string input = Interaction.InputBox("Enter reminder time in HH:mm format (24-hour):", "Set Reminder", DateTime.Now.AddMinutes(1).ToString("HH:mm"));

            if (TimeSpan.TryParse(input, out TimeSpan time))
            {
                DateTime reminderTime = DateTime.Today.Add(time);
                if (reminderTime < DateTime.Now)
                {
                    reminderTime = reminderTime.AddDays(1);
                }

                TaskItem selectedTask = taskItems[TaskList.SelectedIndex];
                selectedTask.ReminderTime = reminderTime;
                TaskList.Items[TaskList.SelectedIndex] = selectedTask;

                await CheckReminderAsync(selectedTask);
            }
            else
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
            }
        }

        private async Task CheckReminderAsync(TaskItem task)
        {
            while (DateTime.Now < task.ReminderTime)
            {
                await Task.Delay(1000);
            }

            MessageBox.Show($"Reminder: {task.Description}", "Task Reminder", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Quiz_btn(object sender, RoutedEventArgs e)
        {
            QuizApp.Quiz quizWindow = new QuizApp.Quiz();
            quizWindow.Show();
            this.Close();
        }

        private void LogOut_btn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class TaskItem
    {
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? ReminderTime { get; set; }

        public override string ToString()
        {
            return $"{Description} - [{Status}]{(ReminderTime.HasValue ? $" ⏰ {ReminderTime.Value:HH:mm}" : "")}";
        }
    }
}