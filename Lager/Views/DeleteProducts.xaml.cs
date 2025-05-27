using Lager.ViewModels;

namespace Lager.Views;

public partial class DeleteProducts : ContentPage {
    public DeleteProducts(AddProductViewModel vm) {

        InitializeComponent();
        this.BindingContext = vm;
    }
}