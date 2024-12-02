using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
    /// <summary>
    /// Provides static methods to validate input data.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Gets or sets the line ending used in validation error messages.
        /// </summary>
        private static string lineEnd = "\n";

        public static string LineEnd
        {
            get
            {
                return lineEnd;
            }
            set
            {
                lineEnd = value;
            }
        }

        /// <summary>
        /// Checks if a value is present.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="name">The name of the field being validated.</param>
        /// <returns>An error message if the value is empty; otherwise, an empty string.</returns>
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Checks if a value can be parsed as a decimal.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="name">The name of the field being validated.</param>
        /// <returns>An error message if the value is not a valid decimal; otherwise, an empty string.</returns>
        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Checks if a value can be parsed as a 32-bit integer.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="name">The name of the field being validated.</param>
        /// <returns>An error message if the value is not a valid integer; otherwise, an empty string.</returns>
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Checks if a value is within a specified range.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="name">The name of the field being validated.</param>
        /// <param name="min">The minimum allowable value.</param>
        /// <param name="max">The maximum allowable value.</param>
        /// <returns>An error message if the value is out of range; otherwise, an empty string.</returns>
        public static string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + "." + LineEnd;
                }
            }
            return msg;
        }

        /// <summary>
        /// Checks if a value is a valid email address.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="name">The name of the field being validated.</param>
        /// <returns>An error message if the value is not a valid email address; otherwise, an empty string.</returns>
        public static string IsValidEmail(string value, string name)
        {
            string msg = "";
            if (value.IndexOf("@") == -1 || value.IndexOf(".") == -1)
            {
                msg += name + " must be a valid email address." + LineEnd;
            }
            return msg;
        }
    }
}