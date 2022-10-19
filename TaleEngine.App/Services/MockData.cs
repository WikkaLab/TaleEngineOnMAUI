using TaleEngine.App.Models;

namespace TaleEngine.App.Services
{
    public class MockData
    {
        public static Speaker Speaker1 => new()
        {
            Name = "Ashlyn Spencer",
            Tagline = "Developer + speaker",
            Bio = "doing some talks about tech stuff!",
            Image = "https://pic.onlinewebfonts.com/svg/img_24787.png"
        };

        public static Speaker Speaker2 => new()
        {
            Name = "Damon Rosembaum",
            Tagline = "Developer + speaker",
            Bio = "doing some talks about tech stuff!",
            Image = "https://pic.onlinewebfonts.com/svg/img_24787.png"
        };

        public static Speaker Speaker3 => new()
        {
            Name = "Jannie Bernhard",
            Tagline = "Developer + speaker",
            Bio = "doing some talks about tech stuff!",
            Image = "https://pic.onlinewebfonts.com/svg/img_24787.png"
        };

        public static Room Auditorium => new()
        {
            Name = "Auditorium"
        };
    }
}
