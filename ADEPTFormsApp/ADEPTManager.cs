using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADEPTFormsApp
{
    public class ADEPTManager
    {
        public const string db_host = "bolt://localhost:7687";
        public const string db_username = "neo4j";
        public const string db_password = "password";
        public string db_connectionstatus = "";
        private Neo4JManager myManager = new Neo4JManager(db_host, db_username, db_password);

        public ADEPTManager()
        {
            if(myManager != null)
            {
                db_connectionstatus = "active";
            }
            else
            {
                db_connectionstatus = "inactive";
            }
        }

        public ADEPTNodeDTO Upsert(ADEPTNodeDTO targetNode)
        {
            ADEPTNodeDTO result = new ADEPTNodeDTO();

            if (myManager != null && string.Compare(db_connectionstatus, "active") == 0)
            {
                result = myManager.UpsertNode(targetNode);
            }

            return result;
        }

        public List<ADEPTNodeDTO> Search(ADEPTFormInputs targetInputs)
        {
            return default(List<ADEPTNodeDTO>);
        }

        public void TestNeo4J()
        {
            using (var greeter = new Neo4JManager(db_host, db_username, db_password))
            {
                greeter.PrintGreeting("hello, world");
            }
        }
    }
}
