using WebTrader.Core.DataAccess.SqlServer;

namespace WebTrader.Core.DataAccess.Infrastructure
{
    public interface IStudentRepository : IGenericRepository<Students>
    {
        Students GetSingle(int studentId);
    }
}
