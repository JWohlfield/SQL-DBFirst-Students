using System;
using System.Collections.Generic;

#nullable disable

namespace Lab_SQLEntity_Students.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string FavoriteFood { get; set; }
    }
}
