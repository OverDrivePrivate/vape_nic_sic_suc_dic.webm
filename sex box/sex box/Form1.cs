namespace sex_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "sex?";
            MessageBox.Show(message);
            string title = "sex moment";
            MessageBox.Show(message, title);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult = MessageBox.Show(message, title, buttons);
            if (DialogResult == DialogResult.No)
                this.Close();
            {
                if (DialogResult == DialogResult.Yes) ;
                MessageBox.Show(message);
                
                
                
            }
        }
    }
}