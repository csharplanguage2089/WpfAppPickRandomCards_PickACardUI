using System.Windows;

namespace WpfAppPickRandomCards_PickACardUI
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] pickerCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            listOfCards.Items.Clear();
            foreach (string myLocalCard in pickerCards)
            {
                listOfCards.Items.Add(myLocalCard);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            listOfCards.Items.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
