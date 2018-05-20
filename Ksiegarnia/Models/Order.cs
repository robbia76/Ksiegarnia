using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace Ksiegarnia.Models
=======
namespace BookStore.Models
>>>>>>> 31b0bdd2adb99b65805a6cf394113d6a2a0a7167
{
    public class Order
    {
        public int OrderId { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "Proszę podać imię i nazwisko")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres")]
=======
        [Required(ErrorMessage = "Пожалуйста введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вы должны указать хотя бы один адрес доставки")]
>>>>>>> 31b0bdd2adb99b65805a6cf394113d6a2a0a7167
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "Proszę podać miasto")]
=======
        [Required(ErrorMessage = "Пожалуйста укажите город, куда нужно доставить заказ")]
>>>>>>> 31b0bdd2adb99b65805a6cf394113d6a2a0a7167
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}