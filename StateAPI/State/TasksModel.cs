using StateAPI.State.Enum;

namespace StateAPI.State
{
    public class TasksModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StateTask State { get; set; }
    }
}
