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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tabla feladvany;
        //List<ClassTabla> feladvanybeolvasva = new List<ClassTabla>();
        public MainWindow()
        {
            InitializeComponent();
          
    }

        private void feladvanybeolvasasbtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == false)
            {
                MessageBox.Show("hibaüzenet");
            }
            else
            {
                


                var fajlsorai = File.ReadAllLines(openFileDialog.FileName);

                byte[,] beMatrix = new byte[fajlsorai.Length,fajlsorai[0].Split().Count()];
                int x = 0;
                foreach (var sor in fajlsorai)
                {
                    int y = 0;
                    foreach(var mezo in sor.Split()) 
                    {
                        beMatrix[x,y++] = byte.Parse(mezo);
                    }
                    x++;
                }
                feladvany = new Tabla(beMatrix);
            }
            Teruletkirajzolasa(feladvany);
        }

        private void Teruletkirajzolasa(Tabla feladvany) 
        {
        
        
        }
    }
}
