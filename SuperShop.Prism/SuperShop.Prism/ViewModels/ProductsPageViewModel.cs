using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop.Prism.Models;
using SuperShop.Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Prism.ViewModels
{
	public class ProductsPageViewModel : ViewModelBase
	{
        private readonly IApiService _apiService;
        private List<ProductResponse> _products;

        public ProductsPageViewModel(INavigationService navigationService, IApiService apiService) : base(navigationService)
        {
            Title = "Products Page";
            _apiService = apiService;
            LoadProductsAsync();
        }

        public List<ProductResponse> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        private async void LoadProductsAsync()
        {
            string url = App.Current.Resources["UrlAPI"].ToString();

            Response response = await _apiService.GetListAsync<ProductResponse>(url, "/Api/", "Products", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJjdW5oYW1hdXJvQG91dGxvb2sucHQiLCJqdGkiOiI4NGM2MmE1ZC1lMWUyLTRmYjUtOTliZC00OGM1YmZkNTA3MzciLCJleHAiOjE3Mjc3MDcyNTksImlzcyI6ImxvY2FsaG9zdCIsImF1ZCI6InVzZXJzIn0.SDXVQ1fManHQUX82SbNmIka_4rqlqSuNQ3kUmigGy9Q");

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            Products = (List<ProductResponse>)response.Result;
        }
    }
}
