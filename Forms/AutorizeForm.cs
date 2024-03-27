using System;
using System.Windows.Forms;

namespace ASMUD
{
    public partial class AutorizeForm : Form
    {
        public AutorizeForm()
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
