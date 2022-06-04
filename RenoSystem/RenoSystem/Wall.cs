using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public class Wall
    {
        private string _Color;
        private int _Height;
        private int _Width;
        private string _PlanId;
        private const int HEIGHT = 100;
        private const int WIDTH = 26;


        public int Height {
            get {
                return _Height;
            }

            private set {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentException("The value of the Height should be greater than zero");
                }
                if (value < HEIGHT)
                {
                    throw new ArgumentException($"The minimum height of is {HEIGHT}");
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
                if (value < WIDTH)
                {
                    throw new ArgumentException($"The minimum value of the width should be {WIDTH}");
                }

                _Width = value;
            }
        }


        public Opening WallOpening { get; set; }


        public int SurfaceArea { get { return ((Width * Height) - WallOpening.Area); } }

       

        public string Color
        {
            get
            {

                return _Color;
            }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Color  is a required piece of data.");
                }

                 
                _Color = value;
            }
        }
        public string PlanId 
        {
            get
            {

                return _PlanId;
            }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Plan ID  is a required piece of data.");
                }

              
                _PlanId = value;
            }

        }


        public Wall(string planid, int width, int height, string color, Opening opening)
 
        {
            PlanId= planid;
            Width  = width;
            Height = height;
            Color = color;
            WallOpening = opening;
            if((opening.Area) > (0.9 * Width * Height))
            {
                throw new ArgumentException("Opening Limit Exceeded");
            }
        }
        public override string ToString()
        {
            return $"{PlanId},{Width},{Height},{Color},{WallOpening},{SurfaceArea}";
        } 
    } 
}
