namespace ReplicateUI.Foodora;

public partial class Page4 : ContentPage
{
	public List<string> Items { get; set; } = new() { "hei", "test" };

	public Page4()
	{
		InitializeComponent();
		BindingContext = this;
	}
}

