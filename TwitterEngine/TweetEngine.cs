using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core.Credentials;
using Tweetinvi.Credentials;
using Common.Interfaces;
using Common.Model;
using Message = Common.Model.Message;
using Tweetinvi.Core.Interfaces.Parameters;
using Common.Helper;

namespace TwitterEngine
{
    public class TweetEngine:IDataSourceWrapperEngine
    {
        public void Initialize()
        {
            Auth.SetApplicationOnlyCredentials("phqInqDySI4dbQy1Tvy82lqVF", "UrmxZreg8gHm9wLLaWK5XvbZqzrWHOrIxXlIOoFyvWZPwRjhFS", "AAAAAAAAAAAAAAAAAAAAAOe7hAAAAAAAbKrESta0FoPsAdVRhBhVHEyfu38%3D3nd6TCxwPI9dGXn0S4NvJlLW51oIP5oAbLoVMtVw9MFnTHmA0P");
        }
        public List<AnalysedMessages> FetchMessages(List<Subject> filter)
        {
            var analysedMessages = new List<AnalysedMessages>();
            foreach(Subject sub in filter)
            {
                var messagesHolder = new List<Message>();
                AnalysedMessages currentMessageSet = new AnalysedMessages();
                currentMessageSet.CurrentSubject = sub;
                sub.Texts.ForEach(x =>
                {
                    messagesHolder.AddRange(QueryTwitter(x));
                });
                currentMessageSet.Messages = messagesHolder;
                analysedMessages.Add(currentMessageSet);
            }
            return analysedMessages;
        }

        private List<Message> QueryTwitter(string searchTerm)
        {
            var messages = new List<Message>();
            foreach(var mood in Mood.MoodTypes)
            {
                var param = new Tweetinvi.Core.Parameters.TweetSearchParameters(searchTerm );
                param.MaximumNumberOfResults = 500;
                messages.AddRange(ConversionHelper.ConvertITweetToIMessage(Search.SearchTweets(param)));
            }
            return messages;
        }

        


        
        
    }
}
