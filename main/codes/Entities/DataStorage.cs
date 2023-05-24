using codes.Models;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using System.Runtime.Serialization;

namespace codes.Entities
{
    public class DataStorage
    {
        private Dictionary<int, User> users = new Dictionary<int, User>;

        private void FileRead()
        {
            using (StreamReader reader = new StreamReader("data.csv"))
            {

            }
        }







        /*public DataStorage()
        {
            users = new List<User>();
            CreatStoragFile();
            ReadFromFile();
        }
        private void CreatStoragFile()
        {

            if (!File.Exists("data.csv"))
            {
                FileStream fileStream = File.Create("data.csv");
                fileStream.Close();
                WriteOnFile();
            }

        }
        private void ReadFromFile()
        {
            try
            {
                using (CsvReader csvReader = new CsvReader(new StreamReader(".\\FileDateStorage.csv"), CultureInfo.InvariantCulture))
                {

                    csvReader.Read();
                    csvReader.ReadHeader();
                    while (csvReader.Read())
                    {
                        users.Add(csvReader.GetRecord<User>());

                    }

                }

            }
            catch (Exception)
            {

                throw new NullReferenceException("There is problem with access to storage file!Run the aplication again");
            }

        }
        private void WriteOnFile()
        {
            try
            {
                using (CsvWriter writer = new CsvWriter(new StreamWriter(".\\FileDateStorage.csv"), CultureInfo.InvariantCulture))
                {
                    writer.WriteRecords(users);
                }

            }
            catch (Exception)
            {

                throw new NullReferenceException("There is problem with access to storage file!Run the aplication again");

            }


        }
        private bool ExistUser(User user)
        {
            foreach (var item in users)
            {
                if (item == user)
                {
                    return true;
                }
            }
            return false;
        }
        //error
        public List<User> GetAllRipository()
        {
            if (users.Count != 0)
            {
                return users;
            }
            else
            {
                throw new DataNotFoundException("not found record from data storage!");

            }

        }
        public void Update(User olduser, User newuser)
        {
            if (ExistUser(olduser))
            {
                List<User> UserTemp = users;
                users.Clear();
                foreach (var item in UserTemp)
                {
                    if (item != olduser)
                    {
                        users.Add(item);
                    }
                    else
                    {
                        users.Add(newuser);
                    }
                }

                WriteOnFile();
            }
            else
            {
                throw new ArgumentException("not found record from data storage!");

            }

        }


        public void Delete(User user)
        {
            if (ExistUser(user))
            {
                users.Remove(user);
                WriteOnFile();
            }
            else
            {
                throw new ArgumentException("not found record from data storage!");

            }

        }

        public void Insert(User user)
        {
            if (!ExistUser(user))
            {
                users.Add(user);
                WriteOnFile();
            }
            else
            {
                throw new ArgumentException("The User has insertd!can't add duplicate user");

            }
        }
    }

    [Serializable]
    internal class DataNotFoundException : Exception
    {
        public DataNotFoundException()
        {
        }

        public DataNotFoundException(string? message) : base(message)
        {
        }

        public DataNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DataNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        } */
    }
}
