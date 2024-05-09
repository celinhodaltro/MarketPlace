using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Entities;

namespace System.Providers
{
    public class UserProvider
    {
        private readonly DbContext _context;

        public UserProvider(DbContext context)
        {
            _context = context;
        }


    }
}
