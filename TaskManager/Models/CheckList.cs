using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class CheckList
    {
        [Key]
        public int id {  get; set; }
        public string name { get; set; }
        public bool isDone { get; set; }
        public  int? TaskId{ get; set; }
        public  TaskItem? TaskItem{ get; set; }
    }
}
