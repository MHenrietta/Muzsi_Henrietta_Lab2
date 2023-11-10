namespace Muzsi_Henrietta_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string AuthorFullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public ICollection<Book>? Books { get; set; } //navigation property

    }
}


