using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework.WebApp.Models
{
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public long PersonalId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; } = 0;
        public int User_id { get; set; }
    }
}
