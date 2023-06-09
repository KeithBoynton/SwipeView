namespace SwipeView;

public partial class MainPage : ContentPage
{
    ViewModel vm;

    public MainPage()
	{
		InitializeComponent();

		BindingContext = vm =new ViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        for (int i = 0; i < 100; i++)
        {
            vm.Tracklist.Add($"Track {i}");
        }
    }
}

