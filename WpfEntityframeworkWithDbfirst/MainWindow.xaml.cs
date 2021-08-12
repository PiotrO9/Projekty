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

namespace WpfEntityframeworkWithDbfirst
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContextDb db = new ContextDb();
        sampleTable tbl = new sampleTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clickbtn_Click(object sender, RoutedEventArgs e)
        {
            tbl.Name = TextBox.Text;
            db.sampleTables.Add(tbl);
            db.SaveChanges();
            TextBox.Text = "";
            MessageBox.Show("Udało się !");
        }

        private void Findbtn_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txtbox.Text);
            string name = db.sampleTables.Find(id).Name;
            TextBox.Text = name.ToString();
        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtbox.Text);
            tbl = (from x in db.sampleTables
                   where x.id == id
                   select x).First();
            tbl.Name = TextBox.Text;
            db.SaveChanges();
            txtbox.Clear();
            TextBox.Clear();
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtbox.Text);
            tbl = (from x in db.sampleTables
                   where x.id == id
                   select x).First();
            db.sampleTables.Remove(tbl);
            db.SaveChanges();
            txtbox.Clear();
            TextBox.Clear();
            MessageBox.Show("Pomyślnie usunięto!");
        }
    }
}
