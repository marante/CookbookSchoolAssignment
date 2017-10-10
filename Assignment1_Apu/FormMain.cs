using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Assignment1_Apu.Enums;
using Assignment1_Apu.HelperMethods;
using Assignment1_Apu.Models;
using Assignment1_Apu.Serializers;

namespace Assignment1_Apu
{
    public partial class FormMain : Form, IClearable
    {
        #region Constructors

        /// <summary>
        ///     Default constructor that sets up the recipe window.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            CourseTypeDropdownCategory.Items.AddRange(Enum.GetNames(typeof(CourseType))
                .ToArray<object>()); // .ToArray used to avoid run time error.
            MealTypeDropdownList.Items.AddRange(Enum.GetNames(typeof(MealType))
                .ToArray<object>()); // .ToArray used to avoid runtime error.
            CourseTypeDropdownCategory.SelectedIndex = 0;
            MealTypeDropdownList.SelectedIndex = 0;

            _manager = new RecipeManager();
            _isSaved = false;
            _fileHelper = new FileHelper();
        }

        #endregion

        #region Private fields

        /// <summary>
        ///     Creating private fields.
        /// </summary>
        private readonly FileHelper _fileHelper;

        private bool _isSaved;
        private List<Ingredient> _ingredients = new List<Ingredient>();
        private RecipeManager _manager;

        #endregion

        #region Logic methods used by clickevents.

        /// <summary>
        ///     Method for clearing the inputs when a recipe is added.
        ///     Makes clearing forms more streamlined.
        /// </summary>
        public void ClearForm()
        {
            RecipeNameTextBox.Clear();
            RecipeTextbox.Clear();
        }

        /// <summary>
        ///     Instantiates a recipe object.
        /// </summary>
        private void CreateRecipe()
        {
            var recipe = new BaseRecipe
            {
                Name = RecipeNameTextBox.Text,
                Description = RecipeTextbox.Text,
                NumOfIngredients = _ingredients.Count,
                CourseType = (CourseType) CourseTypeDropdownCategory.SelectedIndex,
                MealType = (MealType) MealTypeDropdownList.SelectedIndex,
                Ingredients = _ingredients
            };

            AddRecipe(recipe);
        }

        /// <summary>
        ///     Class that adds the given recipe to list of all recipes.
        /// </summary>
        /// <param name="recipe"></param>
        private void AddRecipe(BaseRecipe recipe)
        {
            RecipeListbox.Items.Add(recipe);
            _manager.Add(recipe);
            ClearForm();
        }

        private void UpdateRecipes()
        {
            RecipeListbox.Items.Clear();
            for (var i = 0; i < _manager.Count; i++)
                RecipeListbox.Items.Add(_manager.GetAt(i));
        }

        #endregion

        #region Clickevents for buttons.

        /// <summary>
        ///     Method for adding recipes to the CookBook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecipeAdd_Click(object sender, EventArgs e)
        {
            CreateRecipe();
        }

        /// <summary>
        ///     Method for adding ingredients to a given recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRecipeAddIngredients_Click(object sender, EventArgs e)
        {
            var ingredientForm = new FormIngredient(this);
            var result = ingredientForm.ShowDialog();
            if (result == DialogResult.OK)
                _ingredients = ingredientForm.GetIngredients;
        }

        /// <summary>
        ///     Method for editing the selected recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditRecipe_Click(object sender, EventArgs e)
        {
            if (RecipeListbox.SelectedItem == null)
                return;

            var rec = (BaseRecipe) RecipeListbox.SelectedItem;
            var ingredientForm = new FormIngredient(this, rec);
            var result = ingredientForm.ShowDialog();
            if (result != DialogResult.OK) return;

            rec.Ingredients = ingredientForm.GetIngredients;
            rec.NumOfIngredients = ingredientForm.GetIngredients.Count;

            UpdateRecipes();
        }

        /// <summary>
        ///     Method for deleting the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (RecipeListbox.SelectedItem == null)
                return;

            var selRecipe = (BaseRecipe) RecipeListbox.SelectedItem;
            RecipeListbox.Items.Remove(RecipeListbox.SelectedItem);
            var index = _manager.GetIndex(selRecipe);
            _manager.DeleteAt(index);
        }

        #endregion

        #region Menustrip button actions.

        /// <summary>
        ///     Opens a new MainForm, without saving the data from the last session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (_isSaved)
            {
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }

            var result = MessageBox.Show("You have unsaved data. Would you like to continue?", "Unsaved Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        /// <summary>
        ///     Opens a binary file containing data for the RecipeManager object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            var filePath = _fileHelper.GetFilePath();
            if (filePath != null)
                _manager = Binary.ReadFromBinaryFile<RecipeManager>(filePath);
            UpdateRecipes();
        }

        /// <summary>
        ///     Saves the RecipeManager object to a data file using binary serialization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            var filePath = _fileHelper.GetPath();
            if (filePath == null) return;

            Binary.WriteToBinaryFile(filePath, _manager);
            _isSaved = true;
        }

        /// <summary>
        ///     Saves the RecipeManager object to a given location and name, with the file ending .dat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            var filePath = _fileHelper.SaveFilePath();
            if (filePath == null) return;

            Binary.WriteToBinaryFile(filePath, _manager);
            _isSaved = true;
        }

        #endregion
    }
}