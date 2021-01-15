using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework.WebApp.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        // public List<Account> Accounts { get; set; } = new List<Account>
        // {
        //     new Account
        //     {
        //         AccountNumber = "0123456789"
        //     }
        // };
    }
}