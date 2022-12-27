
using System;
using System.CodeDom;
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

namespace forloop
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
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int initial = Convert.ToInt32(txtinitial.Text);
            int condition = Convert.ToInt32(txtcond.Text);
            int value = Convert.ToInt32(txtvalue.Text);
            string print = "";

            if (initial > 1000 || condition > 1000 || value > 100)
            {
                MessageBoxResult result = MessageBox.Show("error invalid input", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //if(result== MessageBoxResult.OK)
                //   {
                //       txtinitial.Clear();
                //       txtcond.Clear();
                //       txtvalue.Clear();
                //   }
            }

            else
            {
                for (int i = initial; i <= condition; i = i + value)
                {
                    if (print == "")
                    {
                        print = i.ToString();
                    }
                    else
                    {
                        print = print + " " + i.ToString();
                    }

                }
            }
            // MessageBox.Show(print);
            lbl1.Content = print;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int initial = Convert.ToInt32(txtinitial.Text);
            int condition = Convert.ToInt32(txtcond.Text);
            int value = Convert.ToInt32(txtvalue.Text);
            string print = "";

            if (initial > 1000 || condition > 1000 || value > 100)
            {
                MessageBoxResult result = MessageBox.Show("error invalid input", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //if(result== MessageBoxResult.OK)
                //   {
                //       txtinitial.Clear();
                //       txtcond.Clear();
                //       txtvalue.Clear();
                //   }
            }
            else
            {
                for (int j = initial; j >= condition; j = j - value)
                {
                    if (print == "")
                    {
                        print = j.ToString();
                    }
                    else
                    {
                        print = print + " " + j.ToString();
                    }

                }
            }
            // MessageBox.Show(print);
            lbl2.Content = print;
        }
    }
}
