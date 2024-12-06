namespace Skills_International
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "Admin" && password.Text == "123")
            {
                RegisterForm rf = new RegisterForm();
                rf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and \n Password and try ageain", "invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            username.Text = String.Empty;
            password.Text = String.Empty;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if ( result == DialogResult.Yes )
            {
                this.Close();
            }
        }
    }
}