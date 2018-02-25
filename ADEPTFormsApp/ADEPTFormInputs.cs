using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADEPTFormsApp
{
    public class ADEPTFormInputs
    {
        public string Symbol { get; set; }
        public string Thing { get; set; }

        public ADEPTNodeDTO ToNodeDTO()
        {
            ADEPTNodeDTO targetNode = new ADEPTNodeDTO();

            targetNode.Symbol = Symbol;
            targetNode.Thing = Thing;

            return targetNode;
        }
    }
}
