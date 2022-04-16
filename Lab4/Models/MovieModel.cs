using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class MovieModel
    {
        [Display(Name = "ID")] 
        public Guid ID { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [StringLength(64, ErrorMessage = "Длина строки должна быть от 1 до 64 символов", MinimumLength = 1)]
        public string Title { get; set; }

        [DataType(DataType.Date), Display(Name = "Дата выхода")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [RegularExpression(@"[АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюяa-zA-Z'\s-]*",ErrorMessage ="Поле может содержать только буквы и пробел")]
        [StringLength(64, ErrorMessage = "Длина строки должна быть от 1 до 64 символов", MinimumLength = 1)]
        public string Genre { get; set; }

        [Display(Name = "Длительность, мин")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [Range(1, 9999,ErrorMessage = "Значения должны быть от 1 до 9999")]
        public int Duration { get; set; }

        [Display(Name = "Цена, руб")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [Range(1, 999999, ErrorMessage = "Значения должны быть от 1 до 999999")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}
