using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsSample.Product.Create;
using MediatR;

namespace CqrsSample.Product.EventHandler
{
    public class CreateProductEventHandler: INotificationHandler<CreateProductCommand>
    {
        public Task Handle(CreateProductCommand notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("your product created and was save successfully in dataBase name:{0} and other:{1}",
                notification.Price,notification.Title);

            return Task.CompletedTask;
        }
    }
}
