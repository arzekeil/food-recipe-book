using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conversions.Models;

namespace Conversions.Services
{
    public class MockDataStore : IDataStore<Recipe>
    {
        readonly List<Recipe> items;

        public MockDataStore()
        {
            items = new List<Recipe>()
            {
                new Recipe { Name = "Corn on the Cob", Ingredients="Corn, Salt, Butter", Instructions="Set the Corn in boiling water for 5-7 minutes or until heated through", Description="Just Like MaMa used to make" },
                new Recipe { Name = "Beef Patty", Ingredients="Beef Patty", Instructions="Microwave on high for 2 minutes", Description="Just Like MaMa used to make" }
            };
        }

        public async Task<bool> AddItemAsync(Recipe item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Recipe item)
        {
            var oldItem = items.Where((Recipe arg) => arg.Name == item.Name).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Recipe arg) => arg.Name == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Recipe> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<Recipe>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}