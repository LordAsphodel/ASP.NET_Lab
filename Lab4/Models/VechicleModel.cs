using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class VechicleModel
    {
        [Display(Name = "ID")]
        public Guid ID { get; set; }

        [Display(Name = "Марка")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [RegularExpression(@"[АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюяa-zA-Z'\s-]*", ErrorMessage = "Поле может содержать только буквы и пробел")]
        [StringLength(64, ErrorMessage = "Длина строки должна быть от 1 до 64 символов", MinimumLength = 1)]
        public string Company { get; set; }

        [Display(Name = "Модель")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [StringLength(64, ErrorMessage = "Длина строки должна быть от 1 до 64 символов", MinimumLength = 1)]
        public string ModelType { get; set; }


        [Display(Name = "Год выпуска")]
        [Range(1885, 2021, ErrorMessage = "Значения должны быть от 1885 до 2021")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        public int ReleaseDate { get; set; }

        [Display(Name = "Регистрационный номер")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [RegularExpression(@"([абвгдеёжзийклмнопрстуфхцчшщъыьэюя]{1})(\d{3})([абвгдеёжзийклмнопрстуфхцчшщъыьэюя]{2})$", ErrorMessage = "Необходимо ввести номер в формате: cdddcc, где с - строчная буква кириллицы. d - цифра")]
        [StringLength(6, ErrorMessage = "Необходимо ввести номер в формате: cdddcc, где с - любая буква кириллицы. d - любая цифр", MinimumLength = 6)]
        public string RegistrationNumber { get; set; }

        [Display(Name = "Регион")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [Range(1, 199, ErrorMessage = "Значения должны быть от 1 до 199")]
        public int RegistrationCity { get; set; }

        [Display(Name = "Пробег, км")]
        [Required(ErrorMessage = "Поле необходимо для запонения.")]
        [Range(0, 999999, ErrorMessage = "Значения должны быть от 0 до 999999")]
        public double Distance { get; set; }

        [Display(Name = "Ремонтировалась?")]
        public bool WasRepaired { get; set; }
    }
}
