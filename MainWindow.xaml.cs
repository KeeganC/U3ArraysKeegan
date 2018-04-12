using System;
using System.Collections.Generic;
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
using System.IO;

namespace U3ArraysKeegan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int[] scores = new int[100];
            int counter = 0;
            int total = 0;
            string temp = "";

            try
            {
                StreamReader streamReader = new StreamReader("TextFile1.txt");

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    int.TryParse(line, out scores[counter]);
                    counter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            for (int i = 0; i < counter; i++)
            {
                temp += scores[i].ToString() + "\n";
                total += scores[i];
            }

            /*
            scores[0] = 10;
            scores[1] = 8;
            scores[2] = 3;
            */

            MessageBox.Show(temp);
        }
    }
}
