namespace EntityRelationshipDemo.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Author AuthorNavigation { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<BookPublisher> BookPublishersNavigation { get; set; }


    }
}
