namespace Stock1
{
    partial class Form1
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
            dgvStock = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colBarcode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategoryId = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtId = new TextBox();
            txtBarcode = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtCategoryId = new TextBox();
            txtQty = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { colId, colBarcode, colName, colPrice, colCategoryId, colQuantity });
            dgvStock.Location = new Point(73, 23);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 72;
            dgvStock.Size = new Size(1119, 792);
            dgvStock.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 9;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 175;
            // 
            // colBarcode
            // 
            colBarcode.HeaderText = "Barcode";
            colBarcode.MinimumWidth = 9;
            colBarcode.Name = "colBarcode";
            colBarcode.ReadOnly = true;
            colBarcode.Width = 175;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 9;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 175;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 9;
            colPrice.Name = "colPrice";
            colPrice.Width = 175;
            // 
            // colCategoryId
            // 
            colCategoryId.HeaderText = "CategoryId";
            colCategoryId.MinimumWidth = 9;
            colCategoryId.Name = "colCategoryId";
            colCategoryId.ReadOnly = true;
            colCategoryId.Width = 175;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 9;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 175;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(73, 948);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(301, 74);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(483, 948);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(301, 74);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(891, 948);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(301, 74);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(73, 848);
            txtId.Name = "txtId";
            txtId.Size = new Size(115, 35);
            txtId.TabIndex = 4;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(194, 848);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(154, 35);
            txtBarcode.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(354, 848);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 35);
            txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(514, 848);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(154, 35);
            txtPrice.TabIndex = 7;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(674, 848);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(154, 35);
            txtCategoryId.TabIndex = 8;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(834, 848);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(154, 35);
            txtQty.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 1078);
            Controls.Add(txtQty);
            Controls.Add(txtCategoryId);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtBarcode);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvStock);
            Name = "Form1";
            Text = "Form1";
            Load += StockForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBarcode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategoryId;
        private DataGridViewTextBoxColumn colQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtId;
        private TextBox txtBarcode;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtCategoryId;
        private TextBox txtQty;
    }
}
