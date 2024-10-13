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
            if (firstNumInput.Text == null && secondNumInput.Text == null)
            {
                MessageBox.Show("Введите числа!");
            }

            if (selectedTagAction != null)
            {
                MessageBox.Show("Выберите действие!");
            }

            int fnuminput = Convert.ToInt32(firstNumInput.Text);
            int snuminput = Convert.ToInt32(secondNumInput.Text);

            ReturnDoubleValue(fnuminput, snuminput);

            string? _tagAction = Convert.ToString(selectedTagAction.Text);
            CalculateCycle(_tagAction, fnuminput, snuminput);
        }
        
        private void ReturnDoubleValue(int firstNum, int secondNum)
        {
            firstNumDouble.Content = Convert.ToString(firstNum, 2);
            secondNumDouble.Content = Convert.ToString(secondNum, 2);
        }

        /*
        private ComboBoxItem selectedTagAction;
        public ComboBoxItem SelectedTagAction
        {
            get => selectedTagAction;
            set
            {
                selectedTagAction = value;
                //CalculateCycle(selectedTagAction.Tag as string);

            }
        }
        */

        private void CalculateCycle(string tagAction, int firstNum, int secondNum)
        {
            CheckTypeOperation(tagAction, firstNum, secondNum);
            //ChekSystemOperation();
        }

        //"System.Windows.Controls.ComboBoxItem: Сложение"
        private void CheckTypeOperation(string _tagAction, int firstNum, int secondNum)
        {
            switch (_tagAction)
            {
                case "Сложение":
                    PlusMethod(firstNum, secondNum);
                    break;

                case "Вычитание":
                    MinusMethod(firstNum, secondNum);
                    break;

                case "Умножение":
                    MultiplicationMethod(firstNum, secondNum);
                    break;

                case "Деление":
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