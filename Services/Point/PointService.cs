using System;
using CQRS;

namespace Services.Point
{
    public class PointService : ICommandHandler<SubmitVotePointsCommand>, ICommandHandler<SubmitTaskPointsCommand>, ICommandHandler<SubmitBonusPointsCommand>,
        IQueryExecutor<UserScoreQuery, Score>, IQueryExecutor<UserScoreItemsQuery, PagableEnumerable<ScoreItem>>, IQueryExecutor<TaskPointTotalQuery, Score>,
        IQueryExecutor<UserPointTotalContributedQuery, Score>, IQueryExecutor<TaskPointsTotalQuery, PagableEnumerable<ScoreItem>>, IQueryExecutor<UserPointsContributedQuery, PagableEnumerable<ScoreItem>>,
    {
        public PagableEnumerable<ScoreItem> Execute(UserScoreItemsQuery query)
        {
            throw new NotImplementedException();
        }

        public void Handle(SubmitBonusPointsCommand command)
        {
            throw new NotImplementedException();
        }

        public void Handle(SubmitTaskPointsCommand command)
        {
            throw new NotImplementedException();
        }

        public void Handle(SubmitVotePointsCommand command)
        {
            throw new NotImplementedException();
        }

        public Score Execute(TaskPointTotalQuery query)
        {
            throw new NotImplementedException();
        }

        public Score Execute(UserPointTotalContributedQuery query)
        {
            throw new NotImplementedException();
        }

        public PagableEnumerable<ScoreItem> Execute(TaskPointsTotalQuery query)
        {
            throw new NotImplementedException();
        }

        public PagableEnumerable<ScoreItem> Execute(UserPointsContributedQuery query)
        {
            throw new NotImplementedException();
        }

        public Score Execute(UserScoreQuery query)
        {
            throw new NotImplementedException();
        }
    }
}