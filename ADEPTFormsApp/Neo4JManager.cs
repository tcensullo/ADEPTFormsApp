using Neo4j.Driver.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADEPTFormsApp
{
    public class Neo4JManager : IDisposable
    {
        private readonly IDriver myDriver;

        public Neo4JManager(string uri, string user, string password)
        {
            myDriver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        public void PrintGreeting(string message)
        {
            using (var session = myDriver.Session())
            {
                var greeting = session.WriteTransaction(tx =>
                {
                    var result = tx.Run("CREATE (a:Greeting) " +
                                        "SET a.message = $message " +
                                        "RETURN a.message + ', from node ' + id(a)",
                        new { message });
                    return result.Single()[0].As<string>();
                });
                Console.WriteLine(greeting);
            }
        }

        public ADEPTNodeDTO UpsertNode(ADEPTNodeDTO targetNode)
        {
            ADEPTNodeDTO resultNode = new ADEPTNodeDTO();
            using (var session = myDriver.Session())
            {
                    var symbol = session.WriteTransaction(tx =>
                    {
                        string baseQuery = "MERGE(n: ADEPTNode {{symbol:'{0}'}}) ON CREATE SET n.counter = 0, n.created = timestamp() ON MATCH SET n.counter = coalesce(n.counter, 0) + 1, n.accessTime = timestamp()";
                        string targetInsertQuery = string.Format(baseQuery, targetNode.Symbol);
                        var result = tx.Run(targetInsertQuery);
                        return (result != null && result.Count() > 0) ? result.Single()[0].As<string>() : null;
                    });
                    resultNode.Symbol = symbol;
                    Console.WriteLine(symbol);               
            }

            return resultNode;
        }
        public void UpsertRelationship() { }

        /// <summary>
        /// This function encapsulates the get/read node method...a generic call will return all in the db, query parameters will give filters
        /// right now, returns list of symbols as strings
        /// </summary>
        /// <param name="targetSymbol">target symbol, if desired</param>
        public List<string> GetNodes(string targetSymbol = null)
        {
            string targetReadQuery = string.Empty;
            List<string> symbols = new List<string>();

            using (var session = myDriver.Session())
            {
                //first, try to get a node with that target symbol
                var node = session.ReadTransaction(tx =>
                {
                    if (!string.IsNullOrEmpty(targetSymbol))
                    {
                        targetReadQuery = string.Format("MATCH (a:ADEPTNode) WHERE a.symbol = {0} RETURN a.symbol", null);
                    }
                    else //get all
                    {
                        targetReadQuery = string.Format("MATCH (a:ADEPTNode) RETURN a.symbol", null);
                    }

                    var result = tx.Run(targetReadQuery);
                    return result.Select(record => record[0].As<string>()).ToList();
                });
            }

            return symbols;
        }

    private void ParseList(EnvironmentVariableTarget target) { }
        public void GetRelationships() { }
        public void DeleteNode() { }
        public void DeleteRelationship() { }

        public void Dispose()
        {
            myDriver?.Dispose();
        }
    }
}
