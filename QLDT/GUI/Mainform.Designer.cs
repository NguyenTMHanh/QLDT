namespace QLDT.GUI
{
    partial class Mainform
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
            this.dtgvDT = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bttSort = new System.Windows.Forms.Button();
            this.bttSearch = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.cbbSeach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCDT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDT
            // 
            this.dtgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDT.Location = new System.Drawing.Point(28, 137);
            this.dtgvDT.Name = "dtgvDT";
            this.dtgvDT.ReadOnly = true;
            this.dtgvDT.RowHeadersWidth = 62;
            this.dtgvDT.RowTemplate.Height = 28;
            this.dtgvDT.Size = new System.Drawing.Size(943, 230);
            this.dtgvDT.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(653, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 26);
            this.txtSearch.TabIndex = 16;
            // 
            // bttSort
            // 
            this.bttSort.Location = new System.Drawing.Point(129, 425);
            this.bttSort.Name = "bttSort";
            this.bttSort.Size = new System.Drawing.Size(75, 37);
            this.bttSort.TabIndex = 15;
            this.bttSort.Text = "Sort";
            this.bttSort.UseVisualStyleBackColor = true;
            this.bttSort.Click += new System.EventHandler(this.bttSort_Click);
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(653, 34);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 34);
            this.bttSearch.TabIndex = 14;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(745, 425);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 34);
            this.bttDelete.TabIndex = 13;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.Location = new System.Drawing.Point(521, 425);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(75, 34);
            this.bttUpdate.TabIndex = 12;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = true;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(318, 428);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 34);
            this.bttAdd.TabIndex = 11;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // cbbSeach
            // 
            this.cbbSeach.FormattingEnabled = true;
            this.cbbSeach.Location = new System.Drawing.Point(762, 40);
            this.cbbSeach.Name = "cbbSeach";
            this.cbbSeach.Size = new System.Drawing.Size(121, 28);
            this.cbbSeach.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cấp đề tài";
            // 
            // cbbCDT
            // 
            this.cbbCDT.FormattingEnabled = true;
            this.cbbCDT.Location = new System.Drawing.Point(229, 45);
            this.cbbCDT.Name = "cbbCDT";
            this.cbbCDT.Size = new System.Drawing.Size(121, 28);
            this.cbbCDT.TabIndex = 20;
            this.cbbCDT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 602);
            this.Controls.Add(this.cbbCDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSeach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bttSort);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dtgvDT);
            this.Name = "Mainform";
            this.Text = "Mainform";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDT;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bttSort;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.ComboBox cbbSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCDT;
    }
}