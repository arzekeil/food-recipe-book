using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

using Conversions.Models;

namespace Conversions.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public Recipe Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            Item = new Recipe
            {
                Name = NameEntry.Text,
                Ingredients = IngredientsEditor.Text,
                Instructions = InstructionsEditor.Text,
                Description = DescriptionEditor.Text
            };

            using (SQLiteConnection Connection = new SQLiteConnection(App.FilePath))
            {
                Connection.Insert(Item);
            }

                MessagingCenter.Send(this, "Recipe Added", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}