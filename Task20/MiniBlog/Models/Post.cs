using System;
using System.ComponentModel.DataAnnotations;

namespace MiniBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Заголовок обязателен.")]
        [StringLength(100, ErrorMessage = "Заголовок не может быть длиннее 100 символов.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Содержание обязательно.")]
        [MinLength(10, ErrorMessage = "Содержание должно содержать не менее 10 символов.")]
        public string Content { get; set; }

        [Display(Name = "Дата публикации")]
        public DateTime DatePosted { get; set; }
    }
}
