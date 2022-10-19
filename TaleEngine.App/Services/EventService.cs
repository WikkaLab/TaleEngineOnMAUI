﻿using TaleEngine.App.Models;

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
                    Title = "A title",
                    Description = "Description",
                    Places = 3,
                    Topic = "Tech topic",
                    Type = "Talk",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker1
                    },
                    Room = MockData.Auditorium,
                    Image = "https://camo.githubusercontent.com/5a7bd77bcfebe0d811bccceb8592112aeafa1774a8e2673fa1e9905e8deacfe9/68747470733a2f2f7777772e6d65657475702e636f6d2f5f6e6578742f696d6167652f3f75726c3d68747470732533412532462532467365637572652d636f6e74656e742e6d65657475707374617469632e636f6d253246696d61676573253246636c61737369632d6576656e7473253246353036393634323132253246363736783338302e7765627026773d3139323026713d3735"
                },
                new Talk
                {
                    Title = "A title",
                    Description = "Description",
                    Places = 50,
                    Topic = "Tech topic",
                    Type = "Talk",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker3
                    },
                    Room = MockData.Auditorium,
                    Image = "https://camo.githubusercontent.com/5a7bd77bcfebe0d811bccceb8592112aeafa1774a8e2673fa1e9905e8deacfe9/68747470733a2f2f7777772e6d65657475702e636f6d2f5f6e6578742f696d6167652f3f75726c3d68747470732533412532462532467365637572652d636f6e74656e742e6d65657475707374617469632e636f6d253246696d61676573253246636c61737369632d6576656e7473253246353036393634323132253246363736783338302e7765627026773d3139323026713d3735"
                },
                new Talk
                {
                    Title = "A title",
                    Description = "Description",
                    Places = 30,
                    Topic = "Tech topic",
                    Type = "Workshop",
                    Speakers = new List<Speaker>
                    {
                        MockData.Speaker1,
                        MockData.Speaker3
                    },
                    Room = MockData.Auditorium,
                    Image = "https://camo.githubusercontent.com/5a7bd77bcfebe0d811bccceb8592112aeafa1774a8e2673fa1e9905e8deacfe9/68747470733a2f2f7777772e6d65657475702e636f6d2f5f6e6578742f696d6167652f3f75726c3d68747470732533412532462532467365637572652d636f6e74656e742e6d65657475707374617469632e636f6d253246696d61676573253246636c61737369632d6576656e7473253246353036393634323132253246363736783338302e7765627026773d3139323026713d3735"
                }
            };
        }

        public List<Room> GetRooms()
        {
            return new List<Room>
            {
                MockData.Auditorium
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