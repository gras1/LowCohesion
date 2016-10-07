using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.LowCohesion
{
    public class ConnectionPool
    {
        //http://stackoverflow.com/questions/3085285/cohesion-coupling

        private List<Connection> _freeConnectionList;
        private List<Connection> _inUseConnectionList;
        private Dictionary<ConnectionPool, int> _connectionUsageCountMap;
        private Dictionary<ConnectionPool, int> _connectionUsageTimeMap;

        public Connection GetConnection
        {
            get
            {
                return new Connection();
            }
        }

        public void ReleaseConnection(Connection c)
        {
            //do something
        }

        public Dictionary<ConnectionPool, int> GetConnectionCountStats
        {
            get { return _connectionUsageCountMap; }
        }

        public Dictionary<ConnectionPool, int> GetConnectionTimeStats
        {
            get { return _connectionUsageTimeMap; }
        }

        public void PersistConnectionRequested(Connection c)
        {
            //do something
        }

        public void PersistConnectionReleased(Connection c)
        {
            //do something
        }
    }
}
