using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreFounditions.DTOs
{
    public class WatherDto
    {
        //non sens here can't add required and make it nullable it allways required
        [Required]
        public string? Country { get; set; }
    }
}
