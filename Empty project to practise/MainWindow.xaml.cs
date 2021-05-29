using System;
using System.Collections.Generic;
using System.Data;
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

namespace Empty_project_to_practise
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        int n = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (n < 1)
            {
                List<item> eObj = new List<item>();
                for (int i = 0; i < 3; i++)
                {
                    item item = new item();
                    item.Text = "Test message";
                    item.Statement = true;

                    eObj.Add(item);
                }

                DG.ItemsSource = eObj;

            }
            else;
            {

            }

            
        }

        class item
        {
            public string Text { get; set; }

            public bool Statement { get; set; }
        }

        private void Method()
        {
            DataTable dtEmp = new DataTable();

            dtEmp.Columns.Add("Text", typeof(string));
            dtEmp.Columns.Add("Statement", typeof(bool));
        }

    }
}
