using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormIngredient : Form, IClearable
    {
        private FormMain _mainForm;

        /// <summary>
        /// Standard constructor, initializing the form components.
        /// </summary>
        public FormIngredient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor taking a form as parameter.
        /// </summary>
        /// <param name="mainForm"></param>
        public FormIngredient(FormMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        /// <summary>
        /// Constructor taking 2 parameters
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="recipe"></param>
        public FormIngredient(FormMain mainForm, Recipe recipe)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Recipe rec = recipe;

            foreach (var ingredient in rec.Ingredients)
            {
                GetIngredients.Add(ingredient);
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

        /// <summary>
        /// Eventhandler for the Ok button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Button for deleting an ingredient from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIngredientDelete_Click(object sender, EventArgs e)
        {
            var selIngredient = (Ingredient)IngredientListBox.SelectedItem;
            IngredientListBox.Items.Remove(IngredientListBox.SelectedItem);
            GetIngredients.Remove(selIngredient);
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
        public void ClearForm()
        {
            ingredientTextbox.Clear();
            IngredientAmount.Clear();
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

            GetIngredients.Add(ingredient);

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
            foreach (var ingredient in GetIngredients)
            {
                IngredientListBox.Items.Add(ingredient);
            }
        }

        // Properties.
        #region Properties.

        public List<Ingredient> GetIngredients { get; } = new List<Ingredient>();

        #endregion

        /// <summary>
        /// Helper function to make sure users only input numbers in the amount textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckIfNumbers(object sender, KeyPressEventArgs e)
        {
            // Makes sure that that pressed key is NOT a control character
            // also makes sure it's not a char (only allow digits).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox) sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
