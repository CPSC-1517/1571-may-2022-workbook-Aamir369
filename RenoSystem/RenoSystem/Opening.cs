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



        public int Edging
        {
            get
            {
                return _Edging;
            }
            set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of the Edging should be greater than Zero.");
                }

                _Edging = value;
            }
        }

        public int Height
        {
            get { return _Height; }
            set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of the Height should be greater than zero");
                }
                _Height = value;
            }
        }
        public int Width
        {
            get { return _Width; }
            set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of Width should be greater than zero");
                }

                _Width = value;
            }
        }

        public OpeningType type { get; set; }

        public int Area { get; }

        public int Perimeter { get; }

        public Opening(OpeningType Type, int width = 0, int height = 0, int edging = 0)
        {
            type = Type;
            Width = width;
            Height = height;
            Edging = edging;

        }
        public override string ToString()
        {
            return $"{type},{Width},{Height},{Edging}";
        }











    }
}
