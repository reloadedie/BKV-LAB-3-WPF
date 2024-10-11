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

namespace BKV_LAB_3_WPF
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

        private void Calculate(object sender, RoutedEventArgs e)
        {

            //int fnuminput = Convert.ToInt32(firstNumDouble);
            string _fnuminput = firstNumInput.Text;
            int fnuminput = Convert.ToInt32(_fnuminput);
            firstNumDouble.Content = Convert.ToString(fnuminput, 2);

            string _snuminput = secondNumInput.Text;
            int snuminput = Convert.ToInt32(_snuminput);
            secondNumDouble.Content = Convert.ToString(snuminput, 2);

            // int snuminput = Convert.ToInt32(secondNumDouble);

            int result = fnuminput + snuminput;
            resultDoubleSystem.Content = Convert.ToString(result, 2); 

        }

        #region
        private void CalculateResult10()
        {

        }

        private void CalculateResult2()
        {

        }

        private void CalculateResult8()
        {

        }

        private void CalculateResult16()
        {

        }
        #endregion

    }
}