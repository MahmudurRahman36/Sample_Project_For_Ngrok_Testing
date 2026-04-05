using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sample_Project_For_Ngrok_Testing.Pages
{
    public class GreetingsModel : PageModel
    {
        public string CurrentTime { get; private set; } = string.Empty;
        public string Greeting { get; private set; } = string.Empty;

        public void OnGet()
        {
            var now = System.DateTime.Now;
            CurrentTime = now.ToString("F");

            var hour = now.Hour;
            if (hour < 12)
            {
                Greeting = "Good morning";
            }
            else if (hour < 18)
            {
                Greeting = "Good afternoon";
            }
            else
            {
                Greeting = "Good evening";
            }
        }
    }
}
