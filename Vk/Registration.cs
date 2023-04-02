using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Vk;
namespace Registration
{
    public partial class Registration : Form
    {
        VkWindow window;
        public Registration()
        {
            InitializeComponent();
            window=new VkWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && checkBox1.Checked)
            {
               MessageBox.Show("Seccesfull registation");
                Visible = false;
                  UserDate.Name = textBox1.Text;
                UserDate.Email = textBox2.Text;
                UserDate.Password= textBox3.Text;
                window.Show();
            }


            if (textBox1.Text == "")
                label6.Visible = true;

                if(textBox2.Text == "" )
                label7.Visible = true;

            if ( textBox3.Text == "" )
                label8.Visible = true;

            if (!checkBox1.Checked)
                label9.Visible=true;


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
    }
}