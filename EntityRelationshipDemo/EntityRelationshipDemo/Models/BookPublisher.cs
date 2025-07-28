namespace EntityRelationshipDemo.Models
{
    public class BookPublisher
    {
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public Book BookNavigation { get; set; }
        public Publisher PublisherNavigation { get; set; }
    }
}
