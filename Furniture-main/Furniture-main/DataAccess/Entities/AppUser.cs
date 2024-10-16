using Microsoft.AspNetCore.Identity;

namespace Furniture.DataAccess.Entities
{
    public class AppUser:IdentityUser<int> // primary key değeri int olarak verdik 
    {
        public string NameSurname { get; set; }
        public string? ImageUrl { get; set; }

    }
}
