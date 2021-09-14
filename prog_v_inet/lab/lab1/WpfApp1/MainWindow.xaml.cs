using System;
using System.Net;
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

namespace WpfApp1
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
            int x = int.Parse(X.Text);
            int y = int.Parse(Y.Text);
            WebRequest request = WebRequest.Create("https://localhost:44342/sum?X=" +x+ "&Y=" + y);
            WebResponse response = request.GetResponse();
            var result = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Result.Text = result.ToString();
        }
    }
}
