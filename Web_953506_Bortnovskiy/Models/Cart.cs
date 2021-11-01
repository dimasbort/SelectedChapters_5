using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_953506_Bortnovskiy.Entities;

namespace Web_953506_Bortnovskiy.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }
        public Cart() { Items = new Dictionary<int, CartItem>(); }  
        
        // Количество объектов в корзине
        public int Count         
        {             
            get             
            {                 
                return Items.Sum(item => item.Value.Quantity);             
            }         
        }         
        
        // Количество калорий        
        public int Calories         
        {             
            get             
            {                 
                return Items.Sum(item => item.Value.Quantity * item.Value.Dish.Calories);
            }         
        }                  
        
        // Добавление в корзину
        public virtual void AddToCart(Dish dish)         
        { 
            // если объект есть в корзине 
            // то увеличить количество
            if (Items.ContainsKey(dish.DishId))                 
                Items[dish.DishId].Quantity++; 
            
            // иначе - добавить объект в корзину
            else                 
                Items.Add(dish.DishId, new CartItem 
                {                     
                    Dish = dish, Quantity = 1                 
                }); 
        }                  
        
        // Удалить объект из корзины
        
        public virtual void RemoveFromCart(int id)         
        {             
            Items.Remove(id);         
        }                  
        
        // Очистить корзину
        public virtual void ClearAll()         
        {             
            Items.Clear();         
        }     
    }

    // Клас описывает одну позицию в корзине
    public class CartItem     
    {                 
        public Dish Dish { get; set; }         
        public int Quantity { get; set; } 
    }
}

