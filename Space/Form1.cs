using Space.Objects;
using System.Reflection;

namespace Space
{
    public partial class Form1 : Form
    {
        Ship ship;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;

            ship = new Ship(new Point(Width/2, Height - 400), this);
            Controls.Add(ship.Draw());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show($"{e.GetHashCode()}");
            //switch (e)
            //{
                
            //    default: MessageBox.Show($"{e.GetHashCode()}");
            //        break;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Down):
                    ship.MoveDown();
                    break;
                case (Keys.Up):
                    ship.MoveUp();
                    break;
                case (Keys.Left):
                    ship.MoveLeft();    
                    break;
                case (Keys.Right):
                    ship.MoveRight();
                    break;
                case (Keys.Space):
                    ship.Fire();
                    break;
                default:
                    MessageBox.Show($"{e.KeyCode}");
                    break;
            }
        }
    }
}