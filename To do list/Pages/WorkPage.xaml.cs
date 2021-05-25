using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Xml.Linq;

namespace To_do_list.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy WorkPage.xaml
    /// </summary>
    public partial class WorkPage : Page
    {
        string _xmlFile = "XML\\XMLFile1.xml";

        public WorkPage()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            XDocument doc = XDocument.Load(_xmlFile);
            doc.Root.Add(new XElement("Save",
                new XElement("Text", TextBox.Text),
                new XElement("State", "true")));
            doc.Save(_xmlFile);

            var  result = doc.Descendants("Save").Select(x => new
            {
                Text = x.Element("Text").Value,
                State = x.Element("State").Value
            });

            DataGridView.ItemsSource = result;
        }
    }
}
