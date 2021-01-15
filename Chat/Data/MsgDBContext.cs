using Chat.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat.Data
{
    //DbContext - определяет контекст данных, используемый для взаимодействия с базой данных.
    public class MsgDBContext : DbContext
    {

        public MsgDBContext(DbContextOptions<MsgDBContext> options) : base(options)
        {

        }

        //DbSet - набор сущностных классов, который можно использовать для создания запросов CRUD 
        public DbSet<Message> Messages { get; set; }

    }
}
