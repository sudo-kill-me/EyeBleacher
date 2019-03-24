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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernamePromptTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.titlePromptTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.subredditPromptTextBox = new System.Windows.Forms.TextBox();
            this.subredditTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cuteButton.Click += new System.EventHandler(this.cuteButton_Click);
            // 
            // wholesomeButton
            // 
            this.wholesomeButton.Location = new System.Drawing.Point(280, 508);
            this.wholesomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wholesomeButton.Name = "wholesomeButton";
            this.wholesomeButton.Size = new System.Drawing.Size(185, 34);
            this.wholesomeButton.TabIndex = 4;
            this.wholesomeButton.Text = "Something Wholesome";
            this.wholesomeButton.UseVisualStyleBackColor = true;
            this.wholesomeButton.Click += new System.EventHandler(this.wholesomeButton_Click);
            // 
            // coolButton
            // 
            this.coolButton.Location = new System.Drawing.Point(585, 508);
            this.coolButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coolButton.Name = "coolButton";
            this.coolButton.Size = new System.Drawing.Size(185, 34);
            this.coolButton.TabIndex = 5;
            this.coolButton.Text = "Something Cool";
            this.coolButton.UseVisualStyleBackColor = true;
            this.coolButton.Click += new System.EventHandler(this.coolButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // usernamePromptTextBox
            // 
            this.usernamePromptTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.usernamePromptTextBox.Location = new System.Drawing.Point(12, 39);
            this.usernamePromptTextBox.Name = "usernamePromptTextBox";
            this.usernamePromptTextBox.ReadOnly = true;
            this.usernamePromptTextBox.Size = new System.Drawing.Size(75, 22);
            this.usernamePromptTextBox.TabIndex = 10;
            this.usernamePromptTextBox.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(93, 39);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(167, 22);
            this.usernameTextBox.TabIndex = 8;
            // 
            // titlePromptTextBox
            // 
            this.titlePromptTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.titlePromptTextBox.Location = new System.Drawing.Point(12, 67);
            this.titlePromptTextBox.Name = "titlePromptTextBox";
            this.titlePromptTextBox.ReadOnly = true;
            this.titlePromptTextBox.Size = new System.Drawing.Size(75, 22);
            this.titlePromptTextBox.TabIndex = 10;
            this.titlePromptTextBox.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(93, 67);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(677, 22);
            this.titleTextBox.TabIndex = 11;
            // 
            // subredditPromptTextBox
            // 
            this.subredditPromptTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.subredditPromptTextBox.Location = new System.Drawing.Point(11, 11);
            this.subredditPromptTextBox.Name = "subredditPromptTextBox";
            this.subredditPromptTextBox.ReadOnly = true;
            this.subredditPromptTextBox.Size = new System.Drawing.Size(75, 22);
            this.subredditPromptTextBox.TabIndex = 10;
            this.subredditPromptTextBox.Text = "Subreddit:";
            // 
            // subredditTextBox
            // 
            this.subredditTextBox.Location = new System.Drawing.Point(93, 11);
            this.subredditTextBox.Name = "subredditTextBox";
            this.subredditTextBox.ReadOnly = true;
            this.subredditTextBox.Size = new System.Drawing.Size(167, 22);
            this.subredditTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.subredditTextBox);
            this.Controls.Add(this.subredditPromptTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titlePromptTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernamePromptTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coolButton);
            this.Controls.Add(this.wholesomeButton);
            this.Controls.Add(this.cuteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "EyeBleacher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cuteButton;
        private System.Windows.Forms.Button wholesomeButton;
        private System.Windows.Forms.Button coolButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernamePromptTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox titlePromptTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox subredditPromptTextBox;
        private System.Windows.Forms.TextBox subredditTextBox;
    }
}

