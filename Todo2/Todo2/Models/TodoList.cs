namespace Todo2.Models
{
    public class TodoList
    {

        public Guid TodoID { get; set; }
        public string Name { get; set; }

        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public bool Enable { get; set; }

        public int Orders { get; set; }

        public string InsertEmployeeId { get; set; }

        public string UpdateEmployeeID { get; set; }
    }
}
