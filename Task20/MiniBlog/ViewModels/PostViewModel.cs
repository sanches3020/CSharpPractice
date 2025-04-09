using System.ComponentModel.DataAnnotations;

namespace MiniBlog.ViewModels
{
    public class PostViewModel
    {
        [Required(ErrorMessage = "Заголовок обязателен.")]
        [StringLength(100, ErrorMessage = "Заголовок не может превышать 100 символов.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Текст обязателен.")]
        [MinLength(10, ErrorMessage = "Текст должен содержать минимум 10 символов.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Автор обязателен.")]
        [StringLength(50, ErrorMessage = "Имя автора не может превышать 50 символов.")]
        public string Author { get; set; }
    }
}