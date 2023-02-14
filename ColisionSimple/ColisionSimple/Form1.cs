namespace ColisionSimple
{
    public partial class Form1 : Form
    {

        private Bitmap bmp;
        static Graphics g;
        private Ball b;

        public Form1()
        {
            InitializeComponent();

   
            
            TIMER.Start();
        }

        public void DrawBall()
        {
            g.Clear(Color.White);
            Brush brush = new SolidBrush(b.color);
            int x = b.x; // set the x coordinate
            int y = b.y; // set the y coordinate
            int diameter = 20; // set the diameter of the ball
            g.FillEllipse(brush, x, y, diameter, diameter);
            b.Update();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        { 
           DrawBall();
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Ball();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }
    }
}