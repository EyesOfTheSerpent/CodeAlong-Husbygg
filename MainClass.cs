using CodeAlong_Husbygg.House;

namespace CodeAlong_Husbygg
{
    internal class MainClass
    {
        private static readonly List<Room> RoomsList = [];
        private static readonly string[] roomArray = ["stue", "kjøkken", "bad", "soverom"];
        private static int _FloorCounter = 0;

        public void MainMenu()
        {
            Console.Clear();
            if (_FloorCounter < 5)
            {
                Console.WriteLine("Hvilket rom ønsker du å lage?");
                Console.Write("Input: ");
                string inputUser = ValidInput();
                CreateRoom(inputUser);
            }
            else
            {
                DisplayRooms();
            }
        }

        private void CreateRoom(string inputUser)
        {
            Room Rooms = new();
            if (ValidRooms(inputUser.ToLower()) == true)
            {
                if (inputUser == "bad" && RoomExists(inputUser) == true)
                {
                    Console.WriteLine("Bare ett bad kan eksistere!");
                    Thread.Sleep(1800);
                }
                else if (inputUser == "kjøkken" && RoomExists(inputUser) == true)
                {
                    Console.WriteLine("Bare ett kjøkken kan eksistere!");
                    Thread.Sleep(1800);
                }
                else
                {
                    Rooms.SetDescription(inputUser);
                    RoomsList.Add(Rooms);
                    _FloorCounter++;
                    Console.WriteLine("Rom laget!");
                    Thread.Sleep(1800);
                }
            }
            else
            {
                Console.WriteLine("Ikke et gyldig rom.");
                Thread.Sleep(1800);
            }
            MainMenu();
        }

        private static bool ValidRooms(string inputUser)
        {
            bool RoomExists = false;
            foreach (string name in roomArray)
            {
                if (inputUser.Contains(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    RoomExists = true;
                }
            }
            return RoomExists;
        }

        private static bool RoomExists(string illegalRoom)
        {
            bool roomExists = false;
            foreach (Room room in RoomsList)
            {
                if (illegalRoom.Contains(room.GetDescription(), StringComparison.CurrentCultureIgnoreCase))
                {
                    roomExists = true;
                }
            }
            return roomExists;
        }

        private static bool RoomsExists(int index)
        {
            if(RoomsList.Find(x => x.GetDescription() == roomArray[index]) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void DisplayRooms()
        {
            Console.WriteLine("----- Alle rom generert -----");
            foreach (var room in RoomsList)
            {
                Console.WriteLine(room.GetDescription());
            }
        }

        private static string ValidInput()
        {
            string UserInput = Console.ReadLine() ?? String.Empty;
            return UserInput switch
            {
                null or "" => ValidInput(),
                _ => UserInput,
            };
        }
    }
}
