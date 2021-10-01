using System.Windows.Forms;

namespace GruppPract
{
    public partial class RecipeForm : Form
    {
        private Model _model;

        public Model Model
        {
            get => _model;
        }

        public RecipeForm()
        {
            InitializeComponent();

            _model = Model.Instance;

            listBoxRecipeName.DataSource = Model.RecipeManager.RecipeList;
            listBoxRecipeDescription.DataSource = Model.RecipeManager.RecipeList;
        }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            string user = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            // TODO: Test user/pw, if correct, open admin dialogue here.

            AdminForm dlg = new AdminForm();
            DialogResult dlgResult = dlg.ShowDialog();


            if (dlgResult == DialogResult.OK)
            {
                //listBoxRecipeDescription.RefreshItems();
                return;
            }
            else if (dlgResult == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
