using System.ComponentModel.DataAnnotations;

namespace Exceed.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}