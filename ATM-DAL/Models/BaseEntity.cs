using System.ComponentModel.DataAnnotations;

namespace ATM_DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
