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

        }

        private void buttonAdminDeleteRecipe_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdminAddRecipe_Click(object sender, EventArgs e)
        {
            Model.AddRecipe(textBoxAdminRecipieName.Text, textBoxAdminRecipeType.Text, textBoxAdminRecipeDescription.Text);
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
