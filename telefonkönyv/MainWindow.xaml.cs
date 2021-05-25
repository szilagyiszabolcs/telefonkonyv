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
using Newtonsoft.Json;
using System.IO;

namespace telefonkönyv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Contact> contacts = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();
            contacts = JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText("contacts.json"));
            ShowContacts();
        }

        static void Save()
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText("contacts.json", json);
        }

        static void ShowContacts()
        {
            foreach (var item in contacts)
            {
                //listbox.Items.Add($"{item.Name} - {item.Number}");    MÉG NEM MŰKÖDIK
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text != "" && TextBoxNumber.Text != "")
            {
                Contact c = new Contact
                {
                    Name = TextBoxName.Text,
                    Number = TextBoxNumber.Text
                };
                contacts.Add(c);
                Save();
                ShowContacts();
            }
            else
            {
                MessageBox.Show("A név vagy telefonszám hiányzik!", "HIBA", MessageBoxButton.OK);
            }
        }
    }
}
