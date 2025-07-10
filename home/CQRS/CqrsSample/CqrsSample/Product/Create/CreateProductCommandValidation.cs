

using FluentValidation;

namespace CqrsSample.Product.Create
{

    /// <summary>
    /// نمونه استفاده از کتابخانه
    /// FluentValidation
    /// </summary>
    public class CreateProductCommandValidation : AbstractValidator<CreateProductCommand>
    {

        public CreateProductCommandValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("کاربر گرامی عنوان نمی تواند خالی باشد")
                .MinimumLength(10).WithMessage("کاربر گرامی حداقل طول 10 کاراکتر می باشد");

            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(200).WithMessage("باید بزرگتر مساوی 200 باشد");
        }
    }
}
