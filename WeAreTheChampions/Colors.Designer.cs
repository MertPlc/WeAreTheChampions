
namespace WeAreTheChampions
{
    partial class Colors
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
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbBackgroundColor = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.gbBackgroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Location = new System.Drawing.Point(12, 21);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(364, 327);
            this.dgvColors.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.Location = new System.Drawing.Point(12, 363);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(211, 363);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 45);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbBackgroundColor
            // 
            this.gbBackgroundColor.Controls.Add(this.lblBlue);
            this.gbBackgroundColor.Controls.Add(this.lblGreen);
            this.gbBackgroundColor.Controls.Add(this.lblRed);
            this.gbBackgroundColor.Controls.Add(this.btnAdd);
            this.gbBackgroundColor.Controls.Add(this.label4);
            this.gbBackgroundColor.Controls.Add(this.label3);
            this.gbBackgroundColor.Controls.Add(this.label2);
            this.gbBackgroundColor.Controls.Add(this.hsbBlue);
            this.gbBackgroundColor.Controls.Add(this.hsbGreen);
            this.gbBackgroundColor.Controls.Add(this.hsbRed);
            this.gbBackgroundColor.Controls.Add(this.txtColorName);
            this.gbBackgroundColor.Controls.Add(this.label1);
            this.gbBackgroundColor.Location = new System.Drawing.Point(415, 12);
            this.gbBackgroundColor.Name = "gbBackgroundColor";
            this.gbBackgroundColor.Size = new System.Drawing.Size(324, 402);
            this.gbBackgroundColor.TabIndex = 5;
            this.gbBackgroundColor.TabStop = false;
            this.gbBackgroundColor.Text = "New Colors";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(282, 258);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(36, 20);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "000";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(282, 212);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 20);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "000";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRed.Location = new System.Drawing.Point(282, 168);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(36, 20);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "000";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(74, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(7, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "R";
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(46, 258);
            this.hsbBlue.Maximum = 264;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(233, 23);
            this.hsbBlue.TabIndex = 2;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbBlue_Scroll);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(46, 212);
            this.hsbGreen.Maximum = 264;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(233, 23);
            this.hsbGreen.TabIndex = 2;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbGreen_Scroll);
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(46, 168);
            this.hsbRed.Maximum = 264;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(233, 23);
            this.hsbRed.TabIndex = 2;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(10, 59);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(308, 26);
            this.txtColorName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Name";
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 427);
            this.Controls.Add(this.gbBackgroundColor);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvColors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Colors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.gbBackgroundColor.ResumeLayout(false);
            this.gbBackgroundColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbBackgroundColor;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label1;
    }
}