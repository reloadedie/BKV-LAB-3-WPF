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

            string? _tagSystem = Convert.ToString(selectedTagSystem.Text);
            string? _tagAction = Convert.ToString(selectedTagAction.Text);
            ChekSystemOperation(_tagAction, _tagSystem, fnuminput, snuminput);
        }
        
        private void ReturnDoubleValue(int firstNum, int secondNum)
        {
            firstNumDouble.Content = Convert.ToString(firstNum, 2);
            secondNumDouble.Content = Convert.ToString(secondNum, 2);
        }

        private void ChekSystemOperation(string _tagAction, string _tagSystem, int firstNum, int secondNum)
        {
            int tagSystemInt;
            switch (_tagSystem)
            {
                case "Двоичная":
                    tagSystemInt = 2;
                    CheckTypeOperation(_tagAction, tagSystemInt, firstNum, secondNum);
                    break;

                case "Восьмиричная":
                    tagSystemInt = 8;
                    CheckTypeOperation(_tagAction, tagSystemInt, firstNum, secondNum);
                    break;

                case "Десятичная":
                    tagSystemInt = 10;
                    CheckTypeOperation(_tagAction, tagSystemInt, firstNum, secondNum);
                    break;

                case "Шестнадцатиричная":
                    tagSystemInt = 16;
                    CheckTypeOperation(_tagAction, tagSystemInt, firstNum, secondNum);
                    break;

            }
        }

        private void CheckTypeOperation(string _tagAction, int tagSystemInt, int firstNum, int secondNum)
        {
            switch (_tagAction)
            {
                case "Сложение":
                    PlusMethod(tagSystemInt, firstNum, secondNum);
                    break;

                case "Вычитание":
                    MinusMethod(tagSystemInt, firstNum, secondNum);
                    break;

                case "Умножение":
                    MultiplicationMethod(tagSystemInt, firstNum, secondNum);
                    break;

                case "Деление":
                    DivisionMethod(tagSystemInt, firstNum, secondNum);
                    break;

            }
        }

        //расчёт по методам операции
        #region
        // + конвертировать из string в int значение системы счисления
        private void PlusMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum + secondNum, tagSystemInt);
            resultDoubleSystem.Content = Convert.ToString(firstNum + secondNum, 2);
        }

        private void MinusMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum - secondNum, tagSystemInt);
            resultDoubleSystem.Content = Convert.ToString(firstNum - secondNum, 2);
        }

        private void MultiplicationMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum * secondNum, tagSystemInt);
            resultDoubleSystem.Content = Convert.ToString(firstNum * secondNum, 2);
        }

        private void DivisionMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum / secondNum, tagSystemInt);
            resultDoubleSystem.Content = Convert.ToString(firstNum / secondNum, 2);
        }
        #endregion
    }
}