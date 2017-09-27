using System;

namespace Assignment1_Apu.Models
{
    /// <summary>
    /// Ingredient model
    /// </summary>
    [Serializable]

    public class Ingredient
    {
        public string Name { get; set; }
        public float Amount { get; set; }

        public string DisplayIngredient => $"{Amount} \t {Name}";
    }
}
