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

            listBoxRecipeTitle.DataSource = Model.RecipeManager.RecipeList;
            listBoxRecipeDescription.DataSource = Model.RecipeManager.RecipeList;
        }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            Admin admin = new Admin();

            string user = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (admin.CheckLogin(user, password))
            {
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
}
