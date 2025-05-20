using Lager.ViewModels;

namespace Lager.Views;

public partial class AddProducts : ContentPage
{
	public AddProducts(AddProductViewModel vm)
	{
		
		InitializeComponent();
        this.BindingContext = vm;
    }
}