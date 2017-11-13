using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Season.Quarterly.Forecast
{
    public partial class Form1 : Form
    {
        double avgSalesPerYear, forecastSales, year1Season1, year1Season2, year1Season3, year1Season4,
               year2Season1, year2Season2, year2Season3, year2Season4, season1ForecastRate, season2ForecastRate, 
               season3ForecastRate, season4ForecastRate, avgSeason1, avgSeason2, avgSeason3, avgSeason4, season1Forecast,
               season2Forecast, season3Forecast,season4Forecast;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avgSalesPerYear = double.Parse(textBox1.Text);
            year1Season1 = double.Parse(textBox2.Text);
            year1Season2 = double.Parse(textBox3.Text);
            year1Season3 = double.Parse(textBox4.Text);
            year1Season4 = double.Parse(textBox5.Text);
            year2Season1 = double.Parse(textBox6.Text);
            year2Season2 = double.Parse(textBox7.Text);
            year2Season3 = double.Parse(textBox8.Text);
            year2Season4 = double.Parse(textBox9.Text);
            forecastSales = double.Parse(textBox14.Text);

            avgSeason1 = (year1Season1 + year2Season1) / 2;
            season1ForecastRate = avgSeason1 / avgSalesPerYear;
            season1Forecast = season1ForecastRate * forecastSales;
            textBox10.Text = season1Forecast.ToString();

            avgSeason2 = (year1Season2 + year2Season2) / 2;
            season2ForecastRate = avgSeason2 / avgSalesPerYear;
            season2Forecast = season2ForecastRate * forecastSales;
            textBox11.Text = season2Forecast.ToString();

            avgSeason3 = (year1Season3 + year2Season3) / 2;
            season3ForecastRate = avgSeason3 / avgSalesPerYear;
            season3Forecast = season3ForecastRate * forecastSales;
            textBox12.Text = season3Forecast.ToString();

            avgSeason4 = (year1Season4 + year2Season4) / 2;
            season4ForecastRate = avgSeason4 / avgSalesPerYear;
            season4Forecast = season4ForecastRate * forecastSales;
            textBox13.Text = season4Forecast.ToString();

        }
    }
}
