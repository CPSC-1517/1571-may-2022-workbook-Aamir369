using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public class Room
    {
        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name is required");
                }
                _Name = value;
            }
        }

        public string Flooring { get; private set; }

        public List<Wall> Walls { get; private set; }
        public int TotalWalls { get { return Walls.Count; } }


        public void AddWall(Wall wall)
        {
            if (wall == null)
            {
                throw new ArgumentNullException("You must supply the number of walls for it to add up for the Room");
            }
            Walls.Add(wall);
        }

        public Room(string name, string flooring  )
        {
            Name = name;
            Flooring = flooring;  

        }
    }
}
