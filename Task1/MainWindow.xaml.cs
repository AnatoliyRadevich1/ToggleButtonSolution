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

namespace Task1
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
        
        private void ButtonFriends_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButtonFriends.IsChecked == true)
            {
                toggleButtonFriends.Content = "On";
                toggleButtonFriends.Background = Brushes.Yellow; //почему цвет тут не меняется?

                #region Преобразование кнопки toggleButtonMoney
                if (toggleButtonLove.IsChecked == true && toggleButtonMoney.IsChecked == true)
                {
                    toggleButtonMoney.IsChecked = false;
                    toggleButtonMoney.Background = Brushes.OrangeRed; //если я это не пропишу, то цвет кнопки станет жёлтым
                    toggleButtonMoney.Content = "Off";
                }
                #endregion
            }
            else
            {
                toggleButtonFriends.Content = "Off";
                toggleButtonFriends.Background = Brushes.OrangeRed;
            }
        }
        private void ButtonLove_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButtonLove.IsChecked == true)
            {
                toggleButtonLove.Content = "On";
                toggleButtonLove.Background = Brushes.Yellow; //почему цвет тут не меняется?

                #region Преобразование кнопки toggleButtonFriends
                if (toggleButtonFriends.IsChecked == true && toggleButtonMoney.IsChecked == true)
                {
                    toggleButtonFriends.IsChecked = false;
                    toggleButtonFriends.Background = Brushes.OrangeRed; //если я это не пропишу, то цвет кнопки станет жёлтым
                    toggleButtonFriends.Content = "Off";
                }
                #endregion
            }
            else
            {
                toggleButtonLove.Content = "Off";
                toggleButtonLove.Background = Brushes.OrangeRed;
            }
        }
        private void ButtonMoney_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButtonMoney.IsChecked == true)
            {
                toggleButtonMoney.Content = "On";
                toggleButtonMoney.Background = Brushes.Yellow; //почему цвет тут не меняется?

                //Тут пошла механика работы с кнопками
                #region Преобразование кнопки toggleButtonLove
                if (toggleButtonFriends.IsChecked == true && toggleButtonLove.IsChecked == true)
                {
                    toggleButtonLove.IsChecked = false;
                    toggleButtonLove.Background = Brushes.OrangeRed; //если я это не пропишу, то цвет кнопки станет жёлтым
                    toggleButtonLove.Content = "Off";
                }
                #endregion
            }
            else
            {
                toggleButtonMoney.Content = "Off";
                toggleButtonMoney.Background = Brushes.OrangeRed;
            }
        }
    }
}
