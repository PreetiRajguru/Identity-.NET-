﻿using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemo.Data.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
    }

    public class StudentCreationDTO : StudentAddUpdateDTO
    {

    }

    public class StudentUpdateDTO : StudentAddUpdateDTO
    {

    }


    public abstract class StudentAddUpdateDTO
    {
        [Required(ErrorMessage = "Student name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Class is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string? Class { get; set; }
    }
}
