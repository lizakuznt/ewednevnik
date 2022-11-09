using System.Data;


string ewednevnik;


namespace ewednevnik
{
    internal class Ewednevnik
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }

        static void Main(string[] args)
        {
            data1();
        }
        static void data1()
        {
            Ewednevnik ewednevnik = new Ewednevnik();
            ewednevnik.Name = "Сходить на пары";
            ewednevnik.Description = "Информационные технологии, Компьютерные сети, Философия";
            ewednevnik.Date = new DateTime(2022, 11, 09);

            Ewednevnik ewednevnik2 = new Ewednevnik();
            ewednevnik2.Name = "Сходить в книжный";
            ewednevnik2.Description = "Купить книгу";
            ewednevnik2.Date = new DateTime(2022, 11, 04);

            Ewednevnik[] allNotes = new Ewednevnik[] { ewednevnik, ewednevnik2 };



            DateTime date = new DateTime(2022, 10, 13);
            Console.Clear();
            int position = 1;
            date13menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date1viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date1viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.RightArrow)
                {
                    data14vibor();
                }

                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], 13);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], 13);
                    }
                }

            }

            static void date1viborCycle(int position, Ewednevnik[] allNotes)
            {
                Console.Clear();
                date13menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }

        private static void date1viborCycle(int position, Ewednevnik[] allNotes, DateTime date)
        {
            throw new NotImplementedException();
        }

        static void data14vibor()
        {
            Ewednevnik ewednevnik = new Ewednevnik();
            ewednevnik.Name = "Сходить к врачу";
            ewednevnik.Description = "Педиатр в 18:00";
            ewednevnik.Date = new DateTime(2022, 10, 14);

            Ewednevnik ewednevnik2 = new Ewednevnik();
            ewednevnik2.Name = "Выучить танец";
            ewednevnik2.Description = "Станцевать его на концерте";
            ewednevnik2.Date = new DateTime(2022, 10, 14);

            Ewednevnik[] allNotes = new Ewednevnik[] { ewednevnik, ewednevnik2 };



            DateTime date = new DateTime(2022, 10, 14);
            Console.Clear();
            int position = 1;
            date14menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date14viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date14viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    data15vibor();
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    data1();
                }
                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], 14);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], 14);
                    }
                }

            }

            static void date14viborCycle(int position, Ewednevnik[] allNotes)
            {
                Console.Clear();
                date14menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }
        static void data15vibor()
        {
            Ewednevnik ewednevnik = new Ewednevnik();
            ewednevnik.Name = "Погулять";
            ewednevnik.Description = "С собакой";
            ewednevnik.Date = new DateTime(2022, 10, 15);

            Ewednevnik ewednevnik2 = new Ewednevnik();
            ewednevnik2.Name = "Сделать домашку";
            ewednevnik2.Description = "Выучить КС";
            ewednevnik2.Date = new DateTime(2022, 10, 15);

            Ewednevnik[] allNotes = new Ewednevnik[] { ewednevnik, ewednevnik2 };



            DateTime date = new DateTime(2022, 10, 15);
            int data = 15;
            Console.Clear();
            int position = 1;
            date15menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date15viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date15viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    data14vibor();
                }

                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], data);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], data);
                    }
                }

            }

            static void date15viborCycle(int position, Ewednevnik[] allNotes)
            {
                Console.Clear();
                date15menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }
        static void date13menu(Ewednevnik[] allNotes)
        {
            Console.WriteLine("   Выбрана дата 13.10.2022");
            for (int i = 0; i < allNotes.Length; i++)
            {
                Console.WriteLine("   " + allNotes[i].Name);
            }
        }
        static void date14menu(Ewednevnik[] allNotes)
        {
            {
                Console.WriteLine("   Выбрана дата 14.10.2022");
                for (int i = 0; i < allNotes.Length; i++)
                {
                    Console.WriteLine("   " + allNotes[i].Name);
                }
            }
        }
        static void date15menu(Ewednevnik[] allNotes)
        {
            {
                Console.WriteLine("   Выбрана дата 15.10.2022");
                for (int i = 0; i < allNotes.Length; i++)
                {
                    Console.WriteLine("   " + allNotes[i].Name);
                }
            }
        }
        static void vivod(Ewednevnik ewednevnik, int date)
        {


            Console.Clear();
            Console.WriteLine(ewednevnik.Name);
            Console.WriteLine(ewednevnik.Description);
            Console.WriteLine(ewednevnik.Date);
            ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.Escape)
            {
                if (date == 13)
                {
                    data1();
                }
                if (date == 14)
                {
                    data14vibor();
                }
                if (date == 15)
                {
                    data15vibor();
                }
            }
        }
    }
}