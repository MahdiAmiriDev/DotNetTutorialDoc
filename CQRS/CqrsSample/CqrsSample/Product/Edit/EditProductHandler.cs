using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CqrsSample.Product.Edit
{
    public class EditProductHandler : IRequestHandler<EditProductCommand>
    {
        public Task<Unit> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            EditProduct(new DataLayer.Entities.Product()
            {
                Price = request.Price,
                Title = request.Title,
                Id = request.Id,
            });

            return Unit.Task;
        }

        public Task EditProduct(DataLayer.Entities.Product product)
        {
            Console.WriteLine("product is edited new id is {0} , name:{1}, price{2}",
            product.Id, product.Title, product.Price);

            return Task.CompletedTask;
        }
    }
}
