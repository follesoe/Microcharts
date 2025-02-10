using System;
using System.Collections.Generic;
using Microcharts.Samples.Maui.Model;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Microcharts.Samples.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var charts = Data.CreateXamarinSample();
            var items = new List<ChartItem>();
            for (int i = 0; i < charts.Length; i++)
            {
                items.Add(new ChartItem(charts[i].GetType().Name, charts[i], i));
            }
            Items = items;
            InitializeComponent();
        }

        public List<ChartItem> Items { get; }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var border = sender as Border;
            ChartItem chartItem = border.BindingContext as ChartItem;
            Navigation.PushAsync(new ChartConfigurationPage(chartItem.Name));
        }

        private void TapGestureRecognizerLegacyChartsTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LegacyPage());
        }
    }
}
