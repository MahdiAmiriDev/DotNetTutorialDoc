using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDP.Domain.Entities.BaseEntites;

namespace IDP.Domain.Entities
{
    public class User: BaseEntity
    {
        public string? FullName { get; set; }

        public string? NationalCode { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        //کلید رمزنگاری پسورد
        public string Salt { get; set; }
    }
}
