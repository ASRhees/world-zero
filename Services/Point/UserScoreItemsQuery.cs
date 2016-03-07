using Common;
using CQRS;

namespace Services.Point
{
    public class UserScoreItemsQuery : IQuery<PagableEnumerable<ScoreItem>>
    {
        public Key<int> UserId { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}