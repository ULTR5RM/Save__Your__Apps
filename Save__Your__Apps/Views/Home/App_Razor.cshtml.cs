using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Save__Your__Apps.Work;
using Save__Your__Apps.Models;

namespace Save__Your__Apps.Views.Home
{
    [Authorize]
    public class App_Razor : PageModel
    {
       
      
            [BindProperty]
            public List<App> UserAppList { get; set; }

            public int GetCount(string identity, EventType type)
            {
                return Event_W.GetEventList(identity, type).Count;
            }

            public void OnGet()
            {
                UserAppList = new List<App>();
                UserAppList = App_W.GetAppList(HttpContext.User.Identity.Name);

            }
       
    }
}
