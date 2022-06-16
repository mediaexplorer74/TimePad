using System;
using System.Collections.Generic;
using Xamarin.Forms;
using TimePad.Models;
//namespace TimePad.Views; // TODO

namespace TimePad
{
    public partial class MainPage : ContentPage
    {
        RestService _restService;
         
        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            List<TimePadItem> repositories = await _restService.GetRepositoriesAsync(Constants.TimePadAPIGetEvents);

            collectionView.ItemsSource = repositories;
        }
    }
}
