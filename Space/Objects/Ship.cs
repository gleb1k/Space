using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Objects
{
    public class Ship
    {
        private PictureBox _body = new PictureBox();
        private Form _container;
        private Point _startLocationPoint;
        private List<Bullet> _bullets = new List<Bullet>();

        public int HP { get; set; }
        public int Speed { get; set; } = 30;
        public int Width { get; set; } = 100;
        public int Height { get; set; } = 150;

        public Ship(Point startLocation, Form containerForm)
        {
            _container = containerForm;
            _startLocationPoint = startLocation;

            InicializeObject();
        }

        private void InicializeObject()
        {
            _body.Image = Image.FromFile(Path.Join(Directory.GetCurrentDirectory(), @"/Images/SpaceShip.png"));

            _body.Location = _startLocationPoint;

            _body.SizeMode = PictureBoxSizeMode.StretchImage;
            _body.Width = Width;
            _body.Height = Height;
        }
        public PictureBox Draw()
        {
            return _body;
        }
        public void MoveUp()
        {
            _body.Location = new Point(_body.Location.X, _body.Location.Y - Speed);
        }
        public void MoveDown()
        {
            _body.Location = new Point(_body.Location.X, _body.Location.Y + Speed);
        }
        public void MoveLeft()
        {
            _body.Location = new Point(_body.Location.X - Speed, _body.Location.Y);
        }
        public void MoveRight()
        {
            _body.Location = new Point(_body.Location.X + Speed, _body.Location.Y);
        }
        public void Fire()
        {
            var bullet = new Bullet(_body.Location);

            _bullets.Add(bullet);
            _container.Controls.Add(bullet.GetObject());

            Thread thread = new Thread(bullet.Draw);
            thread.Start();
        }
    }
}
