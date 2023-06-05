using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_app.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async void OnGet()
        {
            for (var i = 0; i <= 30; i++)
            {
                Categories.Add(
                    new Category(i,
                    $"Categoria {i}",
                    i * 13.95M
                    ));
            }
        }

        public record Category(int Id, string Title, decimal Price);
    }
}
