﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema2.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public string Genre { get; set; }

        public  Director Director { get; set; }
        public int DirectorId { get; set; }




    }
}