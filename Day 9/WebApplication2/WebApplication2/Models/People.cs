﻿namespace WebApplication2.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public People(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
