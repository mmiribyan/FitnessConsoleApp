using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    /// <summary>
    /// Gender of the user.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Name of gender.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Create new Gender class.
        /// </summary>
        /// <param name="name"> Name of gender </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name can't be empty or null", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
