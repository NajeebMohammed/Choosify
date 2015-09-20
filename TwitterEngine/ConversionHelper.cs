using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Tweetinvi.Core.Interfaces;

namespace Common.Helper
{
    public static class ConversionHelper
    {
        public static List<Message> ConvertITweetToIMessage(IEnumerable<ITweet> tweets)
        {
            var messages= tweets.ToList().Select(x =>
            {
                return new Message
                {
                    text = x.Text,
                    CreatedBy = new User { UserName = (x.CreatedBy!=null && !string.IsNullOrEmpty(x.CreatedBy.Name))?x.CreatedBy.Name:string.Empty },
                    ResourceUrl = "",//x.Urls[0].URL,
                    //TODO: calculate score here
                    Score = new Score { Value = 0 },
                    SourceName = "Twitter",
                    UniqueId = ""
                };
            }).ToList();
            var disMessages = messages.Select(x => x.text).Distinct();
            var xy = messages.GroupBy(x => x.text, (key, group) => group.First());
            return messages;
        }


    }
}
