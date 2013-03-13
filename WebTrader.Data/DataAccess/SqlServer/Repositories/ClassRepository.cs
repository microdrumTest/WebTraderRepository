using System.Linq;
using WebTrader.Core.Abstract.Infrastructure;
using WebTrader.Core.DataAccess.Infrastructure;

namespace WebTrader.Core.DataAccess.SqlServer
{
    public class ClassRepository : GenericRepository<StudentsEntities, Class>, IClassRepository
    {
        public Class GetSingle(int classId)
        {
            var query = Context.Classes.FirstOrDefault(x => x.Id == classId);
            return query;
        }
    }
}