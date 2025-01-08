using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankMauiApp.Models
{
    public class UserInfoMoodel
    {
        public UserInfoMoodel(
             string user_username,
             string user_userPassword,
             float user_DebtBalance,
             float user_AvailableBalance,
             string user_firstName,
             string user_lastName,
            string user_type)
        {
            Username = user_username;
            UserPassword = user_userPassword;
            UserDebtBalance = user_DebtBalance;
            UserAvailableBalance = user_AvailableBalance;
            FirstName = user_firstName;
            LastName = user_lastName;
            UserType = user_type;
        }
        [Required]
        public string Username { get; set; }

        [Required]
        public string UserPassword { get; set; }

        [Required]
        public float UserDebtBalance { get; set; }

        [Required]
        public float UserAvailableBalance { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}
