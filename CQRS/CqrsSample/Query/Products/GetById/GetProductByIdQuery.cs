using MediatR;
using Query.Products.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Query.Products.GetById
{
   public record GetProductByIdQuery(int productId):IRequest<ProductDto>;
}
