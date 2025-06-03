using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lager.Models;
using Lager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.ViewModels
{
    public partial class AddProductViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<int> _listInt = new() { 1, 2, 5, 10, 20, 25, 50 };

        [ObservableProperty]
        private int _selectedCount; 

        [ObservableProperty]
        private string _name;


        [ObservableProperty]
        private int _preis;


        private readonly DbManagerSQLite _dbManagerSQLite;

        public AddProductViewModel(DbManagerSQLite dbManagerSQLite) {
            this._dbManagerSQLite = dbManagerSQLite;
        }

        [RelayCommand]
        public async Task Add() {
            Product product = new() {
                ProductId = 0,
                Product_Stock = this.SelectedCount, 
                ProductName = this.Name,
                ProductPrice = this.Preis
            };

            this._dbManagerSQLite.Products.Add(product);
            await this._dbManagerSQLite.SaveChangesAsync();
        }
    }
}
