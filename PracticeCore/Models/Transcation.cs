using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCore.Models
{
    public class Transcation
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName="nvarchar(12)")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string IfscCode { get; set; }
        public int Account { get; set; }
    }
}
