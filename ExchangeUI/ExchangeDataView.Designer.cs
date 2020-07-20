namespace ExchangeUI
{
    partial class ExchangeDataView
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StepLineSeriesView stepLineSeriesView1 = new DevExpress.XtraCharts.StepLineSeriesView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateEditTo = new DevExpress.XtraEditors.DateEdit();
            this.cmbCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnGo = new DevExpress.XtraEditors.SimpleButton();
            this.marqueeProgressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.toggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(12, 38);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(869, 613);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.DataSourceChanged += new System.EventHandler(this.GridControlDataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.EditValue = new System.DateTime(2020, 7, 18, 21, 55, 22, 0);
            this.dateEditFrom.Location = new System.Drawing.Point(12, 12);
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditFrom.Size = new System.Drawing.Size(100, 20);
            this.dateEditFrom.TabIndex = 1;
            // 
            // dateEditTo
            // 
            this.dateEditTo.EditValue = new System.DateTime(2020, 7, 18, 21, 55, 29, 0);
            this.dateEditTo.Location = new System.Drawing.Point(129, 12);
            this.dateEditTo.Name = "dateEditTo";
            this.dateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditTo.Size = new System.Drawing.Size(100, 20);
            this.dateEditTo.TabIndex = 2;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.EditValue = "USD";
            this.cmbCurrency.Location = new System.Drawing.Point(246, 12);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCurrency.Properties.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.cmbCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCurrency.Size = new System.Drawing.Size(100, 20);
            this.cmbCurrency.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(364, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 20);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.ButtonGoClick);
            // 
            // marqueeProgressBar
            // 
            this.marqueeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueeProgressBar.EditValue = 0;
            this.marqueeProgressBar.Location = new System.Drawing.Point(555, 12);
            this.marqueeProgressBar.Name = "marqueeProgressBar";
            this.marqueeProgressBar.Size = new System.Drawing.Size(326, 20);
            this.marqueeProgressBar.TabIndex = 5;
            this.marqueeProgressBar.Visible = false;
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.EditValue = true;
            this.toggleSwitch.Location = new System.Drawing.Point(454, 13);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Properties.OffText = "Chart";
            this.toggleSwitch.Properties.OnText = "Data";
            this.toggleSwitch.Size = new System.Drawing.Size(95, 18);
            this.toggleSwitch.TabIndex = 7;
            this.toggleSwitch.Toggled += new System.EventHandler(this.SwitchToggled);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(12, 38);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesDataMember = "EffectiveDate";
            series1.Name = "Exchange History";
            series1.View = stepLineSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.ArgumentDataMember = "EffectiveDate";
            this.chartControl.SeriesTemplate.SeriesDataMember = "EffectiveDate";
            this.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Mid";
            this.chartControl.Size = new System.Drawing.Size(869, 613);
            this.chartControl.TabIndex = 8;
            this.chartControl.Visible = false;
            // 
            // ExchangeDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 663);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.toggleSwitch);
            this.Controls.Add(this.marqueeProgressBar);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.dateEditTo);
            this.Controls.Add(this.dateEditFrom);
            this.Controls.Add(this.gridControl);
            this.Name = "ExchangeDataView";
            this.Text = "Exchange Rates - Polish Zloty";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.DateEdit dateEditTo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCurrency;
        private DevExpress.XtraEditors.SimpleButton btnGo;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBar;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private DevExpress.XtraCharts.ChartControl chartControl;
    }
}

