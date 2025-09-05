using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Runtime.ExceptionServices;
namespace KalkulatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private int FirstNumber;
        private int LastNumber;
        private bool isClicked;
        public MainWindow()
        {
            InitializeComponent();
            tbFirst.Text = "0";
        }
        private void FirstSecond_Click(object sender, TextBlock arg)
        {
            if (arg.Text != "0")
            {
                arg.Text = arg.Text + (sender as Button).Name.ToString().Remove(0, 1);
            }
            else
            {
                arg.Text = (sender as Button).Name.ToString().Remove(0, 1);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            if (string.IsNullOrEmpty(tbAritm.Text.ToString()))
            {
                FirstSecond_Click(sender,tbFirst);
            }
            else
            {
                FirstSecond_Click(sender, tbSecond);
            }

        }

        private void Arithmatic_Click(object sender, RoutedEventArgs e)
        {
            tbAritm.Text = (sender as Button).Content.ToString();
            tbSecond.Text = "0";
        }

        private void Equal(object sender, RoutedEventArgs e)
        {
            int result = 0;

            switch(tbAritm.Text)
            {
                case "+": result = Convert.ToInt32(tbFirst.Text) + Convert.ToInt32(tbSecond.Text); break;
                case "-": result = Convert.ToInt32(tbFirst.Text) - Convert.ToInt32(tbSecond.Text); break;
                case "*": result = Convert.ToInt32(tbFirst.Text) * Convert.ToInt32(tbSecond.Text); break;
                case "/": result = Convert.ToInt32(tbSecond.Text) != 0 ? Convert.ToInt32(tbFirst.Text) + Convert.ToInt32(tbSecond.Text): result = 0; break;
            }
            tbFirst.Text = result.ToString();
            tbSecond.Text = string.Empty;
            tbAritm.Text = string.Empty;
        }
    }
}