namespace MazeGame
{
    public class Maze
    {
        private Room startRoom;
        private Room winningRoom;
        private Room losingRoom;
        private Room fightingRoom;
        private Room fatherRoom;
        private Room princessRoom;

        public Maze()
        {
            Room Start = new Room("Start");
            Room TortureChamber1 = new Room("Torture Chamber");
            Room TortureChamber2 = new Room("Torture Chamber");
            Room TortureChamber3 = new Room("Torture Chamber");
            Room Hallway1 = new Room("Hallway");
            Room Kitchen = new Room("Kitchen");
            Room DressingRoom = new Room("Dressing Room");
            Room BedChamber = new Room("Bed Chamber");
            Room BotanicalGarden = new Room("Botanical Garden");
            Room Chapel = new Room("Chapel");
            Room Storage = new Room("Storage");
            Room Cabinet = new Room("Cabinet");
            Room Hallway2 = new Room("Hallway");
            Room DiningRoom = new Room("Dining Room");
            Room Toilet = new Room("Toilet");
            Room End = new Room("End");
            Room Balcony = new Room("Balcony");
            Room Armory = new Room("Armory");

            Start.setConnectedRooms(TortureChamber3, Hallway1, TortureChamber2, TortureChamber1);
            TortureChamber1.setConnectedRooms(null, Start, null, null);
            TortureChamber2.setConnectedRooms(Start, null, null, null);
            TortureChamber3.setConnectedRooms(null, null, Start, null);
            Hallway1.setConnectedRooms(null, Kitchen, null, Start);
            Kitchen.setConnectedRooms(null, Balcony, BotanicalGarden, Hallway1);
            Balcony.setConnectedRooms(null, null, Armory, Kitchen);
            Armory.setConnectedRooms(Balcony, null, null, BotanicalGarden);
            BedChamber.setConnectedRooms(null, BotanicalGarden, DressingRoom, null);
            DressingRoom.setConnectedRooms(BedChamber, Chapel, null, null);
            BotanicalGarden.setConnectedRooms(Kitchen, Armory, Chapel, BedChamber);
            Chapel.setConnectedRooms(BotanicalGarden, null, null, DressingRoom);
            Storage.setConnectedRooms(null, null, Cabinet, null);
            Cabinet.setConnectedRooms(Storage, null, Hallway2, null);
            Hallway2.setConnectedRooms(Cabinet, null, null, null);
            DiningRoom.setConnectedRooms(null, null, null, null);
            Toilet.setConnectedRooms(null, null, null, null);
            End.setConnectedRooms(null, null, null, null);

            Door redDoor = new Door("RedDoor", false, Hallway1, 'N', BedChamber, 'S');
            Door blueDoor = new Door("BlueDoor", false, Hallway2, 'E', DiningRoom, 'W');
            Door yellowDoor = new Door("Yellow", false, Chapel, 'W', Storage, 'E');
            Door blackDoor = new Door("Black", false, Toilet, 'W', DiningRoom, 'E');
            Door pinkDoor = new Door("Pink", false, End, 'N', Toilet, 'S');


            Key redKey = new Key("RedKey", true, redDoor);
            Key blueKey = new Key("BlueKey", true, blueDoor);
            Key yellowPajamas = new Key("Pajamas", true, yellowDoor);
            Key ring = new Key("Ring", true, blackDoor);
            Key toiletpaper = new Key("Toilet paper", true, pinkDoor);


            startRoom = Start;
            winningRoom = End;
            fightingRoom = Chapel;
            fatherRoom = DiningRoom;
            princessRoom = Toilet;

            losingRoom = TortureChamber1;
            losingRoom = TortureChamber2;
            losingRoom = TortureChamber3;

            Item Key = new Item("Key", true);
            Item Apron = new Item("Apron", true);
            Item Neckless = new Item("Neckless", true);
            Item Bracelet = new Item("Bracelet", true);
            Item Coin = new Item("Coin", true);
            Item Bomb = new Item("Bomb", false);
            Item Sword = new Item("Sword", true);
            Item Ring = new Item("Ring", true);
            Item Lamp = new Item("Lamp", true);
            Item BrickWall = new Item("Brick Wall", false);
            Item Pen = new Item("Pen", true);
            Item Flower = new Item("Flower", true);
            Item Pajamas = new Item("Pajamas", true);
            Item Brother = new Item("The princess's brother", false);
            Item Father = new Item("The princess's father", false);
            WoodenStick stick1 = new WoodenStick();
            Book book1 = new Book();
            Princess princess1 = new Princess();

            Start.addContent(book1);
            Kitchen.addContent(Apron);
            DressingRoom.addContent(Neckless);
            DressingRoom.addContent(Bracelet);
            BedChamber.addContent(yellowPajamas);
            BedChamber.addContent(Lamp);
            BedChamber.addContent(Pen);
            BedChamber.addContent(Coin);
            Chapel.addContent(Brother);
            Storage.addContent(toiletpaper);
            Storage.addContent(BrickWall);
            Cabinet.addContent(ring);
            BotanicalGarden.addContent(stick1);
            BotanicalGarden.addContent(Flower);
            BotanicalGarden.addContent(Sword);
            Hallway1.addContent(redKey);
            Hallway2.addContent(blueKey);
            Hallway1.addContent(redDoor);
            BedChamber.addContent(redDoor);
            Hallway1.addContent(blueDoor);
            DiningRoom.addContent(blueDoor);
            DiningRoom.addContent(Father);
            Toilet.addContent(princess1);
            Armory.addContent(Bomb);
        }


        public Room getStartRoom()
        {
            return this.startRoom;
        }

        public Room getWinningRoom()
        {
            return this.winningRoom;
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }

        public Room getFightingRoom()
        {
            return this.fightingRoom;
        }

        public Room getfatherRoom()
        {
            return this.fatherRoom;
        }

        public Room getprincessRoom()
        {
            return this.princessRoom;
        }

    }
}
