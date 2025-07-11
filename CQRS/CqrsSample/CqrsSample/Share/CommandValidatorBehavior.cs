using System.Text;
using FluentValidation;
using MediatR;

namespace CqrsSample.Share
{
    public class CommandValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public CommandValidatorBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            //متد ولیدیت را از کلاس Validator برای همه صدا می زنیم
            //بعد ولیدیت لیست ارور ها را دریافت می کنیم و چون تو در تو است فلت می کنیم با many
            //سپس آن های که null نیستند را دریافت می کنیم
            var erros =
                _validators.Select(v => v.Validate(request))
                    .SelectMany(result => result.Errors)
                    .Where(x => x != null);

            if (erros.Any())
            {
                var stringBuilder = new StringBuilder();

                foreach (var item in erros)
                {
                    stringBuilder.Append(item.ErrorMessage);
                    stringBuilder.Append("/n");
                }

                throw new InvalidCommandException($"invalid model for {nameof(TRequest)} erros:{stringBuilder}");
            }

            var response = await next();
            return response;
        }
    }
}
