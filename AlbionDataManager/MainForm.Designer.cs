namespace AlbionDataManager
{
    partial class MainForm
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
            this.marketstatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricemaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceavgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketstatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListItems
            // 
            this.dgvListItems.AllowUserToAddRows = false;
            this.dgvListItems.AllowUserToDeleteRows = false;
            this.dgvListItems.AutoGenerateColumns = false;
            this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.priceminDataGridViewTextBoxColumn,
            this.pricemaxDataGridViewTextBoxColumn,
            this.priceavgDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.dgvListItems.DataSource = this.marketstatsBindingSource;
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
            // marketstatsBindingSource
            // 
            this.marketstatsBindingSource.DataSource = typeof(AlbionDataManager.market_stats);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceminDataGridViewTextBoxColumn
            // 
            this.priceminDataGridViewTextBoxColumn.DataPropertyName = "price_min";
            this.priceminDataGridViewTextBoxColumn.HeaderText = "price_min";
            this.priceminDataGridViewTextBoxColumn.Name = "priceminDataGridViewTextBoxColumn";
            this.priceminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricemaxDataGridViewTextBoxColumn
            // 
            this.pricemaxDataGridViewTextBoxColumn.DataPropertyName = "price_max";
            this.pricemaxDataGridViewTextBoxColumn.HeaderText = "price_max";
            this.pricemaxDataGridViewTextBoxColumn.Name = "pricemaxDataGridViewTextBoxColumn";
            this.pricemaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceavgDataGridViewTextBoxColumn
            // 
            this.priceavgDataGridViewTextBoxColumn.DataPropertyName = "price_avg";
            this.priceavgDataGridViewTextBoxColumn.HeaderText = "price_avg";
            this.priceavgDataGridViewTextBoxColumn.Name = "priceavgDataGridViewTextBoxColumn";
            this.priceavgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 708);
            this.Controls.Add(this.dgvListItems);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketstatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListItems;
        private System.Windows.Forms.BindingSource marketordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricemaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceavgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource marketstatsBindingSource;
    }
}

