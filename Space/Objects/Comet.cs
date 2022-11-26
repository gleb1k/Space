using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Objects
{
    public class Comet
    {
        private PictureBox _body = new PictureBox();
        private Form _container;
        private Point _startLocationPoint;
        public int Width { get; set; } = 100;
        public int Height { get; set; } = 100;
        public int Speed { get; set; }
    }
}