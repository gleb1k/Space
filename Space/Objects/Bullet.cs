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
        object locker = new();
        public int Damage { get; set; }
        public int Speed { get; set; } = 60;
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 10;
        private PictureBox Body { get; set; } = new PictureBox();
        public Point StartLocationPoint { get; set; }

        public Bullet(Point startLocation)
        {
            StartLocationPoint = startLocation;
            InicializeObject();
        }

        private void InicializeObject()
        {
            Body.Image = Image.FromFile(Path.Join(Directory.GetCurrentDirectory(), @"/Images/bullet.png"));

            Body.Location = StartLocationPoint;
            Body.SizeMode = PictureBoxSizeMode.StretchImage;
            Body.Width = Width;
            Body.Height = Height;
            
        }
        //TODO Должны будут скинуть!! Если не скинут всем +50 баллов
        public void Draw()
        {
            //lock (locker)
            //{
            //    int i = 0;
            //    while (i <= 20)
            //    {
            //        Body.Location = new Point(Body.Location.X, Body.Location.Y - Speed);
            //        Thread.Sleep(100);
            //        i++;
            //    }
            //}
        }
        public PictureBox GetObject()
        {
            return Body;
        }
    }
}
