using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;  //we use WebClinet in this program System.Net Contains utlities for internet things.

namespace hangmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        string word; //to hold the word.

        List<Label> labels = new List<Label>();  //Add labels 

        int amount = 0;

        //These are the bodyParts i want to create.
        enum BodyParts {

            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Right_Arm,
            Left_Arm,
            Body,
            Right_Leg,
            Left_Leg
                
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            MakeLabels();
        }

        void DrawHangPost() {


            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown,10);   //10 is the thickness
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));  //start at 130X and 218Y  End at 130X and  5Y   
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));     //start at 135X and 5Y    End at 65X  and  5Y
            g.DrawLine(p, new Point(60, 0),new Point(60,50));       //start at 60X  and 0Y    End at 60X  and  50Y

            

        }

       


        void DrawBodyParts(BodyParts bp) {

            Graphics g = panel1.CreateGraphics();  //Created a Graphics for the panel1
            Pen p = new Pen(Color.Blue, 2);        //Created a Pen with Blue Color and 2 size of thickness pen.

            if (bp == BodyParts.Head)
            {

                g.DrawEllipse(p, 40, 50, 40, 40);  // 40X 50Y 40 Width 40 Height  

            }
            else if (bp == BodyParts.Left_Eye)
            {

                SolidBrush s = new SolidBrush(Color.Black);     //Made a SolidBrash because we need to fill not to draw
                g.FillEllipse(s, 50, 60, 5, 5);                // 50X 60Y 5 Width 5 Height            

            }
            else if (bp == BodyParts.Right_Eye)
            {

                SolidBrush s = new SolidBrush(Color.Black);     //Made a SolidBrash because we need to fill not to draw
                g.FillEllipse(s, 63, 60, 5, 5);                 // 63X 60Y 5 Width 5 Height.

            }
            else if (bp == BodyParts.Mouth)
            {

                g.DrawArc(p, 50, 60, 20, 20, 45, 90);    //50X 60Y 20 Width 20 Height 45 StartAngle 90 SweepAngle

            }
            else if (bp == BodyParts.Body)
            {

                g.DrawLine(p, new Point(60, 90), new Point(60, 170));  //start at 60X 90Y  End at 60X 170Y

            }
            else if (bp == BodyParts.Left_Arm)
            {

                g.DrawLine(p, new Point(60, 100), new Point(30, 85));  //start at 60X 100Y End at 30X 85Y

            }
            else if (bp == BodyParts.Right_Arm)
            {


                g.DrawLine(p, new Point(60, 100), new Point(90, 85)); //start at  60X 100Y End at 90X 85Y
            }
            else if (bp == BodyParts.Left_Leg)
            {

                g.DrawLine(p, new Point(60, 170), new Point(30, 190)); //start  at  60X 170Y End at 30X 190Y 

            }
            else if (bp == BodyParts.Right_Leg) {


                g.DrawLine(p, new Point(60, 170), new Point(90, 190));//start  at 60X 170Y   End at 90X 190Y
            }
            

        }

        //This method makes labels.
        void MakeLabels() {

            word = GetRandomWords().Trim();                         //Stored the randomWord in the word variable. and clear any whitespace at the start and end
            char[] chars = word.ToArray();                         //Converted that word into chars array.
            int between = groupBox2.Width / chars.Length - 1;      //Got the between whiteSpace between each chars.  Ex 400 / 8 = 50

            for (int a = 0; a < chars.Length - 1; a++) {          //This for loop runs depanding on the length of the chars. 

                labels.Add(new Label());                           //Create new label() 
                labels[a].Location = new Point((a * between) + 10, 80); //It will locate the label. a will change multiply with between + 10 to place correctly.
                labels[a].Text = "_";                                   //Text value for each label is "_".
                labels[a].Parent = groupBox2;                           //Assign the groupBox2 as the label's parent.
                labels[a].BringToFront();                               //Bring them to the front
                labels[a].CreateControl();                              //Create contoler.
            }

            label1.Text = "Word Length " + (chars.Length-1).ToString();
        }


        string GetRandomWords() {

            WebClient wc = new WebClient(); //Created a WebClient to contact to the website which contains the wordList.txt.
            string wordList = wc.DownloadString("http://localhost/web/wordList.txt");  //we download that txt file and stored in the wordList Var.
            string[] words = wordList.Split('\n'); //split by newline.
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)]; //-1 because index start at 0. 


        }

        void ResetGame() {//reset method.


            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            GetRandomWords();
            MakeLabels();
            DrawHangPost();
            label2.Text = "Missed:";
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter = textBox1.Text.ToLower().ToCharArray()[0];     //Stored the letter that the user enter in this variable. and Converted to lowercase.

            if (!char.IsLetter(letter)) {                               //if it is not a letter. Do the followings.

                MessageBox.Show("You can only submit Letters !","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (word.Contains(letter))
            {                                                  //If the word contains the letter.

                char[] letters = word.ToCharArray();          //Convert the word into char array in the letters variable.

                for (int s = 0; s < letters.Length; s++)
                {    //run a for loop depanding on the length of letters.

                    if (letters[s] == letter)
                    {               //check to see if the letters have the letter that the user entered.

                        labels[s].Text = letter.ToString();   //Place that letter according to the labels.
                    }
                }

                foreach (Label l in labels) 
                {

                    if (l.Text != "_") {

                        return;
                        MessageBox.Show("You have Won");
                        ResetGame(); //Reset the game.

                    }
                   
                }

            }
            else
            {    //If the word does not contain the letter.

                MessageBox.Show("The Letter that you guessed is not in the word","Sorry");
                label2.Text += " " + letter.ToString()+","; //Display the letter that you missed.
                DrawBodyParts((BodyParts)amount);           //call each bodyParts one by one.
                amount++;                                   //Incrment by one every time when the wrong answer given.


                if (amount==9) {

                    MessageBox.Show("Sorry You Lost! And the Word was "+word);
                    ResetGame();//Restart the game.
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (textBox2.Text == word)//if the word is same as that the user enter 
            {

                MessageBox.Show("You have won the game", "Good Job");
                ResetGame();//restart the game.

            }
            else {//If the user answer is wrong.

                MessageBox.Show("The word that you guessed is wrong","Sorry");
                DrawBodyParts((BodyParts)amount);
                amount++;

                if (amount == 9) {//if the amount == 9

                    MessageBox.Show("Sorry You lost the games");
                    ResetGame();
                }
            }

        }
    }
}
