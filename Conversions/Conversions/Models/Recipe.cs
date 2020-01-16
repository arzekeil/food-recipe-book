using System;
using SQLite;

namespace Conversions.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }
    }
}