﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Models
{
    public class TrainerInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
       // public List<TrainerCategory> TrainerCategories { get; set; }
       //public ICollection<GymInfo> Gyms { get; set; } //navigation property
    }
}
