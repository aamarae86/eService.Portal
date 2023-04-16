using System.ComponentModel.DataAnnotations;

namespace eService.Portal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}