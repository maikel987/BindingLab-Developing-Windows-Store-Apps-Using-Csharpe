using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BindingLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Persons { get; set; }
        public VisibilityConverter converter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            converter = new VisibilityConverter();
            Persons = new ObservableCollection<Person>();
            AddRandomPerson();
            DataContext = this;


        }

        private void AddRandomPerson()
        {
            Persons.Add(new Person(new Random().Next(10, 80), "RandomPerson"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddRandomPerson();
        }
    }
}
