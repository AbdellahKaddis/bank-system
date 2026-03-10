using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BANK_Bussiness;
using BANK_DataAccess;

namespace BANK.Currency
{
    public partial class frmCuuencyTransfer : Form
    {
        public frmCuuencyTransfer()
        {
            InitializeComponent();
        }
        private Dictionary<string, double> _Currencies;
        private async void _FillCb()
        {
            cbTo.Items.Clear();
            cbFrom.Items.Clear();
            string url = "https://openexchangerates.org/api/latest.json?app_id=222ea764d233421dbadfcce12ddaab66";
            try
            {
                using (var client = new WebClient())
                {
                    string json =await client.DownloadStringTaskAsync(url);
                    dynamic data = JObject.Parse(json);


                    //CONVERT FROM JSON OBJECT TO DICTIONARY
                    _Currencies = JsonConvert.DeserializeObject<Dictionary<string, double>>(data.rates.ToString());
                    foreach (var pair in _Currencies)
                    {
                        cbFrom.Items.Add(pair.Key);
                        cbTo.Items.Add(pair.Key);
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }

            cbFrom.Text = "USD";
            cbTo.Text = "MAD";
        }

        private double GetExchangeRate(string baseCurrency, string targetCurrency)
        {
            string url = $"https://open.er-api.com/v6/latest/{baseCurrency}";

            try
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    dynamic data = JObject.Parse(json);

                    double rate = data.rates[targetCurrency];
                    return rate;
                }
            }
            catch (WebException ex)
            {
                // Handle web exceptions (e.g., no internet connection, API down)
                clsLogger.WriteLog("Error: " + ex.Message);
                return -1; // Or throw an exception
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                clsLogger.WriteLog("Error: " + ex.Message);
                return -1; // Or throw an exception
            }
        }

        private  void frmCuuencyTransfer_Load(object sender, EventArgs e)
        {
             _FillCb();
        }
        private double _Result;
        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
             _Result = GetExchangeRate(cbFrom.Text, cbTo.Text);
        }

        private void btnConvert_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Enter an amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_Result != -1)
            {
                lblBaseCurrency.Text = txtAmount.Text + "  " + cbFrom.Text + " =";
                lblResult.Text = (_Result * Convert.ToDouble(txtAmount.Text)).ToString() +"  "+cbTo.Text;
            }
            else
            {
                MessageBox.Show("api error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Result = GetExchangeRate(cbFrom.Text, cbTo.Text);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
