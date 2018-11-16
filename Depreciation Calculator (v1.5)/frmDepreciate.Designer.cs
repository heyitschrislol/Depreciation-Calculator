namespace Depreciation_Calculator__v1._5_
{
	partial class frmDepreciate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciate));
			this.btnSaveToFile = new System.Windows.Forms.Button();
			this.btnDDDE = new System.Windows.Forms.Button();
			this.lblRoDLabel = new System.Windows.Forms.Label();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSLDE = new System.Windows.Forms.Button();
			this.lblLifeLabel = new System.Windows.Forms.Label();
			this.lblSvgLabel = new System.Windows.Forms.Label();
			this.lblCostLabel = new System.Windows.Forms.Label();
			this.txtLife = new System.Windows.Forms.TextBox();
			this.txtSvg = new System.Windows.Forms.TextBox();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.dBDepreciationDataSet = new Depreciation_Calculator__v1._5_.DBDepreciationDataSet();
			this.depreciationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.depreciationTableAdapter = new Depreciation_Calculator__v1._5_.DBDepreciationDataSetTableAdapters.DepreciationTableAdapter();
			this.tableAdapterManager = new Depreciation_Calculator__v1._5_.DBDepreciationDataSetTableAdapters.TableAdapterManager();
			this.depreciationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.depreciationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.depreciationDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dBDepreciationDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.depreciationBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.depreciationBindingNavigator)).BeginInit();
			this.depreciationBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.depreciationDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSaveToFile
			// 
			this.btnSaveToFile.Location = new System.Drawing.Point(563, 195);
			this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(2);
			this.btnSaveToFile.Name = "btnSaveToFile";
			this.btnSaveToFile.Size = new System.Drawing.Size(73, 19);
			this.btnSaveToFile.TabIndex = 41;
			this.btnSaveToFile.Text = "Save to File";
			this.btnSaveToFile.UseVisualStyleBackColor = true;
			this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
			// 
			// btnDDDE
			// 
			this.btnDDDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btnDDDE.Location = new System.Drawing.Point(370, 149);
			this.btnDDDE.Margin = new System.Windows.Forms.Padding(2);
			this.btnDDDE.Name = "btnDDDE";
			this.btnDDDE.Size = new System.Drawing.Size(125, 23);
			this.btnDDDE.TabIndex = 40;
			this.btnDDDE.Text = "Get Double Declining";
			this.btnDDDE.UseVisualStyleBackColor = true;
			this.btnDDDE.Click += new System.EventHandler(this.btnDDDE_Click);
			// 
			// lblRoDLabel
			// 
			this.lblRoDLabel.AutoSize = true;
			this.lblRoDLabel.Location = new System.Drawing.Point(388, 59);
			this.lblRoDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRoDLabel.Name = "lblRoDLabel";
			this.lblRoDLabel.Size = new System.Drawing.Size(108, 13);
			this.lblRoDLabel.TabIndex = 39;
			this.lblRoDLabel.Text = "Rate of Depreciation:";
			// 
			// txtRate
			// 
			this.txtRate.Location = new System.Drawing.Point(499, 57);
			this.txtRate.Margin = new System.Windows.Forms.Padding(2);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(68, 20);
			this.txtRate.TabIndex = 38;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(399, 176);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(67, 27);
			this.btnExit.TabIndex = 37;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(257, 176);
			this.btnReset.Margin = new System.Windows.Forms.Padding(2);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(67, 27);
			this.btnReset.TabIndex = 36;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSLDE
			// 
			this.btnSLDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btnSLDE.Location = new System.Drawing.Point(227, 149);
			this.btnSLDE.Margin = new System.Windows.Forms.Padding(2);
			this.btnSLDE.Name = "btnSLDE";
			this.btnSLDE.Size = new System.Drawing.Size(125, 23);
			this.btnSLDE.TabIndex = 35;
			this.btnSLDE.Text = "Get Straight Line";
			this.btnSLDE.UseVisualStyleBackColor = true;
			this.btnSLDE.Click += new System.EventHandler(this.btnSLDE_Click);
			// 
			// lblLifeLabel
			// 
			this.lblLifeLabel.AutoSize = true;
			this.lblLifeLabel.Location = new System.Drawing.Point(197, 101);
			this.lblLifeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLifeLabel.Name = "lblLifeLabel";
			this.lblLifeLabel.Size = new System.Drawing.Size(75, 13);
			this.lblLifeLabel.TabIndex = 34;
			this.lblLifeLabel.Text = "Use Life (Life):";
			// 
			// lblSvgLabel
			// 
			this.lblSvgLabel.AutoSize = true;
			this.lblSvgLabel.Location = new System.Drawing.Point(197, 79);
			this.lblSvgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSvgLabel.Name = "lblSvgLabel";
			this.lblSvgLabel.Size = new System.Drawing.Size(77, 13);
			this.lblSvgLabel.TabIndex = 33;
			this.lblSvgLabel.Text = "Salvage (Svg):";
			// 
			// lblCostLabel
			// 
			this.lblCostLabel.AutoSize = true;
			this.lblCostLabel.Location = new System.Drawing.Point(224, 59);
			this.lblCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCostLabel.Name = "lblCostLabel";
			this.lblCostLabel.Size = new System.Drawing.Size(47, 13);
			this.lblCostLabel.TabIndex = 32;
			this.lblCostLabel.Text = "Cost (C):";
			// 
			// txtLife
			// 
			this.txtLife.Location = new System.Drawing.Point(275, 100);
			this.txtLife.Margin = new System.Windows.Forms.Padding(2);
			this.txtLife.Name = "txtLife";
			this.txtLife.Size = new System.Drawing.Size(68, 20);
			this.txtLife.TabIndex = 31;
			// 
			// txtSvg
			// 
			this.txtSvg.Location = new System.Drawing.Point(275, 77);
			this.txtSvg.Margin = new System.Windows.Forms.Padding(2);
			this.txtSvg.Name = "txtSvg";
			this.txtSvg.Size = new System.Drawing.Size(68, 20);
			this.txtSvg.TabIndex = 30;
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(275, 57);
			this.txtCost.Margin = new System.Windows.Forms.Padding(2);
			this.txtCost.Name = "txtCost";
			this.txtCost.Size = new System.Drawing.Size(68, 20);
			this.txtCost.TabIndex = 29;
			// 
			// dBDepreciationDataSet
			// 
			this.dBDepreciationDataSet.DataSetName = "DBDepreciationDataSet";
			this.dBDepreciationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// depreciationBindingSource
			// 
			this.depreciationBindingSource.DataMember = "Depreciation";
			this.depreciationBindingSource.DataSource = this.dBDepreciationDataSet;
			// 
			// depreciationTableAdapter
			// 
			this.depreciationTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DepreciationTableAdapter = this.depreciationTableAdapter;
			this.tableAdapterManager.UpdateOrder = Depreciation_Calculator__v1._5_.DBDepreciationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// depreciationBindingNavigator
			// 
			this.depreciationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.depreciationBindingNavigator.BindingSource = this.depreciationBindingSource;
			this.depreciationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.depreciationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.depreciationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.depreciationBindingNavigatorSaveItem});
			this.depreciationBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.depreciationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.depreciationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.depreciationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.depreciationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.depreciationBindingNavigator.Name = "depreciationBindingNavigator";
			this.depreciationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.depreciationBindingNavigator.Size = new System.Drawing.Size(768, 25);
			this.depreciationBindingNavigator.TabIndex = 42;
			this.depreciationBindingNavigator.Text = "bindingNavigator1";
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
			// depreciationBindingNavigatorSaveItem
			// 
			this.depreciationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.depreciationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("depreciationBindingNavigatorSaveItem.Image")));
			this.depreciationBindingNavigatorSaveItem.Name = "depreciationBindingNavigatorSaveItem";
			this.depreciationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.depreciationBindingNavigatorSaveItem.Text = "Save Data";
			this.depreciationBindingNavigatorSaveItem.Click += new System.EventHandler(this.depreciationBindingNavigatorSaveItem_Click);
			// 
			// depreciationDataGridView
			// 
			this.depreciationDataGridView.AutoGenerateColumns = false;
			this.depreciationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.depreciationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.depreciationDataGridView.DataSource = this.depreciationBindingSource;
			this.depreciationDataGridView.Location = new System.Drawing.Point(12, 235);
			this.depreciationDataGridView.Name = "depreciationDataGridView";
			this.depreciationDataGridView.Size = new System.Drawing.Size(743, 247);
			this.depreciationDataGridView.TabIndex = 42;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Year";
			this.dataGridViewTextBoxColumn1.HeaderText = "Year";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Method";
			this.dataGridViewTextBoxColumn2.HeaderText = "Method";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Cost";
			this.dataGridViewTextBoxColumn3.HeaderText = "Cost";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "RateOf";
			this.dataGridViewTextBoxColumn4.HeaderText = "RateOf";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Expense";
			this.dataGridViewTextBoxColumn5.HeaderText = "Expense";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Accumulated";
			this.dataGridViewTextBoxColumn6.HeaderText = "Accumulated";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "BookValue";
			this.dataGridViewTextBoxColumn7.HeaderText = "BookValue";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// frmDepreciate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 520);
			this.Controls.Add(this.depreciationDataGridView);
			this.Controls.Add(this.depreciationBindingNavigator);
			this.Controls.Add(this.btnSaveToFile);
			this.Controls.Add(this.btnDDDE);
			this.Controls.Add(this.lblRoDLabel);
			this.Controls.Add(this.txtRate);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnSLDE);
			this.Controls.Add(this.lblLifeLabel);
			this.Controls.Add(this.lblSvgLabel);
			this.Controls.Add(this.lblCostLabel);
			this.Controls.Add(this.txtLife);
			this.Controls.Add(this.txtSvg);
			this.Controls.Add(this.txtCost);
			this.Name = "frmDepreciate";
			this.Text = "Depreciation Calculator";
			this.Load += new System.EventHandler(this.frmDepreciate_Load);
			((System.ComponentModel.ISupportInitialize)(this.dBDepreciationDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.depreciationBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.depreciationBindingNavigator)).EndInit();
			this.depreciationBindingNavigator.ResumeLayout(false);
			this.depreciationBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.depreciationDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSaveToFile;
		private System.Windows.Forms.Button btnDDDE;
		private System.Windows.Forms.Label lblRoDLabel;
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSLDE;
		private System.Windows.Forms.Label lblLifeLabel;
		private System.Windows.Forms.Label lblSvgLabel;
		private System.Windows.Forms.Label lblCostLabel;
		private System.Windows.Forms.TextBox txtLife;
		private System.Windows.Forms.TextBox txtSvg;
		private System.Windows.Forms.TextBox txtCost;
		private DBDepreciationDataSet dBDepreciationDataSet;
		private System.Windows.Forms.BindingSource depreciationBindingSource;
		private DBDepreciationDataSetTableAdapters.DepreciationTableAdapter depreciationTableAdapter;
		private DBDepreciationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator depreciationBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton depreciationBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView depreciationDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
	}
}

