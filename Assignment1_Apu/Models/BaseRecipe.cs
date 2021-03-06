﻿using System;
using System.Collections.Generic;
using Assignment1_Apu.Enums;

namespace Assignment1_Apu.Models
{
    /// <summary>
    ///     BaseRecipe model. This model is the superclass of the other recipeclasses.
    /// </summary>
    [Serializable]
    public class BaseRecipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumOfIngredients { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public CourseType CourseType { get; set; }
        public MealType MealType { get; set; }

        public string DisplayString =>
            $"{Name} \t\t\t {NumOfIngredients} \t {CourseType} \t {MealType} \t {Description}";
    }
}