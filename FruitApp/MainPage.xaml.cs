namespace FruitApp
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            List<Fruit> list = new List<Fruit>()
            {
                new Fruit(){ Name="Apple" , Image="apple.png" , Description="This is an apple" },
                new Fruit(){ Name="Orange" , Image="orange.png" , Description="This is an orange" },
                new Fruit(){ Name="Banana" , Image="banana.png" , Description="This is a banana" },
                new Fruit(){ Name="Kiwi" , Image="kiwi.png" , Description="This is a kiwi" },
                new Fruit(){ Name="Strawberry" , Image="strawberry.png" , Description="This is a strawberry" },
                new Fruit(){ Name="Pineapple" , Image="pineapple.png" , Description="This is a pineapple" },
                new Fruit(){ Name="Watermelon" , Image="watermelon.png" , Description="This is a watermelon" },
                new Fruit(){ Name="Grapes" , Image="grape.png" , Description="This is a grape" },
                new Fruit(){ Name="Apricot" , Image="apricot.png" , Description="This is an apricot" },
                new Fruit(){ Name="Coconut" , Image="coconut.png" , Description="This is a coconut" },
                new Fruit(){ Name="Guava" , Image="guava.png" , Description="This is a guava" },
                new Fruit(){ Name="Mango" , Image="mango.png" , Description="This is a mango" },
                new Fruit(){ Name="Melon" , Image="melon.png" , Description="This is a melon" },
                new Fruit(){ Name="Peach" , Image="peach.png" , Description="This is a peach" },
                new Fruit(){ Name="Pear" , Image="pear.png" , Description="This is a pear" },
                new Fruit(){ Name="plum" , Image="plum.png" , Description="This is a plum" },
                new Fruit(){ Name="pomegranate", Image="pomegranate.png", Description="This is a pomegranate" }
        };
            InitializeComponent();
            FruitListView.ItemsSource = list;    
        }

       

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.Image, selectedItem.Description));
            ((ListView)sender).SelectedItem = null;
        }
    }
}