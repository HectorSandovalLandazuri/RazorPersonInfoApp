using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace RazorPersonInfo.Pages
{
    public class AddressesModel : PageModel
    {
        [BindProperty]
		public AddressModel Address { get; set; }

		public void OnGet()
        {
        }
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			return RedirectToPage("./Index");

		}

	}
}
