﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsSample.Product.Create
{
    public class CreateProductCommand : IRequest, INotification
    {

        public CreateProductCommand(string title, int price)
        {
            Title = title;
            Price = price;
        }
        public string Title { get; set; }

        public int Price { get; set; }
    }
}
