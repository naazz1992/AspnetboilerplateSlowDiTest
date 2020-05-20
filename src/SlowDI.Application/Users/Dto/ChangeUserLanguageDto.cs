using System.ComponentModel.DataAnnotations;

namespace SlowDI.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}