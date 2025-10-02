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
        public UserCommand(string name)
        {
            Name = name;
        }

        [Required(ErrorMessage = "مقدار بده حتما")]
        [MinLength(4)]
        public string Name { get; set; }
    }
}
