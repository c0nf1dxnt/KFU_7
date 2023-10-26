using System;

namespace Part2
{
    enum TaskCategory
    {
        SystemEngineers,
        Developors,
        Superiors
    }
    class Task
    {
        public string Description { get; set; }
        public TaskCategory Category { get; set; }

        public Task(string description, TaskCategory category)
        {
            Description = description;
            Category = category;
        }
    }
}