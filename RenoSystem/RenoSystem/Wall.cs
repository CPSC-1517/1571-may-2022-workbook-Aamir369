using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renosystem
{
    public class Wall
    {
        private string _Color;
        private int _Height;
        private int _Width;
        private string _PlanId;
    
    public int HEIGHT { 
        get { 
            return _Height; 
        }
        
        set {
            if (!Utilities.IsZeroPositive(value))
            {
                throw new ArgumentException("The value of the Height should be greater than zero")
            };       
            _Height = value; } }

        public int WIDTH
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
        public Opening Opening { get; set; }    
        public string Color { get; set; }
        public int Height { get; set; }

        public string PlanId { get; set; }

        public int SurfaceArea { get;}

       public int Width { get; set; }
 
        public OpeningType(string planid, int width, int height, string color, Opening opening)
 
        {
            PlanId= planid;
            Width  = width;
            Height = height;
            Color = color;
        }
        public override string ToString()
        {
            return $"{PlanId},{Width},{Height},{Color}";
        } 
    } 
}
