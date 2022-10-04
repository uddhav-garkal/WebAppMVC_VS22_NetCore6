using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMVC_VS22_NetCore6.Models;

namespace WebAppMVC_VS22_NetCore6.Data
{
    public class WebAppMVC_VS22_NetCore6Context : DbContext
    {
        public WebAppMVC_VS22_NetCore6Context (DbContextOptions<WebAppMVC_VS22_NetCore6Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppMVC_VS22_NetCore6.Models.Product> Products { get; set; } = default!;
    }
}
