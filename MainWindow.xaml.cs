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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nested_for
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
            StringBuilder show = new StringBuilder();
            for(int i = 0; i < 2; i++)
            {
                for(int j=0; j<3;j++)
                {
                  for(int k=0;k<4;k++)
                    {
                        for (int l=0;l<5;l++)
                        {
                            show.Append(i.ToString());
                            show.Append(j.ToString());
                            show.Append(k.ToString());
                            show.Append(l.ToString());
                            show.AppendLine(",");
                            lbl1.Content = show.ToString();
                        }
                    }
                }
            }
        }
    }
}
