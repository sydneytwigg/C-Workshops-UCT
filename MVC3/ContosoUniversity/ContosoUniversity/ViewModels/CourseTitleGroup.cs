using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    public class CourseTitleGroup
    {
        public string Title { get; set; }
        public int StudentCount { get; set; }
    }
}