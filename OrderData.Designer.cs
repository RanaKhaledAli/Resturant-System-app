namespace RESTAURANT_PROJECT
{
    partial class OrderData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderData));
            this.restaurantDataSet = new RESTAURANT_PROJECT.RestaurantDataSet();
            this.the_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_orderTableAdapter = new RESTAURANT_PROJECT.RestaurantDataSetTableAdapters.the_orderTableAdapter();
            this.tableAdapterManager = new RESTAURANT_PROJECT.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.the_orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.the_orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.restaurantDataSet2 = new RESTAURANT_PROJECT.RestaurantDataSet2();
            this.the_orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.the_orderTableAdapter1 = new RESTAURANT_PROJECT.RestaurantDataSet2TableAdapters.the_orderTableAdapter();
            this.tableAdapterManager1 = new RESTAURANT_PROJECT.RestaurantDataSet2TableAdapters.TableAdapterManager();
            this.the_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingNavigator)).BeginInit();
            this.the_orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // the_orderBindingSource
            // 
            this.the_orderBindingSource.DataMember = "the_order";
            this.the_orderBindingSource.DataSource = this.restaurantDataSet;
            // 
            // the_orderTableAdapter
            // 
            this.the_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.the_orderTableAdapter = this.the_orderTableAdapter;
            this.tableAdapterManager.UpdateOrder = RESTAURANT_PROJECT.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // the_orderBindingNavigator
            // 
            this.the_orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.the_orderBindingNavigator.BindingSource = this.the_orderBindingSource;
            this.the_orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.the_orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.the_orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.the_orderBindingNavigatorSaveItem});
            this.the_orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.the_orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.the_orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.the_orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.the_orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.the_orderBindingNavigator.Name = "the_orderBindingNavigator";
            this.the_orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.the_orderBindingNavigator.Size = new System.Drawing.Size(609, 25);
            this.the_orderBindingNavigator.TabIndex = 0;
            this.the_orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // the_orderBindingNavigatorSaveItem
            // 
            this.the_orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.the_orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("the_orderBindingNavigatorSaveItem.Image")));
            this.the_orderBindingNavigatorSaveItem.Name = "the_orderBindingNavigatorSaveItem";
            this.the_orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.the_orderBindingNavigatorSaveItem.Text = "Save Data";
            this.the_orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.the_orderBindingNavigatorSaveItem_Click);
            // 
            // restaurantDataSet2
            // 
            this.restaurantDataSet2.DataSetName = "RestaurantDataSet2";
            this.restaurantDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // the_orderBindingSource1
            // 
            this.the_orderBindingSource1.DataMember = "the_order";
            this.the_orderBindingSource1.DataSource = this.restaurantDataSet2;
            // 
            // the_orderTableAdapter1
            // 
            this.the_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.the_orderTableAdapter = this.the_orderTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = RESTAURANT_PROJECT.RestaurantDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // the_orderDataGridView
            // 
            this.the_orderDataGridView.AutoGenerateColumns = false;
            this.the_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.the_orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.the_orderDataGridView.DataSource = this.the_orderBindingSource1;
            this.the_orderDataGridView.Location = new System.Drawing.Point(135, 59);
            this.the_orderDataGridView.Name = "the_orderDataGridView";
            this.the_orderDataGridView.Size = new System.Drawing.Size(345, 231);
            this.the_orderDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn1.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn2.HeaderText = "price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "D_ate";
            this.dataGridViewTextBoxColumn3.HeaderText = "D_ate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // OrderData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(609, 346);
            this.Controls.Add(this.the_orderDataGridView);
            this.Controls.Add(this.the_orderBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderData";
            this.Text = "OrderData";
            this.Load += new System.EventHandler(this.OrderData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingNavigator)).EndInit();
            this.the_orderBindingNavigator.ResumeLayout(false);
            this.the_orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource the_orderBindingSource;
        private RestaurantDataSetTableAdapters.the_orderTableAdapter the_orderTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator the_orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton the_orderBindingNavigatorSaveItem;
        private RestaurantDataSet2 restaurantDataSet2;
        private System.Windows.Forms.BindingSource the_orderBindingSource1;
        private RestaurantDataSet2TableAdapters.the_orderTableAdapter the_orderTableAdapter1;
        private RestaurantDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView the_orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}