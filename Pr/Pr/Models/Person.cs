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
        private string lastName;
        [MaxLength(40)]
        [Required(ErrorMessage = "Введите фамилию!")]
        public string LastName
        {
            get => lastName;
            set => lastName = value.Trim();
        }

        private string firstName;
        [MaxLength(40)]
        [Required(ErrorMessage = "Введите имя!")]
        public string FirstName
        {
            get => firstName;
            set => firstName = value.Trim();
        }

        private string middleName;
        [MaxLength(40)]
        public string MiddleName
        {
            get => middleName;
            set => middleName = value == null ? "" : value.Trim();
        }

        [Required(ErrorMessage = "Введите дату!")]
        [BirthDate(ErrorMessage = "Некорректная дата!")]
        public DateTime? BirthDate { get; set; }

    }
}
