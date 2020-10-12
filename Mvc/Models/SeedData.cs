using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Mvc.Data;

namespace Mvc.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcContext>>()))
            {
                // Look for any movies.
                if (context.UserModel.Any())
                {
                    return;   // DB has been seeded
                }
                context.SaveChanges();
            }
        }
    }
}
