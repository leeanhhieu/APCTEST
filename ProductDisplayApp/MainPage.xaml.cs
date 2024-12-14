using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ProductDisplayApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        LoadProductData();
    }

    private async void LoadProductData()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "ProductDisplayApp.Resources.Raw.product.json"; // Path to your JSON file

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        using (var reader = new StreamReader(stream))
        {
            var json = await reader.ReadToEndAsync();
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            ProductListView.ItemsSource = products;
        }
    }

    private void OnProductTapped(object sender, ItemTappedEventArgs e)
    {
        var product = e.Item as Product;
        if (product != null)
        {
            DisplayAlert("Product Info", $"ID: {product.Id}\nName: {product.ProductName}\nPrice: {product.Price:C}", "OK");
        }
    }
}
