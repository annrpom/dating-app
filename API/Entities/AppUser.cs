namespace API.Entities
{
    // Entity Framework:
    // Microsoft created an ORM (Object Relational Mapper) to abstract the work that
    // was previously done when connected to a DB -- using SQLite
    // Responsible for translating our linq query into SQL command
    /*
        DbContext.Users.Add(new User {Id=4, Name=John})
                            |
                     SQLite Provider
                            |
                INSERT INTO Users(Id, Name)
                    VALUES(4, John)
    */

    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        
    }
}