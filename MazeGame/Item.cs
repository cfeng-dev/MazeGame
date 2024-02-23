using MazeGame;
using System.Windows.Forms;

namespace MazeGame

{
    public class Item
    {
        protected string name;
        protected bool pickable;

        public Item(string name, bool pickable)
        {
            this.name = name;
            this.pickable = pickable;

        }

        public override string ToString()
        {
            return this.name;
        }

        public bool isPickable()
        {
            return this.pickable;
        }

        public virtual void use(Player user) { }
    }

    public class WoodenStick : Item
    {
        public WoodenStick() : base("Wooden Stick", true)
        { }

        public override void use(Player user)
        {
            MessageBox.Show("You ripped your stick");
            WoodenStick stick = new WoodenStick();
            user.addBag(stick);
        }
    }
    public class Book : Item
    {
        public Book() : base("Book", true)
        { }

        public override void use(Player user)
        {
            MessageBox.Show("The princess is waiting for you! \n (Please press 'E' to go into the castle otherwise you die!)");
        }
    }

    public class Princess : Item
    {
        public Princess() : base("Princess", true)
        { }

        public override void use(Player user)
        {
            MessageBox.Show("Press 'N' to receive your reward");
        }
    }


    public class Door : Item
    {

        private bool locked = true;
        private char dir1;
        private char dir2;
        private Room room1;
        private Room room2;



        public Door(string name, bool pickable, Room room1, char dir1, Room room2, char dir2) : base(name, pickable)
        {
            this.room1 = room1;
            this.room2 = room2;

            this.dir1 = dir1;
            this.dir2 = dir2;
        }

        public void toggleLock()
        {
            if (locked == true)
            {
                locked = false;

                room1.setConnectedRoomsKey(room2, dir2);
                room2.setConnectedRoomsKey(room1, dir1);
            }
            else
            {
                locked = true;

                room1.setConnectedRoomsKey(null, dir2);
                room2.setConnectedRoomsKey(null, dir1);
            }
        }

        public Room getRoom1()
        {
            return room1;
        }
        public Room getRoom2()
        {
            return room2;
        }

        public override string ToString()
        {
            if (locked == true)
            {
                return this.name + "-locked";
            }
            else
                return this.name + "-open";
        }

    }

    public class Key : Item
    {
        private Door unlockedDoor;

        public Key(string name, bool pickable, Door unlockedDoor) : base(name, pickable)
        {
            this.unlockedDoor = unlockedDoor;
        }

        public override void use(Player user)
        {
            if (unlockedDoor.getRoom1() == user.getCurrentRoom() || unlockedDoor.getRoom2() == user.getCurrentRoom())
            {
                unlockedDoor.toggleLock();
                MessageBox.Show("You may move on now");
            }
            else
            {
                MessageBox.Show("I can see nothing to use this item with here!");
            }

        }
    }

}