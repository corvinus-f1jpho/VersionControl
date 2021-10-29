﻿using ProofofConcept.MNBServiceReference;
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

namespace ProofofConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Consume();
        }

        void Consume()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            string result = response.GetExchangeRatesResult;
            File.WriteAllText("export.xml", result);
        }
    }
}
