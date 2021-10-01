
namespace GruppPract
{
    partial class RecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxRecipeTitle = new System.Windows.Forms.ListBox();
            this.listBoxRecipeDescription = new System.Windows.Forms.ListBox();
            this.radioButtonTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(29, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(158, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(26, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(73, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search recipe";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(305, 96);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(134, 20);
            this.textBoxUserName.TabIndex = 2;
            this.textBoxUserName.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(305, 135);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(302, 80);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(55, 13);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(302, 119);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(134, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(364, 161);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxRecipeTitle
            // 
            this.listBoxRecipeTitle.FormattingEnabled = true;
            this.listBoxRecipeTitle.Location = new System.Drawing.Point(29, 96);
            this.listBoxRecipeTitle.Name = "listBoxRecipeTitle";
            this.listBoxRecipeTitle.Size = new System.Drawing.Size(200, 160);
            this.listBoxRecipeTitle.TabIndex = 6;
            // 
            // listBoxRecipeDescription
            // 
            this.listBoxRecipeDescription.FormattingEnabled = true;
            this.listBoxRecipeDescription.Location = new System.Drawing.Point(29, 276);
            this.listBoxRecipeDescription.Name = "listBoxRecipeDescription";
            this.listBoxRecipeDescription.Size = new System.Drawing.Size(340, 173);
            this.listBoxRecipeDescription.TabIndex = 7;
            // 
            // radioButtonTitle
            // 
            this.radioButtonTitle.AutoSize = true;
            this.radioButtonTitle.Location = new System.Drawing.Point(29, 66);
            this.radioButtonTitle.Name = "radioButtonTitle";
            this.radioButtonTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTitle.TabIndex = 8;
            this.radioButtonTitle.TabStop = true;
            this.radioButtonTitle.Text = "Title";
            this.radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(79, 66);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(49, 17);
            this.radioButtonType.TabIndex = 8;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "Type";
            this.radioButtonType.UseVisualStyleBackColor = true;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 471);
            this.Controls.Add(this.radioButtonType);
            this.Controls.Add(this.radioButtonTitle);
            this.Controls.Add(this.listBoxRecipeDescription);
            this.Controls.Add(this.listBoxRecipeTitle);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "RecipeForm";
            this.Text = "Search recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxRecipeTitle;
        private System.Windows.Forms.ListBox listBoxRecipeDescription;
        private System.Windows.Forms.RadioButton radioButtonTitle;
        private System.Windows.Forms.RadioButton radioButtonType;
    }
}

