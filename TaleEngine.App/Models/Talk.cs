namespace TaleEngine.App.Models
{
    public class Talk : BaseModel
    {
        public string Title { get; set; }
        public int Places { get; set; }
        public Room Room { get; set; }
        public List<Speaker> Speakers { get; set; }
        public string Description { get; set; }
        public string Topic { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
