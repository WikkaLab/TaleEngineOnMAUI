using TaleEngine.App.Models;

namespace TaleEngine.App.Services
{
    public class EventService
    {
        public List<Talk> GetTalks()
        {
            return new List<Talk>
            {
                new Talk
                {
                    Title = "Taming legacy code",
                    Description = "Vence a la bestia legacy, ¡tú puedes con todo!",
                    Places = 20,
                    Topic = "Coding",
                    Type = "Talk",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker1
                    },
                    Room = MockData.Auditorium,
                    Image = "https://secure.meetupstatic.com/photos/event/e/6/d/e/600_499799102.jpeg"
                },
                new Talk
                {
                    Title = "Your first app in .NET MAUI",
                    Description = "Aprende lo básico y crea tus apps",
                    Places = 5,
                    Topic = "Learning by doing",
                    Type = "Workshop",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker3
                    },
                    Room = MockData.Auditorium,
                    Image = "https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2022/05/maui_blazor_mobile_desktop_web.png"
                },
                new Talk
                {
                    Title = "Best practices in MAUI",
                    Description = "¿Qué son buenas prácticas y cómo se aplican en MAUI?",
                    Places = 30,
                    Topic = "Coding",
                    Type = "Talk",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker1,
                        MockData.Speaker3
                    },
                    Room = MockData.Classroom2,
                    Image = "https://camo.githubusercontent.com/5a7bd77bcfebe0d811bccceb8592112aeafa1774a8e2673fa1e9905e8deacfe9/68747470733a2f2f7777772e6d65657475702e636f6d2f5f6e6578742f696d6167652f3f75726c3d68747470732533412532462532467365637572652d636f6e74656e742e6d65657475707374617469632e636f6d253246696d61676573253246636c61737369632d6576656e7473253246353036393634323132253246363736783338302e7765627026773d3139323026713d3735"
                },
                new Talk
                {
                    Title = "Binding Libraries con .NET MAUI",
                    Description = "Añadiendo librerías para obtener todo su potencial en nuestras apps",
                    Places = 25,
                    Topic = "Coding",
                    Type = "Talk",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker2
                    },
                    Room = MockData.Classroom1,
                    Image = "https://th.bing.com/th/id/OIP.htivb45T3V865XmxuPa0PgHaEK?pid=ImgDet&rs=1"
                },
                new Talk
                {
                    Title = "Un vistazo al .NET MAUI Community Toolkit",
                    Description = "Community Toolkit, ¿qué nos ofrece y cómo agilizar el desarrollo?",
                    Places = 50,
                    Topic = "Coding",
                    Type = "Talk",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker3
                    },
                    Room = MockData.Classroom1,
                    Image = "https://th.bing.com/th/id/OIP.3evXB_334tQWfvrMWMyaHAHaFK?pid=ImgDet&rs=1"
                }
            };
        }

        public List<Room> GetRooms()
        {
            return new List<Room>
            {
                MockData.Auditorium,
                MockData.Classroom1,
                MockData.Classroom2,
                MockData.Classroom3
            };
        }

        public List<Speaker> GetSpeakers()
        {
            return new List<Speaker>
            {
                MockData.Speaker1,
                MockData.Speaker2,
                MockData.Speaker3
            };
        }
    }
}