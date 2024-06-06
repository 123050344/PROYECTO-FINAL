using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static PROYECT.recipe;
using static System.Windows.Forms.DataFormats;


namespace PROYECT
{
    public partial class Form2 : Form
    {
        private recipe currentRecipe;
        private int ingredientLimit;
        public event EventHandler RecipeCreated;

        public Form2()
        {
            InitializeComponent();
        }

        //interface
        public interface IMostrable
        {
            void showinformation();
        }
        //Su implementacion
        public void showinformation()
        {
            if (currentRecipe != null)
            {
                string message = $"Recipe Name: {currentRecipe.Namer}\n";
                message += $"Number of Ingredients: {currentRecipe.Ingredients.Length}\n";
                message += $"Total Calories: {currentRecipe.Calories}\n";

                System.Windows.MessageBox.Show(message, "Recipe Information");
            }
            else
            {
                System.Windows.MessageBox.Show("No recipe available.", "Recipe Information");
            }
        }



        private void btnaddrecipe_Click(object sender, EventArgs e)
        {
            try
            {
                string recipeName = txtnamerecipe.Text;
                if (string.IsNullOrWhiteSpace(recipeName))
                {
                    System.Windows.MessageBox.Show("The name of the recipe cannot be empty");
                    return;
                }

                var ingredients = new Ingredient[ingredientLimit];
                int index = 0;
                foreach (DataGridViewRow row in dgvingredients.Rows)
                {
                    if (row.IsNewRow) continue;

                    var ingredientCell = row.Cells["Ingredient"];
                    var quantityCell = row.Cells["Quantity"];
                    var caloriesCell = row.Cells["Calories"];

                    if (ingredientCell.Value != null && quantityCell.Value != null && caloriesCell.Value != null)
                    {
                        string iname = ingredientCell.Value.ToString();
                        if (int.TryParse(quantityCell.Value.ToString(), out int iQuantity) &&
                            int.TryParse(caloriesCell.Value.ToString(), out int icalories))
                        {
                            ingredients[index++] = new Ingredient(iname, iQuantity, icalories);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Amount or Calories are not valid numbers. Please check the values");
                            return;
                        }
                    }
                }

                currentRecipe = new recipe(recipeName, ingredients);
                RecipeCreated?.Invoke(this, EventArgs.Empty);

                lstrecipes.Items.Add(currentRecipe.Namer);

                Form1 form1 = new Form1();
                form1.AddToListView(recipeName);
                form1.Show();

                txtnamerecipe.Clear();
                dgvingredients.Rows.Clear();
                txttotalcalories.Clear();
                cbkindoffood.Items.Clear();
                txtnotes.Clear();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cbkindoffood_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbkindoffood.Items.Add("Sweet");
            cbkindoffood.Items.Add("salty");
            cbkindoffood.Items.Add("Drink");
        }

        private void btncalculatecalories_Click(object sender, EventArgs e)
        {
            int totalCalories = 0;

            foreach (DataGridViewRow row in dgvingredients.Rows)
            {

                if (row.Cells["Calories"].Value != null && int.TryParse(row.Cells["Calories"].Value.ToString(), out int calories))
                {

                    totalCalories += calories;
                }
            }


            txttotalcalories.Text = totalCalories.ToString() + " cal";
        }

        private void btncreaterecipe_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();


            foreach (DataGridViewRow row in dgvingredients.Rows)
            {
                if (row != null)
                {
                    string ingredient = row.Cells["Ingredient"].Value?.ToString();
                    string quantity = row.Cells["Quantity"].Value?.ToString();

                    if (ingredient != null && quantity != null)
                    {
                        ListViewItem item = new ListViewItem(ingredient);
                        item.SubItems.Add(quantity);
                        form4.lstrecipefinal.Items.Add(item);
                    }
                }
            }

            string recipeName = txtnamerecipe.Text;
            form4.SetFinalRecipeName(recipeName);
            string notes = txtnotes.Text;
            form4.SetFinalNoteText(notes);
            form4.Show();
        }

         //se define el tamaño del arreglo
        private void btnaddningredients_Click(object sender, EventArgs e)
        {
            int numberOfIngredients;
            if (int.TryParse(txtnumberingredients.Text, out numberOfIngredients))
            {
                currentRecipe = new recipe("New Recipe", numberOfIngredients);
                GenerateingredientInputs(numberOfIngredients);
            }
            else
            {
                System.Windows.MessageBox.Show("Please enter a valid number of ingredients.");
            }

            txtnumberingredients.Clear();
        }

        private void GenerateingredientInputs(int numberOfIngredients)
        {
            dgvingredients.Rows.Clear();

            for (int i = 0; i < numberOfIngredients; i++)
            {
                dgvingredients.Rows.Add();
            }
        }

        private void txtNumberIngredients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                System.Windows.MessageBox.Show("Please enter only numbers.");
            }
        }


        private void dgvIngredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int filledRows = 0;

            foreach (DataGridViewRow row in dgvingredients.Rows)
            {
                if (row.Cells["Ingredient"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Ingredient"].Value.ToString()))
                {
                    filledRows++;
                }
            }

            if (filledRows > ingredientLimit)
            {
                dgvingredients.Rows[e.RowIndex].Cells["Ingredient"].Value = null;
                dgvingredients.Rows[e.RowIndex].Cells["Calories"].Value = null;
                System.Windows.MessageBox.Show("You have reached the limit of ingredients.");
            }
        }


        private void lstrecipes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void btnnotes_Click(object sender, EventArgs e)
        {

        }
        private void dgvrecipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void lstrecipes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}