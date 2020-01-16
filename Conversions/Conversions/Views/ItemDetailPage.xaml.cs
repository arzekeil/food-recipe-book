using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

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
            BindingContext = viewModel;
        }
    }
}