using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestAPINyam.Models.View
{
    [DataContract]
    public class OrderDish
    {
        public OrderDish(OrderedDish orderedDish)
        {
            OrderId = orderedDish.OrderId;
            DishId = orderedDish.DishId;
            ServingsNumber = orderedDish.ServingsNumber;
            StartCookingDT = orderedDish.StartCookingDT;
            EndCookingDT = orderedDish.EndCookingDT;
            NameDish = orderedDish.Dish.Name;
            Price = orderedDish.Dish.FinalPriceInCents;
            Dish = new DishView(orderedDish.Dish);
        }
        [DataMember] 
        public int OrderId { get; set; }
        [DataMember]
        public int DishId { get; set; }
        [DataMember]
        public Nullable<int> ServingsNumber { get; set; }
        [DataMember]
        public Nullable<System.DateTime> StartCookingDT { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EndCookingDT { get; set; }
        [DataMember]
        public DishView Dish { get; set; }
        [DataMember]
        public string NameDish { get; set; }
        [DataMember]
        public double Price { get; set; }

    }
}