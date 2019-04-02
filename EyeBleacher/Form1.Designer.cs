namespace EyeBleacher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cuteButton = new System.Windows.Forms.Button();
            this.wholesomeButton = new System.Windows.Forms.Button();
            this.coolButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.subredditPromptLabel = new System.Windows.Forms.Label();
            this.usernamePromptLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subredditLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.upvotesLabel = new System.Windows.Forms.Label();
            this.downvotesLabel = new System.Windows.Forms.Label();
            this.downvoteImage = new System.Windows.Forms.PictureBox();
            this.upvoteImage = new System.Windows.Forms.PictureBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.openUrlButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.downvoteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upvoteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cuteButton
            // 
            this.cuteButton.Location = new System.Drawing.Point(11, 508);
            this.cuteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuteButton.Name = "cuteButton";
            this.cuteButton.Size = new System.Drawing.Size(185, 34);
            this.cuteButton.TabIndex = 2;
            this.cuteButton.Text = "Something Cute";
            this.cuteButton.UseVisualStyleBackColor = true;
            this.cuteButton.Click += new System.EventHandler(this.CuteButton_Click);
            // 
            // wholesomeButton
            // 
            this.wholesomeButton.Location = new System.Drawing.Point(335, 508);
            this.wholesomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wholesomeButton.Name = "wholesomeButton";
            this.wholesomeButton.Size = new System.Drawing.Size(185, 34);
            this.wholesomeButton.TabIndex = 4;
            this.wholesomeButton.Text = "Something Wholesome";
            this.wholesomeButton.UseVisualStyleBackColor = true;
            this.wholesomeButton.Click += new System.EventHandler(this.WholesomeButton_Click);
            // 
            // coolButton
            // 
            this.coolButton.Location = new System.Drawing.Point(668, 508);
            this.coolButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coolButton.Name = "coolButton";
            this.coolButton.Size = new System.Drawing.Size(185, 34);
            this.coolButton.TabIndex = 5;
            this.coolButton.Text = "Something Cool";
            this.coolButton.UseVisualStyleBackColor = true;
            this.coolButton.Click += new System.EventHandler(this.CoolButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(93, 67);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(760, 22);
            this.titleTextBox.TabIndex = 11;
            // 
            // subredditPromptLabel
            // 
            this.subredditPromptLabel.AutoSize = true;
            this.subredditPromptLabel.Location = new System.Drawing.Point(12, 14);
            this.subredditPromptLabel.Name = "subredditPromptLabel";
            this.subredditPromptLabel.Size = new System.Drawing.Size(73, 17);
            this.subredditPromptLabel.TabIndex = 14;
            this.subredditPromptLabel.Text = "Subreddit:";
            // 
            // usernamePromptLabel
            // 
            this.usernamePromptLabel.AutoSize = true;
            this.usernamePromptLabel.Location = new System.Drawing.Point(12, 42);
            this.usernamePromptLabel.Name = "usernamePromptLabel";
            this.usernamePromptLabel.Size = new System.Drawing.Size(81, 17);
            this.usernamePromptLabel.TabIndex = 15;
            this.usernamePromptLabel.Text = "Username: ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(43, 17);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Title: ";
            // 
            // subredditLabel
            // 
            this.subredditLabel.AutoSize = true;
            this.subredditLabel.Location = new System.Drawing.Point(99, 14);
            this.subredditLabel.Name = "subredditLabel";
            this.subredditLabel.Size = new System.Drawing.Size(0, 17);
            this.subredditLabel.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(99, 42);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 17);
            this.usernameLabel.TabIndex = 18;
            // 
            // upvotesLabel
            // 
            this.upvotesLabel.AutoSize = true;
            this.upvotesLabel.Location = new System.Drawing.Point(332, 14);
            this.upvotesLabel.Name = "upvotesLabel";
            this.upvotesLabel.Size = new System.Drawing.Size(0, 17);
            this.upvotesLabel.TabIndex = 19;
            // 
            // downvotesLabel
            // 
            this.downvotesLabel.AutoSize = true;
            this.downvotesLabel.Location = new System.Drawing.Point(332, 42);
            this.downvotesLabel.Name = "downvotesLabel";
            this.downvotesLabel.Size = new System.Drawing.Size(0, 17);
            this.downvotesLabel.TabIndex = 20;
            // 
            // downvoteImage
            // 
            this.downvoteImage.Image = global::EyeBleacher.Properties.Resources.downvoteLogo;
            this.downvoteImage.Location = new System.Drawing.Point(311, 42);
            this.downvoteImage.Name = "downvoteImage";
            this.downvoteImage.Size = new System.Drawing.Size(15, 15);
            this.downvoteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downvoteImage.TabIndex = 22;
            this.downvoteImage.TabStop = false;
            // 
            // upvoteImage
            // 
            this.upvoteImage.Image = global::EyeBleacher.Properties.Resources.upvoteLogo;
            this.upvoteImage.Location = new System.Drawing.Point(311, 16);
            this.upvoteImage.Name = "upvoteImage";
            this.upvoteImage.Size = new System.Drawing.Size(15, 15);
            this.upvoteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upvoteImage.TabIndex = 21;
            this.upvoteImage.TabStop = false;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(12, 95);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(841, 408);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 6;
            this.mainPictureBox.TabStop = false;
            // 
            // openUrlButton
            // 
            this.openUrlButton.BackColor = System.Drawing.SystemColors.Control;
            this.openUrlButton.Location = new System.Drawing.Point(11, 95);
            this.openUrlButton.Name = "openUrlButton";
            this.openUrlButton.Size = new System.Drawing.Size(126, 32);
            this.openUrlButton.TabIndex = 23;
            this.openUrlButton.Text = "Open in Browser";
            this.openUrlButton.UseVisualStyleBackColor = false;
            this.openUrlButton.Click += new System.EventHandler(this.OpenUrlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 553);
            this.Controls.Add(this.openUrlButton);
            this.Controls.Add(this.downvoteImage);
            this.Controls.Add(this.upvoteImage);
            this.Controls.Add(this.downvotesLabel);
            this.Controls.Add(this.upvotesLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.subredditLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.usernamePromptLabel);
            this.Controls.Add(this.subredditPromptLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.coolButton);
            this.Controls.Add(this.wholesomeButton);
            this.Controls.Add(this.cuteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "EyeBleacher";
            ((System.ComponentModel.ISupportInitialize)(this.downvoteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upvoteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cuteButton;
        private System.Windows.Forms.Button wholesomeButton;
        private System.Windows.Forms.Button coolButton;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label subredditPromptLabel;
        private System.Windows.Forms.Label usernamePromptLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subredditLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label upvotesLabel;
        private System.Windows.Forms.Label downvotesLabel;
        private System.Windows.Forms.PictureBox upvoteImage;
        private System.Windows.Forms.PictureBox downvoteImage;
        private System.Windows.Forms.Button openUrlButton;
    }
}

