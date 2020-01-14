using System.Data;

namespace Homunculi
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection CreateDatabase();
    }
}
