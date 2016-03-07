using Common;
using CQRS;

namespace Services.Point
{
    public class UserScoreQuery : IQuery<Score>
    {
        public Key<int> UserId { get; set; }
    }
}