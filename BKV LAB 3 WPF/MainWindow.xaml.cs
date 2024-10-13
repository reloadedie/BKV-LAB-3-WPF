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

        public int ResultValue { get; set; }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (firstNumInput.Text == null && secondNumInput.Text == null)
            {
                MessageBox.Show("Введите числа!");
            }

            string _fnuminput = firstNumInput.Text;
            int fnuminput = Convert.ToInt32(_fnuminput);

            string _snuminput = secondNumInput.Text;
            int snuminput = Convert.ToInt32(_snuminput);

            ReturnDoubleValue(fnuminput, snuminput);

            int tag = selectedTagAction;

            CheckTypeOperation(selectedTagAction,fnuminput, snuminput);
        }


        /*
        

        private void CheckSystem(string index)
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
        */

        private void ReturnDoubleValue(int firstNum, int secondNum)
        {

            firstNumDouble.Content = Convert.ToString(firstNum, 2);
            secondNumDouble.Content = Convert.ToString(secondNum, 2);
        }

        private ComboBoxItem selectedTagAction;
        public ComboBoxItem SelectedTagAction
        {
            get => selectedTagAction;
            set
            {
                selectedTagAction = value;
                CalculateCycle(selectedTagAction.Tag as string);

            }
        }

        private void CalculateCycle(string index)
        {

        }


        private ComboBoxItem selectedTagSystem;
        public ComboBoxItem SelectedTagSystem
        {
            get => selectedTagSystem;
            set
            {
                selectedTagSystem = value;
                //CheckSystem(selectedTagSystem.Tag as string);

            }
        }
        private void CheckTypeOperation(string index, int firstNum, int secondNum)
        {
            if (selectedTagAction != null)
            {
                MessageBox.Show("Выберите действие!");
            }

            switch (index)
            {
                case "21":
                    PlusMethod(firstNum, secondNum);
                    break;

                case "22":
                    MinusMethod(firstNum, secondNum);
                    break;

                case "23":
                    MultiplicationMethod(firstNum, secondNum);
                    break;

                case "24":
                    DivisionMethod(firstNum, secondNum);
                    break;

            }
        }

        //расчёт по методам операции
        #region

        private void PlusMethod(int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum + secondNum, 10);
            resultDoubleSystem.Content = Convert.ToString(firstNum + secondNum, 2);
        }

        private void MinusMethod(int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum - secondNum, 10);
            resultDoubleSystem.Content = Convert.ToString(firstNum - secondNum, 2);
        }

        private void MultiplicationMethod(int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum * secondNum, 10);
            resultDoubleSystem.Content = Convert.ToString(firstNum * secondNum, 2);
        }

        private void DivisionMethod(int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum / secondNum, 10);
            resultDoubleSystem.Content = Convert.ToString(firstNum / secondNum, 2);
        }
        #endregion
    }
}