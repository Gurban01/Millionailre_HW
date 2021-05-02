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

namespace Millionailre_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameWindow game;// = new GameWindow();
        public MainWindow()
        {
            InitializeComponent();
            game = new GameWindow();
        }

        private void playButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            game.ShowDialog();
        }

        private void quitButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void quitButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Question[] temparr = game.arr;
            game.arr = new Question[game.arr.Length + 1];
            for(int i=0;i<game.arr.Length-1;i++)
            {
                game.arr[i] = temparr[i];
            }
            game.arr[game.arr.Length-1] = new Question(q.Text, a1.Text, a2.Text, a3.Text, a4.Text, Convert.ToInt32(r.Text));
            MessageBox.Show("Question succesfuly added");
            q.Text = "";
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            r.Text = "";
        }
    }
}
