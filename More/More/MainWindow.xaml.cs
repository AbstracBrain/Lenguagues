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
using System.Resources; //Agregar libreria para poder trabajar con los recursos

namespace More
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string strLenguague = "";
        Boolean boolInt = true;
        public MainWindow()
        {
            InitializeComponent();
            boolInt = false;
        }
        private void Window_Loaded(object sender, RoutedEvent e)
        {
            Set_Lenguague();
        }

        private void dlLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Set_Lenguague();
        }
        private void Set_Lenguague()
        {
            strLenguague = "More.Idiomas." + ((ComboBoxItem)dllLanguague.SelectedItem).Name.ToString();
            ResourceManager LocRM = new ResourceManager(strLenguague, typeof(MainWindow).Assembly);
            lblAge.Text = LocRM.GetString("strAge");
        }
    }
}
