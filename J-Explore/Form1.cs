using J_Explore.Services;

namespace J_Explore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrintHelper.Print(new PrintingArgumentsTransaction(1, "Otong", DateTime.Now, 2, 2, 25000));
        }
    }
}