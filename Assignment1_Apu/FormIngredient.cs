using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormIngredient : Form
    {
        public ObservableCollection<Ingredient> Ingredients = new ObservableCollection<Ingredient>();
        public FormMain MainForm;

        public FormIngredient()
        {
            InitializeComponent();
        }

        public FormIngredient(FormMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        public FormIngredient(FormMain mainForm, Recipe recipe)
        {
            InitializeComponent();
            MainForm = mainForm;
            Recipe rec = recipe;

            foreach (var ingredient in rec.Ingredients)
            {
                Ingredients.Add(ingredient);
                IngredientListBox.Items.Add(ingredient);
            }

            if (IngredientListBox.Items.Count > 0)
            {
                lblNumOfIngredients.Text = IngredientListBox.Items.Count.ToString();
            }
            else if (IngredientListBox.Items.Count == 0)
            {
                lblNumOfIngredients.Text = "No ingredients have been added yet.";
            }
        }

        private void BtnIngredientOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method that cancels the current form, without saving.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIngredientCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIngredientDelete_Click(object sender, EventArgs e)
        {
            var selIngredient = (Ingredient)IngredientListBox.SelectedItem;
            IngredientListBox.Items.Remove(IngredientListBox.SelectedItem);
            Ingredients.Remove(selIngredient);
        }

        /// <summary>
        /// Method for adding ingredients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIngredientAdd_Click(object sender, EventArgs e)
        {
            AddIngredient();
            ClearForm();
        }

        /// <summary>
        /// Just a method for clearing the inputfields.
        /// </summary>
        private void ClearForm()
        {
            ingredientTextbox.Text = "";
            IngredientAmount.Text = "";
        }

        /// <summary>
        /// Method for appending items, formatted, to the ingredientlist.
        /// </summary>
        private void AddIngredient()
        {
            if (ingredientTextbox.Text == null || IngredientAmount.Text == null)
                return;

            var ingredient = new Ingredient()
            {
                Amount = float.Parse(IngredientAmount.Text),
                Name = ingredientTextbox.Text
            };

            Ingredients.Add(ingredient);

            IngredientListBox.Items.Add(ingredient);
        }

        private void BtnChangePortionValues_Click(object sender, EventArgs e)
        {
            if (cmbAmountOfPortions.SelectedItem == null)
                return;

            var portions = float.Parse(cmbAmountOfPortions.SelectedItem.ToString());
            foreach (Ingredient ingredient in IngredientListBox.Items)
            {
                portions = portions < 0 ? 1 : float.Parse(cmbAmountOfPortions.SelectedItem.ToString());
                ingredient.Amount = (ingredient.Amount * portions);
            }
            cmbAmountOfPortions.SelectedItem = null;
            IngredientListBox.Items.Clear();
            foreach (var ingredient in Ingredients)
            {
                IngredientListBox.Items.Add(ingredient);
            }
        }
    }
}
