using System;
using System.Reflection;
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
            string _fnuminput = firstNumInput.Text;
            int fnuminput = Convert.ToInt32(_fnuminput);
            firstNumDouble.Content = Convert.ToString(fnuminput, 2);

            string _snuminput = secondNumInput.Text;
            int snuminput = Convert.ToInt32(_snuminput);
            secondNumDouble.Content = Convert.ToString(snuminput, 2);

            int result = fnuminput + snuminput;
            resultDoubleSystem.Content = Convert.ToString(result, 2); 

        }

        private ComboBoxItem selectedTag;
        public ComboBoxItem SelectedTag
        {
            get => selectedTag;
            set
            {
                selectedTag = value;
                CalculateCycle(selectedTag.Tag as string);

            }
        }

        private void CalculateCycle(string index)
        {
            switch (index)
            {
                case "2":
                    CalculateResult2();
                    break;

                case "8":
                    CalculateResult8();
                    break;

                case "10":
                    CalculateResult10();
                    break;

                case "16":
                    CalculateResult16();
                    break;

            }
        }

        #region
        private void CalculateResult2()
        {

        }

        private void CalculateResult8()
        {

        }

        private void CalculateResult10()
        {

        }
        private void CalculateResult16()
        {

        }
        #endregion

    }
}