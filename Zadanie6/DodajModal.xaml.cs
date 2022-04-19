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
using System.Windows.Shapes;

namespace Zadanie6
{

	public partial class DodajModal : Window
	{
		public DodajModal()
		{
			InitializeComponent();

			regionComboBox.Items.Add("Białystok");
			regionComboBox.Items.Add("Warszawa");
			regionComboBox.Items.Add("Gdańsk");
			regionComboBox.Items.Add("Poznań");
			regionComboBox.Items.Add("Kraków");
			regionComboBox.Items.Add("Wrocław");
		}

		public string Imie { get; set; }
		public string Nazwisko { get; set; }
		public string Email { get; set; }
		public decimal Wplata { get; set; }
		public string Region { get; set; }
		public int Dostep { get; set; }

		private void OnOK(object sender, RoutedEventArgs e)
		{
			Imie = name.Text;
			Nazwisko = surname.Text;
			Email = email.Text;
			Wplata = Convert.ToDecimal(payment.Text);
			Region = regionComboBox.Text;
			Dostep = Convert.ToInt32(dostepSlider.Value);

			DialogResult = true;
			Close();
		}
	}
}
