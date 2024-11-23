using Microsoft.EntityFrameworkCore;

namespace CalcMaster.data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }


    }
}
