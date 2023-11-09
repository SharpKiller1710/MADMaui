namespace MyFirstMobileApp.ViewViewModels.CollectionsContents.CollectionIcons;

public partial class CollectionIconView : ContentPage
{
	public CollectionIconView()
	{
		InitializeComponent();
        BindingContext = new CollectionIconViewModel();
    }
}