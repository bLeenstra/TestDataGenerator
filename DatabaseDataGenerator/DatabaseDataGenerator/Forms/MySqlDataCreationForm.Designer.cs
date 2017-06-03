namespace DatabaseDataGenerator.Forms
{
    partial class MySqlDataCreationForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemGenerate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClear = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemUneditable = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnCurrentRows = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowsToAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemEditableRowCount = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUneditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditableRowCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemGenerate,
            this.barButtonItemClear,
            this.barButtonItemClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(579, 79);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItemGenerate
            // 
            this.barButtonItemGenerate.Caption = "Generate Data";
            this.barButtonItemGenerate.Id = 2;
            this.barButtonItemGenerate.ImageOptions.Image = global::DatabaseDataGenerator.Properties.Resources.editdatasource_16x16;
            this.barButtonItemGenerate.ImageOptions.LargeImage = global::DatabaseDataGenerator.Properties.Resources.editdatasource_32x32;
            this.barButtonItemGenerate.Name = "barButtonItemGenerate";
            this.barButtonItemGenerate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGenerate_ItemClick);
            // 
            // barButtonItemClear
            // 
            this.barButtonItemClear.Caption = "Clear Values";
            this.barButtonItemClear.Id = 3;
            this.barButtonItemClear.ImageOptions.Image = global::DatabaseDataGenerator.Properties.Resources.clear_16x16;
            this.barButtonItemClear.ImageOptions.LargeImage = global::DatabaseDataGenerator.Properties.Resources.clear_32x32;
            this.barButtonItemClear.Name = "barButtonItemClear";
            this.barButtonItemClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClear_ItemClick);
            // 
            // barButtonItemClose
            // 
            this.barButtonItemClose.Caption = "Close";
            this.barButtonItemClose.Id = 4;
            this.barButtonItemClose.ImageOptions.Image = global::DatabaseDataGenerator.Properties.Resources.cancel_16x16;
            this.barButtonItemClose.Name = "barButtonItemClose";
            this.barButtonItemClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemGenerate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemClear);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 352);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(579, 31);
            // 
            // gridControlData
            // 
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.Location = new System.Drawing.Point(0, 79);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.MenuManager = this.ribbon;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemEditableRowCount,
            this.repositoryItemUneditable});
            this.gridControlData.Size = new System.Drawing.Size(579, 273);
            this.gridControlData.TabIndex = 2;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTableName,
            this.gridColumnCurrentRows,
            this.gridColumnRowsToAdd});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewData.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnTableName
            // 
            this.gridColumnTableName.Caption = "Table Name";
            this.gridColumnTableName.ColumnEdit = this.repositoryItemUneditable;
            this.gridColumnTableName.FieldName = "TABLE_NAME";
            this.gridColumnTableName.Name = "gridColumnTableName";
            this.gridColumnTableName.Visible = true;
            this.gridColumnTableName.VisibleIndex = 0;
            // 
            // repositoryItemUneditable
            // 
            this.repositoryItemUneditable.AutoHeight = false;
            this.repositoryItemUneditable.Name = "repositoryItemUneditable";
            this.repositoryItemUneditable.ReadOnly = true;
            // 
            // gridColumnCurrentRows
            // 
            this.gridColumnCurrentRows.Caption = "Current Rows";
            this.gridColumnCurrentRows.ColumnEdit = this.repositoryItemUneditable;
            this.gridColumnCurrentRows.FieldName = "TABLE_ROWS";
            this.gridColumnCurrentRows.Name = "gridColumnCurrentRows";
            this.gridColumnCurrentRows.Visible = true;
            this.gridColumnCurrentRows.VisibleIndex = 1;
            // 
            // gridColumnRowsToAdd
            // 
            this.gridColumnRowsToAdd.Caption = "RowsToAdd";
            this.gridColumnRowsToAdd.ColumnEdit = this.repositoryItemEditableRowCount;
            this.gridColumnRowsToAdd.FieldName = "Rows To Add";
            this.gridColumnRowsToAdd.Name = "gridColumnRowsToAdd";
            this.gridColumnRowsToAdd.Visible = true;
            this.gridColumnRowsToAdd.VisibleIndex = 2;
            // 
            // repositoryItemEditableRowCount
            // 
            this.repositoryItemEditableRowCount.Appearance.Options.UseTextOptions = true;
            this.repositoryItemEditableRowCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemEditableRowCount.AutoHeight = false;
            this.repositoryItemEditableRowCount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemEditableRowCount.Mask.EditMask = "f0";
            this.repositoryItemEditableRowCount.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemEditableRowCount.Name = "repositoryItemEditableRowCount";
            // 
            // MySqlDataCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 383);
            this.Controls.Add(this.gridControlData);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MySqlDataCreationForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Generate MySQL Test Data";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemUneditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemEditableRowCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGenerate;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClear;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTableName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCurrentRows;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowsToAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemEditableRowCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemUneditable;
    }
}