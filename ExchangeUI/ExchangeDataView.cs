using DataService;
using DevExpress.XtraLayout.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeUI
{
    public partial class ExchangeDataView : DevExpress.XtraEditors.XtraForm
    {
        public ExchangeDataView()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<Rate> rates = DataAccess.GetRatesAsync(cmbCurrency.Text,
                dateEditFrom.DateTime.Date, dateEditTo.DateTime.Date);
            var records = new BindingList<Rate>(rates);
            gridControl.DataSource = records;            
        }
    }
}
