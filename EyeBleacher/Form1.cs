using System;
using System.Windows.Forms;

namespace EyeBleacher
{
    public partial class Form1 : Form
    {

        string mainPostURL = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void CuteButton_Click(object sender, EventArgs e)
        {
            LoadPostData(CuteSubredditData.GetRandomCuteURL());
        }

        private void WholesomeButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPostData(WholesomeSubredditData.getRandomWholesomeURL());
            }
            catch (Newtonsoft.Json.JsonSerializationException)
            {

            }
        }

        private void CoolButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPostData(CoolSubredditData.GetRandomCoolURL());
            }
            catch (Newtonsoft.Json.JsonSerializationException)
            {

            }
        }

        private void OpenUrlButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mainPostURL) == true)
            {
                MessageBox.Show(
                    "You haven't clicked button to show you a random picture yet.\n\nDo that and try again!",
                    "Click a button first!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show(
                    "This will open the post in your default web browser.\n\n" + mainPostURL + "\n\nContinue?",
                    "Open in browser?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(mainPostURL);
                }
            }
        }

        private void LoadPostData(string[] returnedData)
        {
            string imageLink = returnedData[0];
            string postTitle = returnedData[1];
            string postAuthor = returnedData[2];
            string subredditName = returnedData[3];
            string upvotes = returnedData[4];
            string downvotes = returnedData[5];
            mainPostURL = returnedData[6];


            mainPictureBox.ImageLocation = imageLink;
            titleTextBox.Text = postTitle;
            usernameLabel.Text = postAuthor;
            subredditLabel.Text = subredditName;
            upvotesLabel.Text = upvotes;
            downvotesLabel.Text = downvotes;
        }
    }
}
