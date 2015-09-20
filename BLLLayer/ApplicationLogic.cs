using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Common.Interfaces;

namespace BLLLayer
{
    public class ApplicationLogic:IApplicationLogic
    {
        IAggregationEngine _aggregationEngine;
        public ApplicationLogic(IAggregationEngine aggregationEngine)
        {
            _aggregationEngine = aggregationEngine;
        }
        public List<AnalysedMessages> GetMessagesFromAllSources(List<Subject> filter)
        {
           return _aggregationEngine.GetMessagesFromAllSources(filter);
        }
    }
}
