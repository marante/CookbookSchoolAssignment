﻿using Assignment1_Apu.Enums;
using Assignment1_Apu.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormMain : Form
    {
        private CookBook _cookBook = new CookBook();
        private ObservableCollection<Ingredient> _ingredients = new ObservableCollection<Ingredient>();

        public FormMain()
        {
            InitializeComponent();
        }

        #region Clickevents for buttons.

        /// <summary>
        /// Method for adding recipes to the CookBook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecipeAdd_Click(object sender, EventArgs e)
        {
            AddRecipe();
        }

        /// <summary>
        /// Method for adding ingredients to a given recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecipeAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredient ingredientForm = new FormIngredient(this);
            var result = ingredientForm.ShowDialog();
            if (result == DialogResult.OK)
                _ingredients = ingredientForm.Ingredients;
        }

        /// <summary>
        /// Method for editing the selected recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditRecipe_Click(object sender, EventArgs e)
        {
            if (RecipeListbox.SelectedItem == null)
                return;

            var rec = (Recipe) RecipeListbox.SelectedItem;
            FormIngredient ingredientForm = new FormIngredient(this, rec);
            var result = ingredientForm.ShowDialog();
            if (result != DialogResult.OK) return;

            rec.Ingredients = ingredientForm.Ingredients;
            rec.NumOfIngredients = ingredientForm.Ingredients.Count;

            RecipeListbox.Items.Clear();
            foreach (var recipe in _cookBook.Recipes)
            {
                RecipeListbox.Items.Add(recipe);
            }
        }

        /// <summary>
        /// Method for deleting the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (RecipeListbox.SelectedItem == null)
                return;

            var selRecipe = (Recipe)RecipeListbox.SelectedItem;
            RecipeListbox.Items.Remove(RecipeListbox.SelectedItem);
            _cookBook.Recipes.Remove(selRecipe);
        }

        #endregion

        /// <summary>
        /// Method for clearing the inputs when a recipe is added.
        /// </summary>
        private void ClearForm()
        {
            RecipeNameTextBox.Clear();
            RecipeTextbox.Clear();
        }

        /// <summary>
        /// Method that adds a recipe the cookbook object and displays it in a listbox.
        /// </summary>
        private void AddRecipe()
        {
            // Initializing an instance of recipe.
            Recipe recipe = new Recipe
            {
                Name = RecipeNameTextBox.Text,
                Description = RecipeTextbox.Text,
                NumOfIngredients = _ingredients.Count,
                Dish = (Dish)RecipeDropdownCategory.SelectedIndex,
                MealType = (MealType)MealTypeDropdownList.SelectedIndex,
                Ingredients = _ingredients
            };

            // Adding the recipe to the cookbook and updating the Recipe list
            _cookBook.Recipes.Add(recipe);
            RecipeListbox.Items.Add(recipe);
            ClearForm();
        }
    }
}