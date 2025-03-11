using System;
using System.ComponentModel;

namespace FitnessApp.BL.Model
{
    /// <summary>
    /// User class.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Name of the user.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender of the user.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Birth date of the user.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight of the user.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height of the user.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="gender">Gender</param>
        /// <param name="birthDate">BirthDate</param>
        /// <param name="weight">Weight</param>
        /// <param name="height">Height</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public User(string name, Gender gender, 
            DateTime birthDate, double weight, double height)
        {
            #region Check input data
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can't be empty or null", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Gender can't be null", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Impossible birth date", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Weight can't be less or equal to zero", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("Height can't be less or equal to zero", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
