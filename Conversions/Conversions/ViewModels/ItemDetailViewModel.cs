using System;

using Conversions.Models;

namespace Conversions.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }
        public ItemDetailViewModel(Recipe item = null)
        {
            Title = item.Name;
            Item = item;
        }
    }
}
