namespace AlbionDataManager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvListItems = new System.Windows.Forms.DataGridView();
            this.marketordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualitylevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enchantmentlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auctiontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListItems
            // 
            this.dgvListItems.AllowUserToAddRows = false;
            this.dgvListItems.AllowUserToDeleteRows = false;
            this.dgvListItems.AutoGenerateColumns = false;
            this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albionidDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.qualitylevelDataGridViewTextBoxColumn,
            this.enchantmentlevelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.initialamountDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.auctiontypeDataGridViewTextBoxColumn,
            this.expiresDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn});
            this.dgvListItems.DataSource = this.marketordersBindingSource;
            this.dgvListItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListItems.Location = new System.Drawing.Point(0, 59);
            this.dgvListItems.Name = "dgvListItems";
            this.dgvListItems.ReadOnly = true;
            this.dgvListItems.Size = new System.Drawing.Size(1477, 649);
            this.dgvListItems.TabIndex = 0;
            // 
            // marketordersBindingSource
            // 
            this.marketordersBindingSource.DataSource = typeof(AlbionDataManager.market_orders);
            // 
            // albionidDataGridViewTextBoxColumn
            // 
            this.albionidDataGridViewTextBoxColumn.DataPropertyName = "albion_id";
            this.albionidDataGridViewTextBoxColumn.HeaderText = "albion_id";
            this.albionidDataGridViewTextBoxColumn.Name = "albionidDataGridViewTextBoxColumn";
            this.albionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualitylevelDataGridViewTextBoxColumn
            // 
            this.qualitylevelDataGridViewTextBoxColumn.DataPropertyName = "quality_level";
            this.qualitylevelDataGridViewTextBoxColumn.HeaderText = "quality_level";
            this.qualitylevelDataGridViewTextBoxColumn.Name = "qualitylevelDataGridViewTextBoxColumn";
            this.qualitylevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enchantmentlevelDataGridViewTextBoxColumn
            // 
            this.enchantmentlevelDataGridViewTextBoxColumn.DataPropertyName = "enchantment_level";
            this.enchantmentlevelDataGridViewTextBoxColumn.HeaderText = "enchantment_level";
            this.enchantmentlevelDataGridViewTextBoxColumn.Name = "enchantmentlevelDataGridViewTextBoxColumn";
            this.enchantmentlevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialamountDataGridViewTextBoxColumn
            // 
            this.initialamountDataGridViewTextBoxColumn.DataPropertyName = "initial_amount";
            this.initialamountDataGridViewTextBoxColumn.HeaderText = "initial_amount";
            this.initialamountDataGridViewTextBoxColumn.Name = "initialamountDataGridViewTextBoxColumn";
            this.initialamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auctiontypeDataGridViewTextBoxColumn
            // 
            this.auctiontypeDataGridViewTextBoxColumn.DataPropertyName = "auction_type";
            this.auctiontypeDataGridViewTextBoxColumn.HeaderText = "auction_type";
            this.auctiontypeDataGridViewTextBoxColumn.Name = "auctiontypeDataGridViewTextBoxColumn";
            this.auctiontypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiresDataGridViewTextBoxColumn
            // 
            this.expiresDataGridViewTextBoxColumn.DataPropertyName = "expires";
            this.expiresDataGridViewTextBoxColumn.HeaderText = "expires";
            this.expiresDataGridViewTextBoxColumn.Name = "expiresDataGridViewTextBoxColumn";
            this.expiresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deletedatDataGridViewTextBoxColumn
            // 
            this.deletedatDataGridViewTextBoxColumn.DataPropertyName = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.HeaderText = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.Name = "deletedatDataGridViewTextBoxColumn";
            this.deletedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 708);
            this.Controls.Add(this.dgvListItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn albionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualitylevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enchantmentlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctiontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource marketordersBindingSource;
    }
}

