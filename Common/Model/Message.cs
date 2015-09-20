using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Message
    {
        public string text { get; set; }
        public string UniqueId { get; set; }
        public string ResourceUrl { get; set; }
        public string SourceName { get; set; }
        public User CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        public Score Score { get; set; }
        public List<string> Keywords { get; set; }
    }
    public class User
    {
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public string Gender { get; set; }
        
    }
    public class Score
    {
        public int Value { get; set; }
    }
    public interface ILocation
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }

    public class Subject
    {
        public string Description
        {
            get
            {
                return string.Join(",", Texts.ToArray());
            }
        }
        public List<string> Texts { get; set; }
    }
    public class AnalysedMessages
    {
        public Subject CurrentSubject { get; set; }
        public List<Message> Messages { get; set; }
    }
}
