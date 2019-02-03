﻿using Application.Core.Entities;

namespace Application.Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId  { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice  { get; set; }
        public short UnitsInStock { get; set; }
    }
}