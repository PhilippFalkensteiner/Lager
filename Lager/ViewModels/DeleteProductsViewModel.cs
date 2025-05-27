using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.ViewModels {
    public partial class DeleteProductsViewModel : ObservableObject {
        [ObservableProperty]
        private List<int> ListInt = new() { 1, 2, 5, 10, 20, 25, 50 };
    }
}