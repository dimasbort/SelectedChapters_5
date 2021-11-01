﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Web_953506_Bortnovskiy.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")] 
        public int DishId { get; set; } // id блюда

        [JsonPropertyName("dishName")] 
        public string DishName { get; set; } // название блюда 

    }
}
