using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
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

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private MetroWindow testWindow;

        private MetroWindow GetTestWindow()
        {
            if (testWindow != null)
            {
                testWindow.Close();
            }

            testWindow = new MetroWindow() { Owner = this, WindowStartupLocation = WindowStartupLocation.CenterOwner, Title = "Another Test...", Width = 500, Height = 300 ,};
            testWindow.Closed += (o, args) => testWindow = null;
            return testWindow;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var w = this.GetTestWindow();
            w.Content = new Button()
            {
                Content = "MetroWindow with Glow",
                Name = "Ko",
                ToolTip = "And test tool tip",
                FontSize = 28,
                FontWeight = FontWeights.Light,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = Brushes.Red,
                Foreground= Brushes.Red,
            };
            Button tn = new Button()
            {
                Content = "MetroWindow with Glow",
                Name = "K1",
                ToolTip = "And test tool tip",
                FontSize = 28,
                FontWeight = FontWeights.Light,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = Brushes.Red
            }; 
            tn.Click += MainWindow_Click;
            w.Content = tn;
                w.Content = new Ellipse() { HorizontalAlignment = HorizontalAlignment.Left, Height = 72, Width = 72, Fill = new SolidColorBrush(Colors.Red) };
      
            w.BorderThickness = new Thickness(1);
            w.BorderBrush = null;
            w.SetResourceReference(MetroWindow.GlowBrushProperty, "MahApps.Brushes.Accent");
            w.Show();
        }

        private object MainWindow_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("123");
            return null;
        }

        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show("123");   
        }

        public delegate void click1();
        public event click1 btnClick;
        private void Click1()
        {
           
        }
        private Window windowget;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (windowget == null)
            {
                windowget = new WindowDemo();
               
            }
            windowget.Show();
        }
    }
}
