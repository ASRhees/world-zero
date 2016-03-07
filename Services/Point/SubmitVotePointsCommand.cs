using Common;
using CQRS;

namespace Services.Point
{
    public class SubmitVotePointsCommand : Command
    {
        public Key<int> VotingUserId { get; set; }
        public Key<int> TaskId { get; set; }
        public Key<int> RecipientUserId { get; set; }
        public Score Points { get; set; }
        public string Description { get; set; }
    }
}