using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    public partial class FormIngredient : Form
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

        public ObservableCollection<Ingredient> GetIngredients { get; } = new ObservableCollection<Ingredient>();

        #endregion

    }
}
