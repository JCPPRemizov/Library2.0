using System;
using System.Windows;
using Library2._0.Model;
using Microsoft.Win32;
using libSerializator;
using Microsoft.VisualBasic.CompilerServices;

namespace Library2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AgeBox.Text, out int age) && int.TryParse(IDBox.Text, out int id) &&
                !NameBox.Text.Equals(""))
            {

                Person person = new Person()
                {
                    Age = age,
                    Id = id,
                    Name = NameBox.Text
                };

                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    CreatePrompt = true,
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    AddExtension = true,
                    Title = "Сохранить объект",
                    FileName = "Object",
                    DefaultExt = ".json",
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    Serializator.SerializeToJsonFile(person, saveFileDialog.FileName);
                }
            }

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "JSON| *.json"

            };
            if (openFileDialog.ShowDialog() == true)
            {
                Person person = Serializator.DeserializeFromJsonFile<Person>(openFileDialog.FileName);
                if (person != null)
                {
                    AgeBox.Text = person.Age.ToString();
                    NameBox.Text = person.Name;
                    IDBox.Text = person.Id.ToString();
                }
            }
        }

        private void ChangeThemeButton_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = App.Theme == "RedTheme.xaml" ? "BlueTheme.xaml" : "RedTheme.xaml";
        }
    }
}
