using System.Collections.Generic;

namespace MazeGame
{
    public class Room
    {
        private string name;
        private Room south;
        private Room west;
        private Room north;
        private Room east;
        private List<Item> content;

        public Room(string name)
        {
            this.name = name;
            this.content = new List<Item>();
        }

        public void addContent(Item item)
        {
            this.content.Add(item);
        }

        public List<Item> getContent()
        {
            return this.content;
        }

        public void removeContent(Item item)
        {
            this.content.Remove(item);
        }

        public Room getConnectedRoom(char direction)
        {
            switch (direction)
            {
                case 'N': return this.north;
                case 'E': return this.east;
                case 'S': return this.south;
                case 'W': return this.west;
                default: return null;
            }
        }

        public string getName()
        {
            return this.name;
        }

        public void setConnectedRooms(Room north, Room east, Room south, Room west)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;
        }

        public void setConnectedRoomsKey(Room r, char direction)
        {
            if (direction == 'N')
            {
                this.north = r;
            }
            else if (direction == 'E')
            {
                this.east = r;
            }
            else if (direction == 'S')
            {
                this.south = r;
            }
            else if (direction == 'W')
            {
                this.west = r;
            }
        }
    }
}
