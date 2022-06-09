using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestAPINyam.Models.View
{
    [DataContract]
    public class CategoryView
    {
        public CategoryView(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}