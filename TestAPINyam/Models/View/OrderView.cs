using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestAPINyam.Models.View
{
    [DataContract]
    public class OrderView
    {
        public OrderView(Order order)
        {
            Id = order.Id;
            CreatedDT = order.CreatedDT;
            ClientId = order.ClientId;
            AppointedDT = order.AppointedDT;
            AppointedAddress = order.AppointedAddress;
            NameClient = order.Client.Name;
            Dishes = order.OrderedDishes.Select(x => new OrderDish(x)).ToList();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public System.DateTime CreatedDT { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public System.DateTime AppointedDT { get; set; }
        [DataMember]
        public string AppointedAddress { get; set; }
        [DataMember]

        public string NameClient { get; set; }
        [DataMember]

        public List<OrderDish> Dishes { get; set; }

    }
}