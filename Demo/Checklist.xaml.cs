using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Checklist
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ChecklistOverview : UserControl
    {
        public ChecklistOverview()
        {
            InitializeComponent();


        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            string Item = $" - {ToDoItem.Text}";

            if (!string.IsNullOrEmpty(Item))
            {
                TextBlock item = new TextBlock
                {
                    Padding = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.Black),
                    Text = Item

                };

                TodoList.Children.Add(item);
                ToDoItem.Clear();
            }
        }
    }
}
