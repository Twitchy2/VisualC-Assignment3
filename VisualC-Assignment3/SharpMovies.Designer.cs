namespace VisualC_Assignment3
{
    partial class SharpMovies
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
            this.OpenLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.SelectedGrpBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CatagoryTextBox = new System.Windows.Forms.TextBox();
            this.CatagoryLabel = new System.Windows.Forms.Label();
            this.SelectedMovieTextBox = new System.Windows.Forms.TextBox();
            this.SelectedMovieLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectedGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.Location = new System.Drawing.Point(15, 41);
            this.OpenLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(502, 20);
            this.OpenLabel.TabIndex = 0;
            this.OpenLabel.Text = "Sharp Movies, The Streaming Service Of The Future";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Death Race 2",
            "Doctor Strange",
            "Hacksaw Ridge",
            "Lights Out",
            "Mama",
            "Pete\'s Dragon",
            "Ratchet & Clank",
            "Sully",
            "The Green Hornet",
            "The Mechanic",
            "The Rite"});
            this.MoviesListBox.Location = new System.Drawing.Point(21, 114);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(190, 404);
            this.MoviesListBox.Sorted = true;
            this.MoviesListBox.TabIndex = 1;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(15, 86);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(201, 20);
            this.MovieLabel.TabIndex = 2;
            this.MovieLabel.Text = "Choose Your Movie:";
            // 
            // SelectedGrpBox
            // 
            this.SelectedGrpBox.Controls.Add(this.CostLabel);
            this.SelectedGrpBox.Controls.Add(this.CostTextBox);
            this.SelectedGrpBox.Controls.Add(this.CatagoryTextBox);
            this.SelectedGrpBox.Controls.Add(this.CatagoryLabel);
            this.SelectedGrpBox.Controls.Add(this.SelectedMovieTextBox);
            this.SelectedGrpBox.Controls.Add(this.SelectedMovieLabel);
            this.SelectedGrpBox.Controls.Add(this.MoviePictureBox);
            this.SelectedGrpBox.Location = new System.Drawing.Point(217, 114);
            this.SelectedGrpBox.Name = "SelectedGrpBox";
            this.SelectedGrpBox.Size = new System.Drawing.Size(493, 272);
            this.SelectedGrpBox.TabIndex = 3;
            this.SelectedGrpBox.TabStop = false;
            this.SelectedGrpBox.Text = "Chosen Movie Stream:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(219, 174);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(53, 20);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(219, 197);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(268, 27);
            this.CostTextBox.TabIndex = 4;
            // 
            // CatagoryTextBox
            // 
            this.CatagoryTextBox.Location = new System.Drawing.Point(219, 127);
            this.CatagoryTextBox.Name = "CatagoryTextBox";
            this.CatagoryTextBox.ReadOnly = true;
            this.CatagoryTextBox.Size = new System.Drawing.Size(268, 27);
            this.CatagoryTextBox.TabIndex = 4;
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.Location = new System.Drawing.Point(219, 104);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(110, 20);
            this.CatagoryLabel.TabIndex = 3;
            this.CatagoryLabel.Text = "Catagory";
            // 
            // SelectedMovieTextBox
            // 
            this.SelectedMovieTextBox.Location = new System.Drawing.Point(219, 50);
            this.SelectedMovieTextBox.Name = "SelectedMovieTextBox";
            this.SelectedMovieTextBox.ReadOnly = true;
            this.SelectedMovieTextBox.Size = new System.Drawing.Size(268, 27);
            this.SelectedMovieTextBox.TabIndex = 2;
            // 
            // SelectedMovieLabel
            // 
            this.SelectedMovieLabel.AutoSize = true;
            this.SelectedMovieLabel.Location = new System.Drawing.Point(219, 27);
            this.SelectedMovieLabel.Name = "SelectedMovieLabel";
            this.SelectedMovieLabel.Size = new System.Drawing.Size(152, 20);
            this.SelectedMovieLabel.TabIndex = 1;
            this.SelectedMovieLabel.Text = "Selected Movie";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(7, 27);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(206, 239);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(582, 470);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(122, 48);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SharpMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 529);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectedGrpBox);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Controls.Add(this.OpenLabel);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpMovies";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Movie Streaming";
            this.SelectedGrpBox.ResumeLayout(false);
            this.SelectedGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.GroupBox SelectedGrpBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CatagoryTextBox;
        private System.Windows.Forms.Label CatagoryLabel;
        private System.Windows.Forms.TextBox SelectedMovieTextBox;
        private System.Windows.Forms.Label SelectedMovieLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}

