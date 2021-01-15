using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework.WebApp.Models
{
    public class Account
    {
        /// <summary>
        /// Just for testing... to be changed by baroniunas91
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; set; }
        
        public string AccountNumber { get; set; }
    }
}