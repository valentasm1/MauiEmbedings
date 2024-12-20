namespace MauiEmbedded;

public partial class MyMauiContent : ContentView
{
    private int count = 0;

    public MyMauiContent()
    {
        InitializeComponent();
    }

    public Image DotNetBot => image;

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
        {
            CounterBtn.Text = $"Clicked {count} time";
        }
        else
        {
            CounterBtn.Text = $"Clicked {count} times";
        }

        SemanticScreenReader.Announce(CounterBtn.Text);

        await image.ScaleTo(1.2, 60);
        await image.ScaleTo(1, 60);
    }
}