using System;

namespace Services.Auth
{
    [Flags]
    public enum Permission
    {
        CommentTask = 1,
        CommentCompletion = 2,
        VoteCompletion = 4,
        SupportTask = 8,
        OpposeTask = 16,
        CreateTeam = 32,
        DisbandTeam = 64,
        FlagCompletion = 128,
        FlagComment = 256,
        SuspendUser = 512,
        SuspendCompletion = 1024,
        SuspendTask = 2048,
        SuspendTeam = 4096,
        DeleteVote = 8192,
        DeleteCompletion = 16384,
        DisableTeam = 32768,
        DisableTask = 65536,
        DisableUser = 131072,
        VoteSuspendUser = 262144,
        VoteSuspendCompletion = 524288,
        VoteSuspendTask = 1048576,
        VoteDisableUser = 2097152,
        VoteDeleteCompletion = 4194304,
    }
}