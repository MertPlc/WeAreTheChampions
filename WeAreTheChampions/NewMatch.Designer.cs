
namespace WeAreTheChampions
{
    partial class New_Match
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
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.cboAwayTeams = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHomeTeamScore = new System.Windows.Forms.NumericUpDown();
            this.nudAwayTeamScore = new System.Windows.Forms.NumericUpDown();
            this.btnAddMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(12, 106);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(157, 28);
            this.cboHomeTeam.TabIndex = 0;
            // 
            // cboAwayTeams
            // 
            this.cboAwayTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayTeams.FormattingEnabled = true;
            this.cboAwayTeams.Location = new System.Drawing.Point(476, 106);
            this.cboAwayTeams.Name = "cboAwayTeams";
            this.cboAwayTeams.Size = new System.Drawing.Size(157, 28);
            this.cboAwayTeams.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "ddMMMMyyyy | hh:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(215, 65);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(222, 26);
            this.dtpDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Away Teams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match Day and Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score";
            // 
            // nudHomeTeamScore
            // 
            this.nudHomeTeamScore.Location = new System.Drawing.Point(215, 137);
            this.nudHomeTeamScore.Name = "nudHomeTeamScore";
            this.nudHomeTeamScore.Size = new System.Drawing.Size(56, 26);
            this.nudHomeTeamScore.TabIndex = 7;
            // 
            // nudAwayTeamScore
            // 
            this.nudAwayTeamScore.Location = new System.Drawing.Point(381, 137);
            this.nudAwayTeamScore.Name = "nudAwayTeamScore";
            this.nudAwayTeamScore.Size = new System.Drawing.Size(56, 26);
            this.nudAwayTeamScore.TabIndex = 8;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(215, 232);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(222, 62);
            this.btnAddMatch.TabIndex = 9;
            this.btnAddMatch.Text = "Match Add";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            // 
            // New_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 337);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.nudAwayTeamScore);
            this.Controls.Add(this.nudHomeTeamScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboAwayTeams);
            this.Controls.Add(this.cboHomeTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Match";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Match";
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.ComboBox cboAwayTeams;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHomeTeamScore;
        private System.Windows.Forms.NumericUpDown nudAwayTeamScore;
        private System.Windows.Forms.Button btnAddMatch;
    }
}