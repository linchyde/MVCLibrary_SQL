using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;
using NuGet.Protocol.Core.Types;

namespace MVCLibrary.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if(context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book { Title = "Linc's C# Projects", CallNumber = "abc 2343" },
                    new Book { Title = "Liz's Cookbook", CallNumber = "agc 234" },
                    new Book { Title = "Best Games 2022", CallNumber = "a34 thg" }
                    );
                context.SaveChanges();
            }
        }
    }
}
