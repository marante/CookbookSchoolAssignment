using System;
using System.Collections.Generic;

namespace Assignment1_Apu.Models
{
    /// <summary>
    ///     Cookbook model
    /// </summary>
    [Serializable]
    public class CookBook : Book
    {
        public List<BaseRecipe> Recipes { get; set; } = new List<BaseRecipe>();
    }
}