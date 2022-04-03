using FormTask.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTask.Models
{
    public class UserHelperViewModel
    {
        public User User { get; set; }

        public IFormFile File { get; set; }
    }
}
