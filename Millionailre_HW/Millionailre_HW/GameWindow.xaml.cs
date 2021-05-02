using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;




namespace Millionailre_HW
{
  
    public partial class GameWindow : Window
    {
        
        WinMessage YouWin;
        LoseMessage YouLose;
        HallHelp h;

        public Question[] arr;
        int qCounter = 0;
        public GameWindow()
        {
            InitializeComponent();
            arr = new Question[15];
            InitializeQuestions(arr);

            RandomizeArray(arr);
            question_TextBox.Text = arr[0].question;
            answer_1.Text = arr[0].answer1;
            answer_2.Text = arr[0].answer2;
            answer_3.Text = arr[0].answer3;
            answer_4.Text = arr[0].answer4;

            YouWin = new WinMessage();
            YouLose = new LoseMessage();

        }
        public void InitializeQuestions(Question []arr)
        {
            arr[0] = new Question("Capital of Ireland ?", "New York", "Baku", "Los Angeles", "Dublin",4);

            arr[1] = new Question("What is GPU ?","Graphical cart of computer","Name of the Song","Artist","Capital of USA",1);

            arr[2] = new Question("Who wrote the song \" Lose yourself \" ?","BTS","Morgenshtern","Eminem","J.Cole",3);

            arr[3] = new Question("Who wrote the book \"Harry Potter \" ?","J.Rowling","D.Brown","Stephen King","Richter",1);

            arr[4] = new Question("Which fictional city is the home of Batman ?", "Gotham City", "New York City", "Baku", "Miamy",1);

            arr[5] = new Question("Which planet is the closest to Earth ?", "Jupiter", "Mars", "Venus", "Pluto",3);

            arr[6] = new Question("Which is the tallest mammal ?","Tiger","Lion","Elephant","Giraffe",4);

            arr[7] = new Question("How many strings does a violin have ?", "3", "4", "5", "6",2);

            arr[8] = new Question("What color is the circle on the Japanese national flag ?","Green","Red","Black","Blue",2);

            arr[9] = new Question("What is the chemical symbol for Hydrogen ?","He","Ca","H","Hg",3);

            arr[10] = new Question("How many sides does an octagon have ?","6","8","9","4",2);

            arr[11] = new Question("What’s the total number of dots on a pair of dice ?","32","54","42","98",3);

            arr[12] = new Question("The number of players in footbal team ?", "5", "8", "13", "11", 4);

            arr[13] = new Question("The number of colors in rainbow", "4", "7", "13", "9", 2);

            arr[14] = new Question("The number of stars in USA flag", "51", "49", "37", "24", 1);
        }

