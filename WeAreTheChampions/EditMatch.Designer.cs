
namespace WeAreTheChampions
{
    partial class EditMatch
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.nudAwayTeamScore = new System.Windows.Forms.NumericUpDown();
            this.nudHomeTeamScore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAwayTeams = new System.Windows.Forms.ComboBox();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "-";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "-";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "-";
            this.label7.Visible = false;
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(162, 34);
            this.nudMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(41, 26);
            this.nudMonth.TabIndex = 85;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(94, 34);
            this.nudDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(44, 26);
            this.nudDay.TabIndex = 84;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(228, 34);
            this.nudYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(64, 26);
            this.nudYear.TabIndex = 83;
            this.nudYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(201, 70);
            this.nudMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 26);
            this.nudMinute.TabIndex = 82;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(137, 70);
            this.nudHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(44, 26);
            this.nudHour.TabIndex = 81;
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.BackColor = System.Drawing.Color.Gold;
            this.btnEditMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditMatch.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditMatch.Location = new System.Drawing.Point(82, 229);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(222, 62);
            this.btnEditMatch.TabIndex = 80;
            this.btnEditMatch.Text = "Edit Match";
            this.btnEditMatch.UseVisualStyleBackColor = false;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // nudAwayTeamScore
            // 
            this.nudAwayTeamScore.Location = new System.Drawing.Point(219, 177);
            this.nudAwayTeamScore.Name = "nudAwayTeamScore";
            this.nudAwayTeamScore.Size = new System.Drawing.Size(56, 26);
            this.nudAwayTeamScore.TabIndex = 79;
            // 
            // nudHomeTeamScore
            // 
            this.nudHomeTeamScore.Location = new System.Drawing.Point(108, 177);
            this.nudHomeTeamScore.Name = "nudHomeTeamScore";
            this.nudHomeTeamScore.Size = new System.Drawing.Size(56, 26);
            this.nudHomeTeamScore.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Match Date && Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Away Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Home Team";
            // 
            // cboAwayTeams
            // 
            this.cboAwayTeams.DisplayMember = "TeamName";
            this.cboAwayTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayTeams.FormattingEnabled = true;
            this.cboAwayTeams.Location = new System.Drawing.Point(219, 118);
            this.cboAwayTeams.Name = "cboAwayTeams";
            this.cboAwayTeams.Size = new System.Drawing.Size(157, 28);
            this.cboAwayTeams.TabIndex = 73;
            this.cboAwayTeams.ValueMember = "Id";
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.DisplayMember = "TeamName";
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(8, 118);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(157, 28);
            this.cboHomeTeam.TabIndex = 72;
            this.cboHomeTeam.ValueMember = "Id";
            // 
            // EditMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 297);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.btnEditMatch);
            this.Controls.Add(this.nudAwayTeamScore);
            this.Controls.Add(this.nudHomeTeamScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAwayTeams);
            this.Controls.Add(this.cboHomeTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditMatch";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.NumericUpDown nudAwayTeamScore;
        private System.Windows.Forms.NumericUpDown nudHomeTeamScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAwayTeams;
        private System.Windows.Forms.ComboBox cboHomeTeam;
    }
}