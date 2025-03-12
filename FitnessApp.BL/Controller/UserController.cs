using FitnessApp.BL.Model;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace FitnessApp.BL.Controller
{
    public class UserController
    {
        public User User { get; }

        public UserController(string userName, string genderName, DateTime birthDate, double weight, double height)
        {
            //TODO: Check input data
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDate, weight, height);
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }
            //TODO: What if file is empty? 
        }

    }
}
