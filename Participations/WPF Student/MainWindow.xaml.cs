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

namespace WPF_Student
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string studid = txtStudentId.Text;

            int studidnum = Convert.ToInt32(studid);

            Student stud1 = new Student();
            stud1.StudentID = studidnum;
            stud1.FirstName = txtFirst.Text;
            stud1.LastName = txtLast.Text;
            stud1.FavoriteColor = txtFav.Text;
            lstStud.Items.Add(stud1.ToString());

        }

        static void DisplayResult(Student s)
        {
            Console.WriteLine(s.ToString());
        }
    }
}
