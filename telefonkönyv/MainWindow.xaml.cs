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
            try
            {
                contacts = JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText("contacts.json"));
                foreach (var item in contacts)
                {
                    adatok.Items.Add(item);
                }
            }
            catch (FileNotFoundException)
            {
            }
        }

        static void Save()
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText("contacts.json", json);
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

                TextBoxName.Text = "";
                TextBoxNumber.Text = "";

                contacts.Add(c);
                Save();
                adatok.Items.Add(c);
            }
            else
            {
                MessageBox.Show("A név vagy telefonszám hiányzik!", "HIBA", MessageBoxButton.OK);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)adatok.SelectedItem;
            Contact modified = new Contact
            {
                Name = TextBoxName.Text,
                Number = TextBoxNumber.Text
            };

            try
            {
                contacts[contacts.IndexOf(selected)] = modified;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nincs kiválasztott elem!", "HIBA", MessageBoxButton.OK);
            }

            adatok.SelectedItem = null;
            TextBoxName.Text = "";
            TextBoxNumber.Text = "";

            Save();

            adatok.Items.Clear();
            foreach (var item in contacts)
            {
                adatok.Items.Add(item);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text == "" || TextBoxNumber.Text == "")
            {
                MessageBox.Show("Nincs kiválasztott elem!", "HIBA", MessageBoxButton.OK);
            }

            Contact selected = (Contact)adatok.SelectedItem;
            contacts.Remove(selected);

            adatok.SelectedItem = null;
            TextBoxName.Text = "";
            TextBoxNumber.Text = "";

            Save();

            adatok.Items.Clear();
            foreach (var item in contacts)
            {
                adatok.Items.Add(item);
            }
        }

        private void Adatok_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Contact selected = (Contact)adatok.SelectedItem;
            try
            {
                TextBoxName.Text = selected.Name;
                TextBoxNumber.Text = selected.Number;
            }
            catch (NullReferenceException)
            {
            }
        }
    }
}
