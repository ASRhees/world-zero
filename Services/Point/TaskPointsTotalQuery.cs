using Common;
using CQRS;

namespace Services.Point
{
    public class TaskPointsTotalQuery : IQuery<PagableEnumerable<ScoreItem>>
    {
        public Key<int> TaskId { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}