namespace OOP_1Lab_5Task
{
    public partial class Form1 : Form
    {

        private Action superAction;

        public Form1()
        {
            InitializeComponent();
        }

        private void ActionHello() => MessageBox.Show("Hello World!");

        private void ActionColor() => this.BackColor = Color.FromArgb(new Random().Next(256), new Random().Next(256), new Random().Next(256));

        private void ActionOpacity() => this.Opacity = (this.Opacity <= 0.5) ? 1.0 : 0.5;


        private void chkHello_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHello.Checked) superAction += ActionHello;
            else superAction -= ActionHello;
        }

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColor.Checked) superAction += ActionColor;
            else superAction -= ActionColor;
        }

        private void chkOpacity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpacity.Checked) superAction += ActionOpacity;
            else superAction -= ActionOpacity;
        }


        private void btnSuperMega_Click(object sender, EventArgs e)
        {
            superAction?.Invoke();
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            ActionHello();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ActionColor();
        }

        private void btnOpacity_Click(object sender, EventArgs e)
        {
            ActionOpacity();
        }
    }
}
