using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataStoragee datastorage = new DataStoragee();


            bool status = true;
            do
            {
                Console.WriteLine("1.list");
                Console.WriteLine("2.new");
                Console.WriteLine("3.delete");
                Console.WriteLine("4.edit");
                Console.Write("option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();

                        datastorage.FileRead1();
                        /*datastorage.FileRead();
                        foreach (User x in datastorage.users)
                        {
                            Console.WriteLine($"user: {x.Id},{x.Name},{x.PhoneNumber},{x.BirthDate},{x.CreateDate}");
                        }*/
                        Console.Write("0 to exit or 1 to menu: ");
                        int returnmenu = int.Parse(Console.ReadLine());
                        if (returnmenu == 0)
                            status = false;
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("name: ");
                        string name = Console.ReadLine();
                        Console.ReadKey();
                        Console.Write("phonenumber: ");
                        string phonenumber = Console.ReadLine();
                        Console.ReadKey();
                        Console.Write("birthdate: ");
                        string birthdate = Console.ReadLine();
                        Console.ReadKey();
                        Console.Write("createdate: ");
                        string createdate = Console.ReadLine();
                        Console.ReadKey();
                        DataStoragee.users.Add(new User { Id = (datastorage.count()) + 1, Name = name, PhoneNumber = phonenumber, BirthDate = birthdate, CreateDate = createdate });
                        datastorage.FileWrite();
                        Console.Write("0 to exit or 1 to menu: ");
                        returnmenu = int.Parse(Console.ReadLine());
                        if (returnmenu == 0)
                            status = false;
                        Console.Clear();
                        break;
                    case 3:

                        returnmenu = int.Parse(Console.ReadLine());
                        if (returnmenu == 0)
                            status = false;
                        Console.Clear();
                        break;
                    case 4:

                        returnmenu = int.Parse(Console.ReadLine());
                        if (returnmenu == 0)
                            status = false;
                        Console.Clear();
                        break;
                }
            }
            while (status);
        }
        public class DataStoragee
        {
            public static List<User> users = new List<User>();

            public int count()
            {
                int listlenght = users.Count();
                return listlenght;
            }
            public void FileRead1()
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = false
                };

                using var streamReader = File.OpenText("C:\\Users\\Meta\\Desktop\\maktab\\_projects\\test\\ConsoleApp1\\ConsoleApp1\\data.csv");
                using var csvReader = new CsvReader(streamReader, csvConfig);
                string value;

                while (csvReader.Read())
                {
                    for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
                    {
                        Console.Write($"{value} ");
                    }

                    Console.WriteLine();
                }
            }
            public void FileRead2()
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\Meta\\Desktop\\maktab\\_projects\\test\\ConsoleApp1\\ConsoleApp1\\data.csv"))
                {
                    string line;
                    line = reader.ReadLine();
                    for (int i = 0; i < count(); i++)
                    {
                        string[] parts = line.Split(',');
                        users.Add(new User { Id = i, Name = parts[0], PhoneNumber = parts[1], BirthDate = parts[2], CreateDate = parts[3] });
                    }
                }
            }
            public void FileWrite()
            {
                using (var writer = new StreamWriter("C:\\Users\\Meta\\Desktop\\maktab\\_projects\\test\\ConsoleApp1\\ConsoleApp1\\data.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(users);
                }
            }
        }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string BirthDate { get; set; }
            public string CreateDate { get; set; }
        }
    }
}