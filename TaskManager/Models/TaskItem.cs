﻿using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskItem 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Duedate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Priority { get; set; }
        public int AssigneeId { get; set; }
        public User? Assignee { get; set; }
        public ICollection<CheckList>? CheckList { get;set; }
      
    } 
}





