using Common;

namespace Services.Point
{
    public class ScoreItem
    {
        public Key<int> UserId { get; set; }
        public Score Score { get; set; }
        public ScoreSource Source { get; set; }
        public Key<int> TaskId { get; set; }
        public string Description { get; set; }
        public Key<int> ContributorId { get; set; }
    }
}