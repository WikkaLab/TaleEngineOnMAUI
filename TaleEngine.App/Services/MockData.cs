using TaleEngine.App.Models;

namespace TaleEngine.App.Services
{
    public class MockData
    {
        public static Speaker Speaker1 => new()
        {
            Name = "JM L",
            Tagline = "Developer + speaker",
            Bio = "doing some talks about tech stuff!",
            Image = "https://pic.onlinewebfonts.com/svg/img_24787.png"
        };

        public static Speaker Speaker2 => new()
        {
            Name = "Marco A.B.",
            Tagline = "Developer + speaker",
            Bio = "doing some talks about tech stuff!",
            Image = "https://pic.onlinewebfonts.com/svg/img_24787.png"
        };

        public static Speaker Speaker3 => new()
        {
            Name = "Elena G",
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
