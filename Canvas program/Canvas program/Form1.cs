namespace Canvas_program
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 5, 5);
                }
            }
        }
    }
}
