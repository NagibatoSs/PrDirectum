using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Pr.Attributes;

namespace Pr.Models
{
    [Serializable]
    public class Person
    {
        [MaxLength(40)]
        [Required(ErrorMessage ="Введите фамилию!")]
        public string LastName { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Введите имя!")]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите дату!")]
        [BirthDate(ErrorMessage = "Некорректная дата!")]
        public DateTime? BirthDate { get; set; }

    }
}
