using System;
using System.Windows.Forms;

namespace EyeBleacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cuteButton_Click(object sender, EventArgs e)
        {
                string[] returnedData = CuteSubredditData.getRandomEyebleachURL();
                string imageLink = returnedData[0];
                string postTitle = returnedData[1];
                string postAuthor = returnedData[2];
                string subredditName = returnedData[3];

                pictureBox1.ImageLocation = imageLink;
                titleTextBox.Text = postTitle;
                usernameTextBox.Text = postAuthor;
                subredditTextBox.Text = subredditName;

        }

        private void wholesomeButton_Click(object sender, EventArgs e)
        {
                string[] returnedData = WholesomeSubredditData.getRandomWholesomeURL();
                string imageLink = returnedData[0];
                string postTitle = returnedData[1];
                string postAuthor = returnedData[2];
                string subredditName = returnedData[3];

                pictureBox1.ImageLocation = imageLink;
                titleTextBox.Text = postTitle;
                usernameTextBox.Text = postAuthor;
                subredditTextBox.Text = subredditName;
        }

        private void coolButton_Click(object sender, EventArgs e)
        {
                string[] returnedData = CoolSubredditData.getRandomCoolURL();
                string imageLink = returnedData[0];
                string postTitle = returnedData[1];
                string postAuthor = returnedData[2];
                string subredditName = returnedData[3];

                pictureBox1.ImageLocation = imageLink;
                titleTextBox.Text = postTitle;
                usernameTextBox.Text = postAuthor;
                subredditTextBox.Text = subredditName;
        }
    }
}
