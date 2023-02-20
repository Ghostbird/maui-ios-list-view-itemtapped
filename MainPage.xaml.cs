namespace list_view_itemtapped;

public class MainPage : ContentPage
{
  protected override void OnAppearing()
  {
		base.OnAppearing();
    var list = new ListView()
    {
      ItemTemplate = new DataTemplate(() => {
				var label = new Label();
				label.SetBinding(Label.TextProperty, ".");
				return new ViewCell {
					View = label,
				};
			}),
			ItemsSource = Enumerable.Range(0, 40),
			RowHeight = 30,
			HeightRequest = 990,
		};
		list.ItemTapped += (object? sender, ItemTappedEventArgs e) => DisplayAlert("Tapped!", e.Item.ToString(), "Ok");
		Content = list;
  }
}
