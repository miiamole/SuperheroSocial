using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocial.Pages
{
	public class ChangeModel : PageModel
	{
		[BindProperty]
		public List<SuperheroModel> heroes { get; set; }
		public void OnGet()
		{



		}


		public IActionResult OnPut(int id, SuperheroModel updatedSuperhero)
		{
			var item = heroes.FirstOrDefault(s => s.Id == id);
			if (item == null)
			{
				return Page();
			}
			else
			{
				item.Id = updatedSuperhero.Id;
				item.Name = updatedSuperhero.Name;
				item.SecretIdentity = updatedSuperhero.SecretIdentity;
				item.SuperPower = updatedSuperhero.SuperPower;

				return RedirectToPage("/index");
			}

		}
	}
}
