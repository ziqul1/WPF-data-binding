using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
	public class Osoba : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string property)
		{
			if (PropertyChanged != null)
				PropertyChanged(this,
				new PropertyChangedEventArgs(property));
		}

		private string imie;
		public string Imie
		{ 
			get { return imie;  } 
			set { imie = value; OnPropertyChanged("singleUserInListView"); } 
		}


		private string nazwisko;
		public string Nazwisko
		{
			get { return nazwisko; }
			set { nazwisko = value; OnPropertyChanged("singleUserInListView"); }
		}


		private string email;
		public string Email
		{
			get { return email; }
			set { email = value; OnPropertyChanged("singleUserInListView"); }
		}

		public decimal Wplata { get; set; }
		public string Region { get; set; }
		public int Dostep { get; set; }

		public Osoba() 
		{
			Imie = "";
			Nazwisko = "";
			Email = "";
			Wplata = 0;
			Region = "Białystok";
			Dostep = 0;
		}

		public string singleUserInListView
		{
			get
			{
				return $"{Imie } {Nazwisko} ({Email})";
			}
		}
	}
}
