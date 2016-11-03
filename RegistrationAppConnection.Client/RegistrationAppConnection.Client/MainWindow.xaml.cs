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
//using RegistrationAppConnection.Domain;
//using RegistrationAppConnection.Data;
using RegistrationAppConnection.Domain;

namespace RegistrationAppConnection.Client
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Add_btn_Click(object sender, RoutedEventArgs e)
    {
      if (!IsNull(FirstName_txt.Text, LastName_txt.Text, Address_txt.Text))
      {
        var person = new StudentDTO(FirstName_txt.Text, LastName_txt.Text);
        var address = ParseAddress(Address_txt.Text);

        DomainHelper.AddStudent(person);
        DomainHelper.AddAddress(address);

       
        FirstName_txt.Clear();
        LastName_txt.Clear();
        Address_txt.Clear();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private bool IsNull(params string[] s)
    {
      foreach (var item in s.ToList())
      {
        if (string.IsNullOrWhiteSpace(item))
        {
          return true;
        }
      }

      return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private ScheduleClassDTO ParseAddress(string s)
    {
      var a = s.Split(',');
      var address = new ScheduleClassDTO();

      if (a.Length > 0)
      {
        address.Street = a[0] != null ? a[0] : string.Empty;
        address.City = a[1] != null ? a[1] : string.Empty;
        address.State = a[2] != null ? a[2] : string.Empty;
        address.Zipcode = a[3] != null ? a[3] : string.Empty;
      }

      return address;
    }
  }
}
