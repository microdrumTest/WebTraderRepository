using System.Linq;
using WebTrader.Core.DataAccess.Infrastructure;

namespace WebTrader.Core.DataAccess.SqlServer.Repositories
{
    public class StudentRepository : GenericRepository<DbEntities,Students>, IStudentRepository    
    {
        public Students GetSingle(int studentId)
        {
            var query = Context.Students.FirstOrDefault(x => x.Id == studentId);
            return query;
        }
    }
}