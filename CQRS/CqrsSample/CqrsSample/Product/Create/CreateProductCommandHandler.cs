using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace CqrsSample.Product.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        public CreateProductCommandHandler()
        {

        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //استفاده از کتابخانه fluentValidation
            //var validator = new CreateProductCommandValidation();

            //var validationResult = validator.Validate(request);

            //if (!validationResult.IsValid)
            //{
            //    var stringBuilder = new StringBuilder();

            //    foreach (var item in validationResult.Errors)
            //    {
            //        stringBuilder.Append(item.ErrorMessage);
            //    }

            //    throw new Exception($"model is not valid the error is {stringBuilder}");
            //}

            var product = new DataLayer.Entities.Product()
            {
                Id = 1,
                Price = request.Price,
                Title = request.Title,
            };

            AddProduct(product);

            var services = new ServiceCollection();
            services.AddMediatR(typeof(CreateProductCommand).Assembly);
            var provider = services.BuildServiceProvider();
            var mediator = provider.GetRequiredService<IMediator>();

            await mediator.Publish(request);

            return await Unit.Task;
        }


        public void AddProduct(DataLayer.Entities.Product product)
        {
            Console.WriteLine("new product is added name is {0} and price is {1}"
                , product.Title, product.Price);
        }
    }
}
