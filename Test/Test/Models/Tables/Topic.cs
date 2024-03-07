namespace Test.Models.Tables
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public Course Course { get; set; }
    }
}
