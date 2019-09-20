﻿using System;
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

namespace ExampleApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		

		private void ButtonA_Click(object sender, RoutedEventArgs e) {
			// combine two strings with String methods

			string first = "1. The Banana is yellow.";
			string second = "2. The pear is ripe.";
			string third = "3. A tomato is not a vegetable, it's a fruit!";
			string florette = " ✿ ";

			string combo = string.Empty;

			combo = String.Concat(first, second);
			combo = String.Concat(first,florette, second);
			combo = String.Concat(first, florette, second, florette, third);
			OutputTextBox.Text = combo;
		}

		private void ButtonB_Click(object sender, RoutedEventArgs e) {
			string first = "1.The Banana is yellow.";
			string second = "2.The pear is ripe.";
			string third = "3. A tomato is not a vegetable, it's a fruit!";
			string florette = " ✿ ";

			string combo = string.Empty;

			combo = combo.Insert(0,third).Insert(0,florette).Insert(0,second);

			OutputTextBox.Text = combo;
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Text = string.Empty;
		}
	}
}
