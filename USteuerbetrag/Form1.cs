using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USteuerbetrag
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnBerechnen_Click(object sender, EventArgs e)
		{
			// Gehalt einlesen und in einer Variablen speichern
			double gehalt = Convert.ToDouble(txtGehalt.Text);

			// Variable für den Steuersatz anlegen
			double steuersatz = 0.0;

			// Steuersatz abhängig vom Gehalt auswählen
			if (gehalt >= 0 && gehalt <= 12000)
			{
				steuersatz = 12 / 100;
			}
			if (gehalt > 12000 && gehalt <= 20000)
			{
				steuersatz = 0.15;
			}
			if (gehalt > 20000 && gehalt <= 30000)
			{
				steuersatz = 0.20;
			}
			if (gehalt > 30000)
			{
				steuersatz = 0.25;
			}

			// Steuerbetrag berechnen 
			double steuerbetrag = gehalt * steuersatz;

			// und ausgeben
			lblSteuerbetrag.Text = "Steuerbetrag: " + steuerbetrag;
		}
	}
}
