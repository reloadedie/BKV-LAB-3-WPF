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
            if (firstNumInput.Text == string.Empty | secondNumInput.Text == string.Empty)
            {
                MessageBox.Show("Введите числа!");
            }

            else
            {
                string _fnuminput = Convert.ToString(firstNumInput.Text);
                string _snuminput = Convert.ToString(secondNumInput.Text);

                string? _tagSystem = Convert.ToString(selectedTagSystem.Text);
                string? _tagAction = Convert.ToString(selectedTagAction.Text);
                ChekSystemOperation(_tagAction, _tagSystem, _fnuminput, _snuminput);
            }
            
        }
        
        private void ReturnDoubleValue(int firstNum, int secondNum)
        {
            
            firstNumDouble.Content = Convert.ToString(firstNum, 2);
            secondNumDouble.Content = Convert.ToString(secondNum, 2);
        }

        private void ChekSystemOperation(string _tagAction, string _tagSystem, string _firstNum, string _secondNum)
        {
            int tagSystemInt, fnum, snum;
            try
            {
                switch (_tagSystem)
                {
                    case "Двоичная":
                        tagSystemInt = 2;
                        //вот это всё в 1 метод для меньшего количества строчек продумать?? нужно вообще? работает - не трожь

                        fnum = Convert.ToInt32(_firstNum, tagSystemInt);
                        snum = Convert.ToInt32(_secondNum, tagSystemInt);
                        ReturnDoubleValue(fnum, snum);
                        CheckTypeOperation(_tagAction, tagSystemInt, fnum, snum);
                        break;

                    case "Восьмиричная":
                        tagSystemInt = 8;
                        fnum = Convert.ToInt32(_firstNum, tagSystemInt);
                        snum = Convert.ToInt32(_secondNum, tagSystemInt);
                        ReturnDoubleValue(fnum, snum);
                        CheckTypeOperation(_tagAction, tagSystemInt, fnum, snum);
                        break;

                    case "Десятичная":
                        tagSystemInt = 10;
                        fnum = Convert.ToInt32(_firstNum, tagSystemInt);
                        snum = Convert.ToInt32(_secondNum, tagSystemInt);
                        ReturnDoubleValue(fnum, snum);
                        CheckTypeOperation(_tagAction, tagSystemInt, fnum, snum);
                        break;

                    case "Шестнадцатиричная":
                        tagSystemInt = 16;
                        fnum = Convert.ToInt32(_firstNum, tagSystemInt);
                        snum = Convert.ToInt32(_secondNum, tagSystemInt);
                        ReturnDoubleValue(fnum, snum);
                        CheckTypeOperation(_tagAction, tagSystemInt, fnum, snum);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            
                MessageBox.Show("Попробуйте ввести число корректно");
                //MessageBoxButton.YesNo

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

        #region
        private void PlusMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum + secondNum, tagSystemInt).ToUpper();
            resultDoubleSystem.Content = Convert.ToString(firstNum + secondNum, 2);
        }

        private void MinusMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum - secondNum, tagSystemInt).ToUpper();
            resultDoubleSystem.Content = Convert.ToString(firstNum - secondNum, 2);
        }

        private void MultiplicationMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum * secondNum, tagSystemInt).ToUpper();
            resultDoubleSystem.Content = Convert.ToString(firstNum * secondNum, 2);
        }

        private void DivisionMethod(int tagSystemInt, int firstNum, int secondNum)
        {
            ResultValueLabel.Content = Convert.ToString(firstNum / secondNum, tagSystemInt).ToUpper();
            resultDoubleSystem.Content = Convert.ToString(firstNum / secondNum, 2).ToUpper();

            if (firstNum % secondNum == 0) 
            {
                ostatokDel.Content = "0";
            }
            else ostatokDel.Content = Convert.ToString(firstNum % secondNum, tagSystemInt).ToUpper();
            

        }

        #endregion
    }
}