        private void RandomizeArray(Question[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int j = rand.Next(i, arr.Length);
                Question temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        private void A_button_Click(object sender, RoutedEventArgs e)
        { 
            if (qCounter == 14)
            {
                YouWin.ShowDialog(); this.Close();

            }
            else if (arr[qCounter].rightanswer == 1)
            {
                qCounter++;
                question_TextBox.Text = arr[qCounter].question;
                answer_1.Text = arr[qCounter].answer1;
                answer_2.Text = arr[qCounter].answer2;
                answer_3.Text = arr[qCounter].answer3;
                answer_4.Text = arr[qCounter].answer4;
                q1.Margin = new Thickness(q1.Margin.Left, q1.Margin.Top - 27, q1.Margin.Right, q1.Margin.Bottom);

            }
            else 
            {
                answer_1.Background = Brushes.Red;
                YouLose.Show();
                this.Close();

            }

        }
        private void B_button_Click(object sender, RoutedEventArgs e)
        {
            if (qCounter == 14)
            {
                YouWin.ShowDialog(); this.Close();

            }
            else if (arr[qCounter].rightanswer == 2 )
            {
               qCounter++;
               question_TextBox.Text = arr[qCounter].question;
               answer_1.Text = arr[qCounter].answer1;
               answer_2.Text = arr[qCounter].answer2;
               answer_3.Text = arr[qCounter].answer3;
               answer_4.Text = arr[qCounter].answer4;
                q1.Margin = new Thickness(q1.Margin.Left, q1.Margin.Top - 27, q1.Margin.Right, q1.Margin.Bottom);

            }
            else 
            {  
               answer_2.Background = Brushes.Red;
               YouLose.Show();
                this.Close();

            }
        }
        private void C_button_Click(object sender, RoutedEventArgs e)
        {
            if (qCounter == 14)
            {
                YouWin.ShowDialog(); this.Close();

            }
            else if (arr[qCounter].rightanswer == 3 )
            {
                qCounter++;
                question_TextBox.Text = arr[qCounter].question;
                answer_1.Text = arr[qCounter].answer1;
                answer_2.Text = arr[qCounter].answer2;
                answer_3.Text = arr[qCounter].answer3;
                answer_4.Text = arr[qCounter].answer4;
                q1.Margin = new Thickness(q1.Margin.Left, q1.Margin.Top - 27, q1.Margin.Right, q1.Margin.Bottom);

            }
            else 
            {
                answer_3.Background = Brushes.Red;
                YouLose.Show();
                this.Close();

            }
        }
        private void D_button_Click(object sender, RoutedEventArgs e)
        {
            if (qCounter == 14)
            {
                YouWin.ShowDialog(); this.Close();

            }
            if (arr[qCounter].rightanswer == 4 )
            {
                qCounter++;
                question_TextBox.Text = arr[qCounter].question;
                answer_1.Text = arr[qCounter].answer1;
                answer_2.Text = arr[qCounter].answer2;
                answer_3.Text = arr[qCounter].answer3;
                answer_4.Text = arr[qCounter].answer4;
                q1.Margin = new Thickness(q1.Margin.Left, q1.Margin.Top- 27, q1.Margin.Right, q1.Margin.Bottom);
               
            }
            else 
            {
                answer_4.Background = Brushes.Red;
                YouLose.Show();
                this.Close();
                
            }
        }

        private void Hint_button1_Click(object sender, RoutedEventArgs e)
        {
            if(arr[qCounter].rightanswer==1)
            {
                answer_2.Text = "";
                answer_3.Text = "";
            }
            else if(arr[qCounter].rightanswer==2)
            {
                answer_1.Text = "";
                answer_3.Text = "";
            }
            else if (arr[qCounter].rightanswer == 3)
            {
                answer_1.Text = "";
                answer_4.Text = "";
            }
            else if (arr[qCounter].rightanswer == 4)
            {
                answer_1.Text = "";
                answer_2.Text = "";
            }
            Hint_button1.IsEnabled = false;
        }

        private void Hint_button2_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            string answerFriend="";
            int r=0;
            if(arr[qCounter].rightanswer==1)
            {

                r = rand.Next( arr[qCounter].rightanswer,arr[qCounter].rightanswer+1);
            }
            else
            {
                r = rand.Next(arr[qCounter].rightanswer - 1, arr[qCounter].rightanswer);
            }
            if(r==1)
            {
                answerFriend = arr[qCounter].answer1;
            }
            else if(r==2)
            {
                answerFriend = arr[qCounter].answer2;
            }
            else if (r == 3)
            {
                answerFriend = arr[qCounter].answer3;
            }
            else if (r == 4)
            {
                answerFriend = arr[qCounter].answer4;
            }
            MessageBox.Show("Answer of Friend-> " + answerFriend);
            Hint_button2.IsEnabled = false;
        }

        private void Hint_button3_Click(object sender, RoutedEventArgs e)
        {
            int z1, z2, z3, z4;
            Random rand = new Random();
            z1 = rand.Next(0, 100);
            z2 = rand.Next(0, 100 - z1);
            z3 = rand.Next(0, 100 - (z1 + z2));
            z4 = 100 - (z1 + z2 + z3);
            h = new HallHelp(z1, z2, z3, z4);
            h.Show();
            Hint_button3.IsEnabled = false;
        }
    }
    public class Question
    {
        public string question;
        public string answer1, answer2, answer3, answer4;
        public int rightanswer;

        public Question(string q,string a1,string a2,string a3,string a4,int r)
        {
            this.question = q;
            this.answer1 = a1;
            this.answer2 = a2;
            this.answer3 = a3;
            this.answer4 = a4;
            this.rightanswer = r;
        }
    }
}