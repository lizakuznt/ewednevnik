using System.Data;
using System;
using System.ComponentModel.Design;



namespace ewednevnik
{
    internal class Ewednevnik
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine( "ДЛЯ ЗАПУСКА ПРОГРАММЫ НАЖМИТЕ ПРОБЕЛ");
            data1();
            data2();
            data3();
        }
       public static void data1()
        {
            Ewednevnik ewednevnik = new Ewednevnik();
            ewednevnik.Name = "Сходить на пары";
            ewednevnik.Description = "Информационные технологии, Компьютерные сети, Философия";
            ewednevnik.Date = new DateTime(2022, 11, 09);

            Ewednevnik ewednevnik2 = new Ewednevnik();
            ewednevnik2.Name = "Сходить в книжный";
            ewednevnik2.Description = "Купить книгу";
            ewednevnik2.Date = new DateTime(2022, 11, 09);

            Ewednevnik[] allNotes = new Ewednevnik[] { ewednevnik, ewednevnik2 };



            DateTime date = new DateTime(2022, 11, 09);
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
                    data2();
                }

                else if (Key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {
                        vivod(allNotes[0], 09);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], 09);
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

       public static void data2()
        {
            Ewednevnik ewednevnik = new Ewednevnik();
            ewednevnik.Name = "Сходить к врачу";
            ewednevnik.Description = "Педиатр в 18:00";
            ewednevnik.Date = new DateTime(2022, 11, 28);

            Ewednevnik ewednevnik2 = new Ewednevnik();
            ewednevnik2.Name = "Выучить танец";
            ewednevnik2.Description = "Станцевать его на концерте";
            ewednevnik2.Date = new DateTime(2022, 11, 28);

            Ewednevnik[] allNotes = new Ewednevnik[] { ewednevnik, ewednevnik2 };



            DateTime date = new DateTime(2022, 11, 28);
            Console.Clear();
            int position = 1;
            date14menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date2viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date2viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    data3();
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
                        vivod(allNotes[0], 28);
                    }
                    else if (position == 2)
                    {
                        vivod(allNotes[1], 28);
                    }
                }

            }

            static void date2viborCycle(int position, Ewednevnik[] allNotes)
            {
                Console.Clear();
                date14menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }
       public static void data3()
        {
            Ewednevnik ewednevnik = new Ewednevnik();
            ewednevnik.Name = "Погулять";
            ewednevnik.Description = "С собакой";
            ewednevnik.Date = new DateTime(2022, 11, 30);

            Ewednevnik ewednevnik2 = new Ewednevnik();
            ewednevnik2.Name = "Сделать домашку";
            ewednevnik2.Description = "Выучить КС";
            ewednevnik2.Date = new DateTime(2022, 11, 30);

            Ewednevnik[] allNotes = new Ewednevnik[] { ewednevnik, ewednevnik2 };



            DateTime date = new DateTime(2022, 11, 30);
            int data = 15;
            Console.Clear();
            int position = 1;
            date13menu(allNotes);
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    date3viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    date3viborCycle(position, allNotes);
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    data2();
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

            static void date3viborCycle(int position, Ewednevnik[] allNotes)
            {
                Console.Clear();
                date15menu(allNotes);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }
        }
        static void date13menu(Ewednevnik[] allNotes)
        {
            Console.WriteLine("   Выбрана дата 09.11.2022");
            for (int i = 0; i < allNotes.Length; i++)
            {
                Console.WriteLine("   " + allNotes[i].Name);
            }
        }
        static void date14menu(Ewednevnik[] allNotes)
        {
            {
                Console.WriteLine("   Выбрана дата 28.11.2022");
                for (int i = 0; i < allNotes.Length; i++)
                {
                    Console.WriteLine("   " + allNotes[i].Name);
                }
            }
        }
        static void date15menu(Ewednevnik[] allNotes)
        {
            {
                Console.WriteLine("   Выбрана дата 30.11.2022");
                for (int i = 0; i < allNotes.Length; i++)
                {
                    Console.WriteLine("   " + allNotes[i].Name);
                }
            }
        }
       public  static void vivod(Ewednevnik ewednevnik, int date)
        {


            Console.Clear();
            Console.WriteLine(ewednevnik.Name);
            Console.WriteLine(ewednevnik.Description);
            Console.WriteLine(ewednevnik.Date);
            ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.Escape)
            {
                if (date == 09)
                {
                    data1();
                }
                if (date == 28)
                {
                    data2();
                }
                if (date == 30)
                {
                    data3();
                }
            }
        }
    }
}
