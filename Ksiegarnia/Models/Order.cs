﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Ksiegarnia.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Proszę podać imię i nazwisko")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Proszę podać miasto")]
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