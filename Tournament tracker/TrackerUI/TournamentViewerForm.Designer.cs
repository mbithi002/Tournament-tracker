namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreText = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.White;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(12, 23);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(431, 100);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.BackColor = Color.White;
            tournamentName.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = Color.Black;
            tournamentName.Location = new Point(463, 23);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(300, 100);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            roundLabel.Location = new Point(26, 144);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(182, 71);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += roundLabel_Click;
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(272, 157);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(242, 58);
            roundDropDown.TabIndex = 4;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.ForeColor = Color.BlueViolet;
            unplayedOnlyCheckbox.Location = new Point(272, 259);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(295, 54);
            unplayedOnlyCheckbox.TabIndex = 5;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 50;
            matchupListBox.Location = new Point(39, 318);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(501, 352);
            matchupListBox.TabIndex = 6;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneName.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneName.Location = new Point(667, 259);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(325, 71);
            teamOneName.TabIndex = 7;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneScoreLabel.Location = new Point(667, 330);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(159, 71);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(832, 344);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(200, 57);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.Location = new Point(832, 580);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(200, 57);
            teamTwoScoreText.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoScoreLabel.Location = new Point(667, 566);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(159, 71);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoName.Location = new Point(667, 495);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(323, 71);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = Color.FromArgb(51, 153, 255);
            versusLabel.Location = new Point(798, 424);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(133, 71);
            versusLabel.TabIndex = 13;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            scoreButton.Location = new Point(1139, 429);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(218, 66);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1539, 703);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreText);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreText;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
