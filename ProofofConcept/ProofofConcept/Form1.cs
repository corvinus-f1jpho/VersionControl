using com.sun.xml.@internal.xsom;
using ProofofConcept.Entities;
using ProofofConcept.MNBServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace ProofofConcept
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            GetCurrencies();
            RefreshData();
        }

        private void RefreshData()
        {
            Rates.Clear();
            string xmlstring=Consume();
            LoadXml(xmlstring);
            dataGridView1.DataSource = Rates;
        }

        string Consume()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = cbxValuta.SelectedItem.ToString(), // "EUR",
                startDate = tolPicker.Value.ToString(), //"2020-01-01",
                endDate = igPicker.Value.ToString()//"2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            string result = response.GetExchangeRatesResult;
            return result;
            //File.WriteAllText("export.xml", result);
        }

        private void LoadXml(string input) 
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(input);
            foreach (XmlElement element in xml.DocumentElement)
            {                
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }


        private void Charting()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void GetCurrencies()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                string newItem = item.InnerText;
                Currencies.Add(newItem);

            }
            cbxValuta.DataSource = Currencies;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tolPicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void igPicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cbxValuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
