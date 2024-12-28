namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            createTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            Delete = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.BackColor = Color.White;
            headerLabel.Font = new Font("Segoe UI Light", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(25, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(640, 100);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            headerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(25, 228);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(639, 65);
            tournamentNameValue.TabIndex = 11;
            tournamentNameValue.TextChanged += tournamentNameValue_TextChanged;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(25, 134);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(467, 71);
            tournamentNameLabel.TabIndex = 10;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(324, 315);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(200, 65);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(25, 315);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(246, 71);
            entryFeeLabel.TabIndex = 12;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(25, 521);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(639, 67);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(25, 422);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(265, 71);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Add Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(434, 432);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(230, 59);
            createNewTeamLink.TabIndex = 16;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(131, 674);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(361, 66);
            createTeamButton.TabIndex = 17;
            createTeamButton.Text = "Add Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(131, 786);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(361, 66);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 59;
            tournamentPlayersListBox.Location = new Point(840, 172);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(561, 238);
            tournamentPlayersListBox.TabIndex = 19;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentPlayersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new Point(840, 98);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(391, 71);
            tournamentPlayersLabel.TabIndex = 20;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // Delete
            // 
            Delete.FlatAppearance.BorderColor = Color.Silver;
            Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.FromArgb(51, 153, 255);
            Delete.Location = new Point(1430, 258);
            Delete.Name = "Delete";
            Delete.Size = new Size(218, 66);
            Delete.TabIndex = 21;
            Delete.Text = "Score";
            Delete.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.AutoSize = true;
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPrizeButton.Location = new Point(1246, 808);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(402, 72);
            deleteSelectedPrizeButton.TabIndex = 24;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(840, 474);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(391, 71);
            prizesLabel.TabIndex = 23;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 59;
            prizesListBox.Location = new Point(840, 548);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(561, 238);
            prizesListBox.TabIndex = 22;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1677, 1375);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(Delete);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(createTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button createTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button Delete;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
    }
}