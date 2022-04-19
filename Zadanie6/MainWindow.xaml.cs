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

namespace Zadanie6
{
	public partial class MainWindow : Window
	{
		private ObservableCollection<Osoba> osobaList { get; set; } = new ObservableCollection<Osoba>()
		{
			new Osoba { Imie="Gienek", Nazwisko="Zbyszkow", Email="gienek.755@gmail.com" },
			new Osoba { Imie="Stasiek", Nazwisko="Filominów", Email="stachu@wp.pl" },
			new Osoba { Imie="Marek", Nazwisko="Fornal", Email="maro@wp.pl" },
			new Osoba { Imie="Endriu", Nazwisko="Malinoski", Email="Endriu69@wp.pl" },
		};

		public MainWindow()
		{
			InitializeComponent();

			regionComboBox.Items.Add("Białystok");
			regionComboBox.Items.Add("Warszawa");
			regionComboBox.Items.Add("Gdańsk");
			regionComboBox.Items.Add("Poznań");
			regionComboBox.Items.Add("Kraków");
			regionComboBox.Items.Add("Wrocław");
		}


		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			listboxdata.ItemsSource = osobaList;
		}

		private void Dodaj(object sender, RoutedEventArgs e)
		{
			DodajModal dlg = new DodajModal();
			dlg.Owner = this;
			var tmp = new Osoba();

			if (dlg.ShowDialog() == true)
			{
				tmp.Imie = dlg.Imie;
				tmp.Nazwisko = dlg.Nazwisko;
				tmp.Email = dlg.Email;
				tmp.Wplata = dlg.Wplata;
				tmp.Region = dlg.Region;
				tmp.Dostep = dlg.Dostep;
				osobaList.Add(tmp);
			}
		}

		private void Usun(object sender, RoutedEventArgs e)
		{
			if (listboxdata.SelectedIndex >= 0)
			{
				if (MessageBox.Show("Czy na pewno chcesz usunąć wskazanego użytkownika?", "Usuń użytkownika", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
					return;
				int tmpID = listboxdata.SelectedIndex;
				osobaList.RemoveAt(tmpID);
			}
		}

		private void CheckBox_Checked(object sender, RoutedEventArgs e)
		{
			email.IsEnabled = true;
			wplata.IsEnabled = true;
			regionComboBox.IsEnabled = true;
			dostepSlider.IsEnabled = true;
		}

		private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			email.IsEnabled = false;
			wplata.IsEnabled = false;
			regionComboBox.IsEnabled = false;
			dostepSlider.IsEnabled = false;
		}
	}
}
