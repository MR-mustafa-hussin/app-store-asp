using System.ComponentModel.DataAnnotations;

namespace app_store.Models
{
    public class SystemCode: UserActivtiy
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
