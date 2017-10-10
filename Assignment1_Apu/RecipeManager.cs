using Assignment1_Apu.Models;
using System;

namespace Assignment1_Apu
{
    /// <summary>
    ///     Serializable class that creates a way to instansiate the ListManager class.
    /// </summary>
    [Serializable]
    public class RecipeManager : ListManager<BaseRecipe>
    {
    }
}