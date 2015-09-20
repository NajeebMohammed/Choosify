using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Model;
using TwitterEngine;

namespace AggregationEngine
{
    public class AggregationEngine:IAggregationEngine
    {
        private IAnalysisEngine _analysisEngine;
        public AggregationEngine(IAnalysisEngine analysisEngine)
        {
            _analysisEngine = analysisEngine;
            DataSources.ForEach(x=>x.Initialize());
        }
        public List<IDataSourceWrapperEngine> DataSources
        {
            get
            {
                return new List<IDataSourceWrapperEngine>{
                    new TwitterEngine.TweetEngine(),
                };
            }
        }

        public List<AnalysedMessages> GetMessagesFromAllSources(List<Subject> filter)
        {
            var allMessages = new List<AnalysedMessages>();
            DataSources.ForEach(x =>
            {
                var messagesFromCurSource = x.FetchMessages(filter);
                if (messagesFromCurSource != null && messagesFromCurSource.Count > 0)
                    allMessages.AddRange(messagesFromCurSource);

            });
            
            return allMessages;
        }

    }
}
