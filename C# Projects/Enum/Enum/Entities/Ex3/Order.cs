using Enumeration.Entities.Enums;
using Enumeration.Entities.Ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration.Entities.Ex3
{
    internal class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; } = new Client();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double Total()
        {

            double sum = 0;

            foreach(OrderItem item in OrderItem)
            {
                sum += item.SubTotal();
            }

            return sum;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment.ToString()}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach(OrderItem orderItem in OrderItem)
            {

                sb.AppendLine($"{orderItem.Product.Name}, ${orderItem.Price}, Quantity: {orderItem.Quantity}, Subtotal: ${orderItem.Product.Price}");

            }

            return sb.ToString();

        }

    }
}
