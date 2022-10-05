﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManager.Models;

[Table("Student")]
public class Student
{
    [Key] public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    [ForeignKey("StudentId")]
    public virtual ICollection<Subject> Subjects { get; set; }
}