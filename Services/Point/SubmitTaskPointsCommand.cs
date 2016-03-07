using Common;
using CQRS;

namespace Services.Point
{
    public class SubmitTaskPointsCommand : Command
    {
        public Key<int> TaskId { get; set; }
        public Key<int> RecipientUserId { get; set; }
        public Score Points { get; set; }
        public string Description { get; set; }
    }
}