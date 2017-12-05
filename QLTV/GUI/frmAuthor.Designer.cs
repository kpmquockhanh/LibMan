namespace GUI
{
    partial class frmAuthor
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
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.author_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(136, 97);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(146, 20);
            this.txtAuthorID.TabIndex = 0;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(136, 155);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(146, 20);
            this.txtAuthorName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả:";
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.author_id,
            this.author_name});
            this.dgvAuthor.Location = new System.Drawing.Point(4, 286);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.Size = new System.Drawing.Size(395, 150);
            this.dgvAuthor.TabIndex = 2;
            // 
            // author_id
            // 
            this.author_id.DataPropertyName = "author_id";
            this.author_id.HeaderText = "Mã tác giả";
            this.author_id.Name = "author_id";
            // 
            // author_name
            // 
            this.author_name.DataPropertyName = "author_name";
            this.author_name.HeaderText = "Tên giác giả";
            this.author_name.Name = "author_name";
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.dgvAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtAuthorID);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            this.Load += new System.EventHandler(this.frmAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_name;
    }
}