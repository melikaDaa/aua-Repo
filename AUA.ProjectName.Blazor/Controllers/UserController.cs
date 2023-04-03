
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        

     
   

        [HttpGet]
        public string Get()
        {
            return "Ok this is Get From Api";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Ok this is Get  From Api By Id: " + id;
        }

        [HttpDelete]
        public string Delete()
        {
            return "Ok this is Delete From Api";
        }

        [HttpPut]
        public string Put()
        {
            return "Ok this is Put From Api";
        }

        [HttpPost]
        public string Post()
        {
            return "Ok this is Post From Api";
        }
    }
}
