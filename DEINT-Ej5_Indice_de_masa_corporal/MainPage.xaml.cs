using DEINT_Ej5_Indice_de_masa_corporal.MVVM.ViewModels;

namespace DEINT_Ej5_Indice_de_masa_corporal;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        BindingContext = new IMCViewModel();
    }

}

