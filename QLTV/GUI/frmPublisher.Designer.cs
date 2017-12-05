namespace GUI
{
    partial class frmPublisher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublisherID = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            this.publisher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà xuất bản: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà xuất bản: ";
            // 
            // txtPublisherID
            // 
            this.txtPublisherID.Location = new System.Drawing.Point(175, 61);
            this.txtPublisherID.Name = "txtPublisherID";
            this.txtPublisherID.Size = new System.Drawing.Size(129, 20);
            this.txtPublisherID.TabIndex = 2;
            this.txtPublisherID.TextChanged += new System.EventHandler(this.txtPublisherID_TextChanged);
            this.txtPublisherID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisherID_KeyPress);
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(175, 112);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(129, 20);
            this.txtPublisherName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(175, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisher_id,
            this.publisher_name,
            this.publisher_address});
            this.dgvPublisher.Location = new System.Drawing.Point(0, 361);
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.Size = new System.Drawing.Size(371, 150);
            this.dgvPublisher.TabIndex = 3;
            this.dgvPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublisher_CellClick);
            // 
            // publisher_id
            // 
            this.publisher_id.DataPropertyName = "publisher_id";
            this.publisher_id.HeaderText = "Mã nhà xuất bản";
            this.publisher_id.Name = "publisher_id";
            // 
            // publisher_name
            // 
            this.publisher_name.DataPropertyName = "publisher_name";
            this.publisher_name.HeaderText = "Tên nhà xuất bản";
            this.publisher_name.Name = "publisher_name";
            // 
            // publisher_address
            // 
            this.publisher_address.DataPropertyName = "publisher_address";
            this.publisher_address.HeaderText = "Địa chỉ";
            this.publisher_address.Name = "publisher_address";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(470, 132);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(470, 191);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 23);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "Tìm";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(470, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(470, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 536);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPublisher);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPublisherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPublisherID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPublisher";
            this.Text = "frmPublisher";
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublisherID;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgvPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_address;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}