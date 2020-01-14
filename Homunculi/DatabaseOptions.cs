using System;
using System.Data;

namespace Homunculi
{
    public class DatabaseOptions
    {
        public Func<IDbConnection> connectionFactory;

    }
}
