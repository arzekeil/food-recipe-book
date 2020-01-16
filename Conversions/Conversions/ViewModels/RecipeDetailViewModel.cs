using System;

using Conversions.Models;

namespace Conversions.ViewModels
{
    public class RecipeDetailViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }
        public RecipeDetailViewModel(Recipe item = null)
        {
            Title = item.Name;
            Item = item;
        }
    }
}
