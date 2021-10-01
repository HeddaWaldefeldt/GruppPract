using System;
using System.Windows.Forms;

namespace GruppPract
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public Model Model
        {
            get => Model.Instance;
        }

        private void buttonAdminSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = textBoxAdminSearch.Text;
            RecipeManager rm = new RecipeManager();
            foreach (Recipe recipe in rm.RecipeList)
            {
                if (recipe.Title.ToLower().Contains(searchCriteria.ToLower()) && recipe.Type.ToLower().Contains(searchCriteria.ToLower()))
                {
                    listBoxAdminRecipeName.Items.Add(recipe);
                }
            }
        }

        private void buttonAdminDeleteRecipe_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdminAddRecipe_Click(object sender, EventArgs e)
        {   

            string message = Model.AddRecipe(textBoxAdminRecipieName.Text, textBoxAdminRecipeType.Text, textBoxAdminRecipeDescription.Text);
                
            MessageBox.Show(message);


            listBoxAdminRecipeName.Items.Clear();
            
            // TODO: If validation fails, inform user.
            // TODO: Refresh listboxes here. 
        }

        private void buttonAdminUpdateRecipe_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
