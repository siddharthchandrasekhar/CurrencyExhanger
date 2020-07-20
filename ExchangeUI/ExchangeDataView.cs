using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DataService;

namespace ExchangeUI
{
    public partial class ExchangeDataView : XtraForm
    {       
        public ExchangeDataView()
        {
            InitializeComponent();
        }

        private void GridControlDataSourceChanged(object sender, EventArgs e)
        {
            marqueeProgressBar.Visible = false;
        }

        private void SwitchToggled(object sender, EventArgs e)
        {
            if (toggleSwitch.IsOn)
            {
                gridControl.Visible = true;
                chartControl.Visible = false;
            }
            else
            {
                gridControl.Visible = false;
                chartControl.Visible = true;
            }
        }

        private void ButtonGoClick(object sender, EventArgs e)
        {
            marqueeProgressBar.Visible = true;
            var thread = new Thread(new ThreadStart(() => LoadData()));
            thread.Start();            
        }

        private void LoadData()
        {
            Task<IEnumerable<Rate>> rates = DataHanlder.GetRatesAsync(cmbCurrency.Text,
                dateEditFrom.DateTime.Date, dateEditTo.DateTime.Date);
            var records = new BindingList<Rate>(rates.Result.ToList());
            PopulateGrid(records);
            PopulateChart(records);
        }

        private void PopulateGrid(BindingList<Rate> rates)
        {
            if (gridControl.InvokeRequired)
                gridControl.Invoke(new Action(() => gridControl.DataSource = rates));
            else
                gridControl.DataSource = rates;
        }

        private void PopulateChart(BindingList<Rate> rates)
        {
            if (chartControl.InvokeRequired)
                chartControl.Invoke(new Action(() => chartControl.DataSource = rates));
            else
                chartControl.DataSource = rates;
        }
    }
}
