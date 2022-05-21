using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Tutorial
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void SubmitForm(object sender, RoutedEventArgs e)
		{
			string firstName = firstNameBox.Text;
			string lastName = lastNameBox.Text;

			firstNameBox.Clear();
			lastNameBox.Clear();

			firstNameBox.Visibility = Visibility.Hidden;
			firstNameLabel.Visibility = Visibility.Hidden;
			lastNameBox.Visibility = Visibility.Hidden;
			lastNameLabel.Visibility = Visibility.Hidden;
			submitButton.Visibility = Visibility.Hidden;
			exitButton.Visibility = Visibility.Visible;

			successMessage.Content = $"Vielen Dank für Ihren einkauf, {firstName} {lastName}.";
		}

		private void ExitProgram(object sender, RoutedEventArgs e) {
			System.Windows.Application.Current.Shutdown();
		}
	}
}
