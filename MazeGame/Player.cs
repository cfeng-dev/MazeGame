using MazeGame;
using System.Collections.Generic;

namespace MazeGame
{
    public class Player
    {
        private Room currentRoom;
        private List<Item> bag;

        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;

            this.bag = new List<Item>();
        }

        public void addBag(Item item)
        {
            this.bag.Add(item);
        }

        public List<Item> getBag()
        {
            return this.bag;
        }

        public void removeBag(Item item)
        {
            this.bag.Remove(item);
        }

        public Room getCurrentRoom()
        {
            return this.currentRoom;
        }


        public bool move(char direction)
        {
            if (currentRoom.getConnectedRoom(direction) == null)
            {
                return false;
            }
            else
            {
                currentRoom = currentRoom.getConnectedRoom(direction);
                return true;
            }
        }
    }
}