using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Conversions.Models;
using Conversions.ViewModels;

namespace Conversions.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            NameEntry.Text = viewModel.Item.Name;
            InstructionsEditor.Text = viewModel.Item.Instructions;
            IngredientsEditor.Text = viewModel.Item.Ingredients;
            DescriptionEditor.Text = viewModel.Item.Description;
            
            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            //var item = new Item
            //{
            //    Text = "Item 1",
            //    Description = "This is a description"
            //};

            //viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}