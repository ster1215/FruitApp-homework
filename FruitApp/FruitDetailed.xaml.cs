using System.Collections.Generic;

namespace FruitApp;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string name, string image,string Description)
    {
		InitializeComponent();
        fruitImg.Source = image;  
        fruitName.Text= name;
        fruitDescription.Text = Description;

    }
}