using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsSample.Product.Edit
{
    public class EditProductCommand:IRequest
    {

        public EditProductCommand(int id, string title, int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
