using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

public class IndexModel : PageModel
{
    public string Avatar { get; set; }

    public string Login { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public void OnGet()
    {
        if (User.Identity.IsAuthenticated)
        {
            Name = User.FindFirst(c => c.Type == ClaimTypes.Name)?.Value;
            //GitHubLogin = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
            //GitHubUrl = User.FindFirst(c => c.Type == "urn:github:url")?.Value;
            //GitHubAvatar = User.FindFirst(c => c.Type == "urn:github:avatar")?.Value;
        }
    }
}