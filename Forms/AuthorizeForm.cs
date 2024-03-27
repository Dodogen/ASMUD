using System;
using System.Windows.Forms;

namespace ASMUD
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void button_Autorize_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserClient uc = new UserClient();
            uc.Closed += (s, args) => this.Close();
            uc.Show();
        }
    }
}
