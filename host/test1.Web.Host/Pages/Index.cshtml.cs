using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace test1.Pages;

public class IndexModel : test1PageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
