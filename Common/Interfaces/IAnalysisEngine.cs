using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Interfaces
{
    public interface IAnalysisEngine
    {
        List<AnalysedMessages> AnalyzeMessages(List<Message> messages);
    }
}
