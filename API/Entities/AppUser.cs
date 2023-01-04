namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } //Id - Entity Framework will automatically assume Id to be the primary key"
        /* 
        If there is no property Id then you will need explicitly specify that a certain property
        needs to be the Primary Key

        [Key] comes from namespace - System.ComponentModel.DataAnnotations
        public int TheId {get; set;}
        */
        public string UserName { get; set; }
    }
}