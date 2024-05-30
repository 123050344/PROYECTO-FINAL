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

        public event EventHandler RecipeCreated;

        public Form2()
        {
            InitializeComponent();
        }

        public interface IMostrable
        {
            void showinformation();
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

                var ingredients = new List<Ingredient>();
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
                            ingredients.Add(new Ingredient(iname, iQuantity, icalories));
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Amount or Calories are not valid numbers. Please check the values");
                            return;
                        }
                    }
                }

                
                var recipe1 = new recipe(recipeName, ingredients);
                RecipeCreated?.Invoke(this, EventArgs.Empty);

                // Mostrar en alguna parte de la interfaz
                lstrecipes.Items.Add(recipe1.Namer);

               
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