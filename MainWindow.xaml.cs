﻿using System.Windows;
using System.Windows.Controls;
using DuctApp.UserControls;

namespace DuctApp
{

    public class ComponentData
    {
        public required string Component { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ElementTree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (ElementTree.SelectedItem is TreeViewItem selectedItem)
            {
                if (selectedItem.Tag != null)
                {
                    switch (selectedItem.Tag.ToString())
                    {
                        case "Root":
                            ContentArea.Content = new RootInfoControl();
                            break;
                        case "Elements":
                            ContentArea.Content = new TextBlock { Text = "Настройка элементов трассы" };
                            break;
                    }
                }
                else
                {
                    switch (selectedItem.Header.ToString())
                    {
                        case "Воздуховод":
                            ContentArea.Content = new DuctInfoControl();
                            break;
                        case "Отвод":
                            ContentArea.Content = new ElbowInfoControl();
                            break;
                        case "Тройник":
                            ContentArea.Content = new TextBlock { Text = "Настройка тройника" };
                            break;
                        case "Крестовина":
                            ContentArea.Content = new TextBlock { Text = "Настройка крестовины" };
                            break;
                        case "Переход":
                            ContentArea.Content = new TextBlock { Text = "Настройка перехода" };
                            break;
                        case "Утка":
                            ContentArea.Content = new TextBlock { Text = "Настройка утки" };
                            break;
                        case "Заглушка":
                            ContentArea.Content = new TextBlock { Text = "Настройка заглушки" };
                            break;
                    }
                }
            }
        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}