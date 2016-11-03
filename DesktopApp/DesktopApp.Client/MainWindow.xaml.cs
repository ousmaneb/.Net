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

namespace DesktopApp.Client
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



    private void add_button_Click(object sender, RoutedEventArgs e)
    {
    private bool isValid (Person person)
      {
        if (string.IsNullOrWhiteSpace(person.FirstName))
        {
          return false;
        }

        if (string.IsNullOrWhiteSpace(person.LastName))
        {
          return false;
        }

        if (string.IsNullOrWhiteSpace(person.PhoneNumber))
        {
          return false;
        }
        return true;
      }

    }
  }
}

