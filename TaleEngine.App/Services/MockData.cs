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
            Name = "Auditorium",
            Image = "https://th.bing.com/th/id/OIP.Hh5A-PBpdQQf62QVZFLI1AHaE7?pid=ImgDet&rs=1"
        };

        public static Room Classroom1 => new()
        {
            Name = "Aula 3.0.1",
            Image = "https://www.whistleblowerattorneys-blog.com/files/2014/06/College-classroom.jpg"
        };

        public static Room Classroom2 => new()
        {
            Name = "Aula 3.0.2",
            Image = "https://www.whistleblowerattorneys-blog.com/files/2014/06/College-classroom.jpg"
        };

        public static Room Classroom3 => new()
        {
            Name = "Aula 3.0.3",
            Image = "https://th.bing.com/th/id/R.58e9ad506776af8b504f7fa66dd88c93?rik=Y3dmFlsch1nTyw&riu=http%3a%2f%2fwww.ccc.edu%2fcolleges%2fwashington%2fdepartments%2fPublishingImages%2fHWCclassroom302.jpg&ehk=WM76L8ZhM8I2G1hGYSx3Br%2fpbVz1MrmZTJhUMyP2ZrI%3d&risl=&pid=ImgRaw&r=0"
        };
    }
}
