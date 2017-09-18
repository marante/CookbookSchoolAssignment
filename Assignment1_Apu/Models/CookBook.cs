﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Apu.Models
{
    /// <summary>
    /// Cookbook model
    /// </summary>
    public class CookBook : Book
    {
        public ObservableCollection<Recipe> Recipes { get; set; } = new ObservableCollection<Recipe>();
    }
}