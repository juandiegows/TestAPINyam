using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestAPINyam.Models.View
{
    [DataContract]
    public class DishView
    {
       public DishView(Dish dish)
        {
            Id = dish.Id;
            Name = dish.Name;
            BaseServingsQuantity = dish.BaseServingsQuantity;
            CategoryId = dish.CategoryId;
            Image = dish.Image;
            RecipeLink = dish.RecipeLink;
            Description = dish.Description;
            FinalPriceInCents = dish.FinalPriceInCents;
            Category = new CategoryView(dish.Category);

        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int BaseServingsQuantity { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public string RecipeLink { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int FinalPriceInCents { get; set; }
        [DataMember]
        public CategoryView Category { get; set; }
    }
}