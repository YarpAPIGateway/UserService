namespace UsersService.API.Infrastructure.Data;

public class UserDataTable
{
    public async Task<List<User>> UserList()
    {
        return await Task.FromResult(new List<User>
        {
            new () { Id = 2, Name = "Bob Johnson", Email = "bob.johnson@example.com", CreatedAt = DateTime.Now },
            new () { Id = 3, Name = "Charlie Brown", Email = "charlie.brown@example.com", CreatedAt = DateTime.Now },
            new () { Id = 4, Name = "Diana Prince", Email = "diana.prince@example.com", CreatedAt = DateTime.Now },
            new () { Id = 1, Name = "Alice Smith", Email = "alice.smith@example.com", CreatedAt = DateTime.Now },
            new () { Id = 5, Name = "Ethan Hunt", Email = "ethan.hunt@example.com", CreatedAt = DateTime.Now },
            new () { Id = 6, Name = "Fiona Gallagher", Email = "fiona.gallagher@example.com", CreatedAt = DateTime.Now },
            new () { Id = 7, Name = "George Washington", Email = "george.washington@example.com", CreatedAt = DateTime.Now },
            new () { Id = 8, Name = "Hannah Baker", Email = "hannah.baker@example.com", CreatedAt = DateTime.Now },
            new () { Id = 9, Name = "Isaac Asimov", Email = "isaac.asimov@example.com", CreatedAt = DateTime.Now },
            new () { Id = 10, Name = "Jessica Jones", Email = "jessica.jones@example.com", CreatedAt = DateTime.Now },
            new () { Id = 11, Name = "Kevin Bacon", Email = "kevin.bacon@example.com", CreatedAt = DateTime.Now },
            new () { Id = 12, Name = "Laura Croft", Email = "laura.croft@example.com", CreatedAt = DateTime.Now },
            new () { Id = 13, Name = "Michael Scott", Email = "michael.scott@example.com", CreatedAt = DateTime.Now },
            new () { Id = 14, Name = "Nina Simone", Email = "nina.simone@example.com", CreatedAt = DateTime.Now },
            new () { Id = 15, Name = "Oscar Isaac", Email = "oscar.isaac@example.com", CreatedAt = DateTime.Now },
            new () { Id = 16, Name = "Paul Rudd", Email = "paul.rudd@example.com", CreatedAt = DateTime.Now },
            new () { Id = 17, Name = "Quincy Jones", Email = "quincy.jones@example.com", CreatedAt = DateTime.Now },
            new () { Id = 18, Name = "Rachel Green", Email = "rachel.green@example.com", CreatedAt = DateTime.Now },
            new () { Id = 19, Name = "Steve Rogers", Email = "steve.rogers@example.com", CreatedAt = DateTime.Now },
            new () { Id = 20, Name = "Tina Fey", Email = "tina.fey@example.com", CreatedAt = DateTime.Now },
            new () { Id = 21, Name = "Ursula K. Le Guin", Email = "ursula.leguin@example.com", CreatedAt = DateTime.Now },
            new () { Id = 22, Name = "Victor Hugo", Email = "victor.hugo@example.com", CreatedAt = DateTime.Now },
            new () { Id = 23, Name = "Winston Churchill", Email = "winston.churchill@example.com", CreatedAt = DateTime.Now },
            new () { Id = 24, Name = "Xena Warrior", Email = "xena.warrior@example.com", CreatedAt = DateTime.Now },
            new () { Id = 25, Name = "Yoda Jedi", Email = "yoda.jedi@example.com", CreatedAt = DateTime.Now },
            new () { Id = 26, Name = "Zoe Saldana", Email = "zoe.saldana@example.com", CreatedAt = DateTime.Now },
            new () { Id = 27, Name = "Alice Cooper", Email = "alice.cooper@example.com", CreatedAt = DateTime.Now },
            new () { Id = 28, Name = "Bob Marley", Email = "bob.marley@example.com", CreatedAt = DateTime.Now },
            new () { Id = 29, Name = "Charlie Chaplin", Email = "charlie.chaplin@example.com", CreatedAt = DateTime.Now },
            new () { Id = 30, Name = "Daisy Ridley", Email = "daisy.ridley@example.com", CreatedAt = DateTime.Now },
            new () { Id = 31, Name = "Elon Musk", Email = "elon.musk@example.com", CreatedAt = DateTime.Now },
            new () { Id = 32, Name = "F. Scott Fitzgerald", Email = "f.scott.fitzgerald@example.com", CreatedAt = DateTime.Now },
            new () { Id = 33, Name = "George Lucas", Email = "george.lucas@example.com", CreatedAt = DateTime.Now },
            new () { Id = 34, Name = "Harrison Ford", Email = "harrison.ford@example.com", CreatedAt = DateTime.Now },
            new () { Id = 35, Name = "Iggy Azalea", Email = "iggy.azalea@example.com", CreatedAt = DateTime.Now },
            new () { Id = 36, Name = "Jack Sparrow", Email = "jack.sparrow@example.com", CreatedAt = DateTime.Now },
            new () { Id = 37, Name = "Kurt Cobain", Email = "kurt.cobain@example.com", CreatedAt = DateTime.Now },
            new () { Id = 38, Name = "Lana Del Rey", Email = "lana.delrey@example.com", CreatedAt = DateTime.Now },
            new () { Id = 39, Name = "Mia Farrow", Email = "mia.farrow@example.com", CreatedAt = DateTime.Now },
            new () { Id = 40, Name = "Nicolas Cage", Email = "nicolas.cage@example.com", CreatedAt = DateTime.Now },
            new () { Id = 41, Name = "Oprah Winfrey", Email = "oprah.winfrey@example.com", CreatedAt = DateTime.Now },
            new () { Id = 42, Name = "Pablo Picasso", Email = "pablo.picasso@example.com", CreatedAt = DateTime.Now },
            new () { Id = 43, Name = "Quentin Tarantino", Email = "quentin.tarantino@example.com", CreatedAt = DateTime.Now },
            new () { Id = 44, Name = "Rihanna Fenty", Email = "rihanna.fenty@example.com", CreatedAt = DateTime.Now },
            new () { Id = 45, Name = "Shakespeare Will", Email = "shakespeare.will@example.com", CreatedAt = DateTime.Now },
            new () { Id = 46, Name = "Tobey Maguire", Email = "tobey.maguire@example.com", CreatedAt = DateTime.Now },
            new () { Id = 47, Name = "Uma Thurman", Email = "uma.thurman@example.com", CreatedAt = DateTime.Now },
            new () { Id = 48, Name = "Viggo Mortensen", Email = "viggo.mortensen@example.com", CreatedAt = DateTime.Now },
            new () { Id = 49, Name = "Walt Disney", Email = "walt.disney@example.com", CreatedAt = DateTime.Now },
            new () { Id = 50, Name = "Xander Cage", Email = "xander.cage@example.com", CreatedAt = DateTime.Now }
        });
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
}