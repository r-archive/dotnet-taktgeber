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
using System.Diagnostics;

namespace Taktgeber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int zahl = 0;
        Takter takter;
        DateTime lastTime;
        public MainWindow()
        {
            takter = new Takter(this);
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DateTime thisTime = DateTime.Now;
            if (lastTime == null || thisTime - lastTime > new TimeSpan(0, 0, 1))
            {
                lastTime = thisTime;
                return;
            }
            TimeSpan zeitspanne = thisTime - lastTime;
            lastTime = thisTime;
            takter.TaktAendern(zeitspanne);
        }
    }
}
