using MediatR;


namespace CqrsSample.Product.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        public CreateProductCommandHandler()
        {

        }

        public Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            AddProduct(new DataLayer.Entities.Product()
            {
                Id = 1,
                Price = request.Price,
                Title = request.Title,
            });

            return Unit.Task;
        }


        public void AddProduct(DataLayer.Entities.Product product)
        {
            Console.WriteLine("new product is added name is {0} and price is {1}"
                , product.Title, product.Price);
        }
    }
}
