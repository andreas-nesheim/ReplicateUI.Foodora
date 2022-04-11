namespace ReplicateUI.Foodora;

public partial class Page3 : ContentPage
{
	public List<string> Items { get; set; } = new() { "hei", "test" };

	public Page3()
	{
		InitializeComponent();
		BindingContext = this;
	}
}

