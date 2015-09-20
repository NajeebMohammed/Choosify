using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Interfaces
{
    public interface IAggregationEngine
    {
        List<IDataSourceWrapperEngine> DataSources { get; }
        List<AnalysedMessages> GetMessagesFromAllSources(List<Subject> filter);
    }
}
