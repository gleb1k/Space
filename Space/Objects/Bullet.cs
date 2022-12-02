using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Space.Objects
{
    public class Bullet
    {
        private PictureBox _body = new PictureBox();
        private Point _startLocationPoint;
        public int Damage { get; set; }
        public int Speed { get; set; } = 20;
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 10;


        public Bullet(Point startLocation)
        {
            _startLocationPoint = startLocation;
            InicializeObject();
        }

        private void InicializeObject()
        {
            _body.Image = Image.FromFile(Path.Join(Directory.GetCurrentDirectory(), @"/Images/bullet.png"));

            _body.Location = _startLocationPoint;
            _body.SizeMode = PictureBoxSizeMode.StretchImage;
            _body.Width = Width;
            _body.Height = Height;
        }

        //TODO Тимерхан Аглямович должен будет скинуть!! В случае не выполнения всем студентам +50 баллов
        public PictureBox Draw()
        {
            return _body;
        }

        public PictureBox GetObject()
        {
            return _body;
        }
    }
}