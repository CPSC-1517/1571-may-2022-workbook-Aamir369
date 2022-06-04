using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public class Opening
    {
        private int _Edging;
        private int _Height;
        private int _Width;
        private const int HEIGHT = 120;
        private const int WIDTH = 50;
        private const int EDGING = 10; 

        public int Edging
        {
            get
            {
                return _Edging;
            }
            private set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of the Edging should be greater than or Equal to Zero.");
                }
                if(value < EDGING)
                {
                    throw new ArgumentException($"The minimum value for the edging is {EDGING}");
                }
                

                _Edging = value;
            }
        }

        public int Height
        {
            get { return _Height; }
            private set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of the Height should be greater than zero");
                }
              if(value < HEIGHT) // you want constants
                {
                    throw new ArgumentException($"The minimum value of the Height should be greater than {HEIGHT}");
                }
                _Height = value;
            }
        }
        public int Width
        {
            get { return _Width; }
           private set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of Width should be greater than zero");
                }
                if(value < WIDTH)
                {
                    throw new ArgumentException($"The minimum value of the width should be greater than {WIDTH}");
                }


                _Width = value;
            }
        }

        public OpeningType type { get; private set; }

        public int Area { get {  return Height*Width; } }

        public int Perimeter { get { return ((Width + Height) * 2); } }

        public Opening(OpeningType Type, int width = 0, int height = 0, int edging = 0)
        {
            type = Type;
            Width = width;
            Height = height;
            Edging = edging;

        }
        public override string ToString()
        {
            return $"{type},{Width},{Height},{Edging},{Area},{Perimeter}";
        }
         
    }
}
