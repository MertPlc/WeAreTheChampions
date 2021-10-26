
namespace WeAreTheChampions
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.MatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTeams,
            this.tsmiColors,
            this.tsmiPlayers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(912, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTeams
            // 
            this.tsmiTeams.Name = "tsmiTeams";
            this.tsmiTeams.Size = new System.Drawing.Size(65, 25);
            this.tsmiTeams.Text = "Teams";
            this.tsmiTeams.Click += new System.EventHandler(this.tsmiTeams_Click);
            // 
            // tsmiColors
            // 
            this.tsmiColors.Name = "tsmiColors";
            this.tsmiColors.Size = new System.Drawing.Size(67, 25);
            this.tsmiColors.Text = "Colors";
            this.tsmiColors.Click += new System.EventHandler(this.tsmiColors_Click);
            // 
            // tsmiPlayers
            // 
            this.tsmiPlayers.Name = "tsmiPlayers";
            this.tsmiPlayers.Size = new System.Drawing.Size(72, 25);
            this.tsmiPlayers.Text = "Players";
            this.tsmiPlayers.Click += new System.EventHandler(this.tsmiPlayers_Click);
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMatch.BackColor = System.Drawing.Color.Green;
            this.btnNewMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewMatch.Location = new System.Drawing.Point(13, 466);
            this.btnNewMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(216, 57);
            this.btnNewMatch.TabIndex = 1;
            this.btnNewMatch.Text = "+ New Match";
            this.btnNewMatch.UseVisualStyleBackColor = false;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.AllowUserToDeleteRows = false;
            this.dgvScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvScore.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatchId,
            this.Team1,
            this.Team2,
            this.Date,
            this.Time,
            this.Result});
            this.dgvScore.Location = new System.Drawing.Point(13, 36);
            this.dgvScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvScore.MultiSelect = false;
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            this.dgvScore.RowHeadersVisible = false;
            this.dgvScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScore.Size = new System.Drawing.Size(884, 420);
            this.dgvScore.TabIndex = 2;
            // 
            // MatchId
            // 
            this.MatchId.DataPropertyName = "MatchId";
            this.MatchId.HeaderText = "MatchId";
            this.MatchId.Name = "MatchId";
            this.MatchId.ReadOnly = true;
            // 
            // Team1
            // 
            this.Team1.DataPropertyName = "Team1";
            this.Team1.HeaderText = "Team1";
            this.Team1.Name = "Team1";
            this.Team1.ReadOnly = true;
            // 
            // Team2
            // 
            this.Team2.DataPropertyName = "Team2";
            this.Team2.HeaderText = "Team2";
            this.Team2.Name = "Team2";
            this.Team2.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Score";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(555, 466);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.Location = new System.Drawing.Point(730, 466);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 57);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 535);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvScore);
            this.Controls.Add(this.btnNewMatch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeams;
        private System.Windows.Forms.ToolStripMenuItem tsmiColors;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayers;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}