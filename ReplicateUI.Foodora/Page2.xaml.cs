namespace ReplicateUI.Foodora;

public partial class Page2 : ContentPage
{
	public List<string> Items { get; set; } = new() { "hei", "test" };

	public Page2()
	{
		InitializeComponent();
		BindingContext = this;
	}
}

