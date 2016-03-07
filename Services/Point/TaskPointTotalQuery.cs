using Common;
using CQRS;

namespace Services.Point
{
    public class TaskPointTotalQuery : IQuery<Score>
    {
        public Key<int> TaskId { get; set; }
    }
}