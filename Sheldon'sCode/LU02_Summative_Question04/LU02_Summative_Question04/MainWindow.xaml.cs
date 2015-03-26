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

namespace LU02_Summative_Question04
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

        Person student = new Person();
       
        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            student.ViewInfo(txtName.Text, txtSurname.Text, txtCourse.Text, int.Parse(txtClassNr.Text));
            txtDisplayInfo.Text = "";
            txtDisplayInfo.Text += student.Display;
        }
    }
}
