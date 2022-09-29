using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notepad_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string FileName { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void newMenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void openMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialogue = new OpenFileDialog();
            openFileDialogue.DefaultExt = ".txt";
            openFileDialogue.Filter = "Text Document (.txt)|*.txt";

            if(openFileDialogue.ShowDialog() == true)
            {
                string fileName = openFileDialogue.FileName;
                FileName = fileName;
                mainWindow.Title = $"{FileName} - NotePad";
                textBox.Text = File.ReadAllText(fileName);
            }
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveAsMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
