using Common;
using CQRS;

namespace Services.Point
{
    public class UserPointTotalContributedQuery : IQuery<Score>
    {
        public Key<int> UserId { get; set; }
    }
}