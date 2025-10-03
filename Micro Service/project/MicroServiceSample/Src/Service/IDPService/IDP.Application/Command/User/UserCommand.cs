using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace IDP.Application.Command.User
{
    public record UserCommand : IRequest<bool>
    {
        public UserCommand(string fullName)
        {
            FullName = fullName;
        }

        [Required(ErrorMessage = "مقدار بده حتما")]
        [MinLength(4)]
        public string FullName { get; set; }

        public string? NationalCode { get; set; }
    }
}
