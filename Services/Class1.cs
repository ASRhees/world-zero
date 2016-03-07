using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TaskSummary
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public string Summary { get; set; }
        public GroupSummary Group { get; set; }
    }

    public class TaskDetail
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public GroupDetail Group { get; set; }
        public IEnumerable<Reward> Rewards { get; set; }
        public Prerequisite Prereqs { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }

    //These are for featured tasks, special events, etc.
    public class PromotionSummary
    {
        
    }

    public class PromotionDetail
    {
        
    }

    public class Prerequisite
    {
        
    }

    public class Reward
    {
        
    }

    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
    }

    public class TaskCompletionSummary
    {
        
    }

    public class TaskCompletionDetail
    {
        
    }

    public class UserSummary
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Level { get; set; }
        public AffinitySummary Afinity { get; set; }
        public double XpPercent { get; set; }
    }

    public class UserDetail
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Level { get; set; }
        public double CurrentXp { get; set; }
        public double XpToLevel { get; set; }
        public IEnumerable<UserSummary> Friends { get; set; }
        public IEnumerable<UserSummary> Rivals { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<AffinitySummary> Affinities { get; set; }
        public IEnumerable<TaskCompletionSummary> Completions { get; set; }
        public IEnumerable<TaskSummary> Starred { get; set; }
        public IEnumerable<ChallengeSummary> Challenges { get; set; }
    }

    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserIdentity : IIdentity
    {
        public string Name { get; }
        public string AuthenticationType { get; }
        public bool IsAuthenticated { get; }
        public int Id { get; }
    }

    public class UserPrincipal : IPrincipal
    {
        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }

        public IIdentity Identity { get; }
    }

    public class UserPreferences
    {
        
    }

    public class GroupDetail
    {
        public int GroupId { get; private set; }
        public string FullName { get; private set; }
        public string ShortName { get; private set; }
        public string Summary { get; private set; }
        public string Description { get; private set; }
        public Color Color { get; private set; }
        public string ClassName { get; private set; }

        private GroupDetail()
        {

        }

        public readonly GroupDetail Snide = new GroupDetail() { GroupId = 1, Color = Color.DimGray, FullName = "Society For Nihilistic Intent And Disruptive Efforts", Summary = "" },
            Humanitarian = new GroupDetail() { GroupId = 2, Color = Color.Gold, FullName = "Humanitarian Crisis", Summary = "" },
            Biome = new GroupDetail() { GroupId = 3, Color = Color.LawnGreen, FullName = "Biome Initiative" },
            Chrono = new GroupDetail() { GroupId = 4, Color = Color.MediumPurple, FullName = "Chrononautic Exxon" },
            Equivalenz = new GroupDetail() { GroupId = 5, Color = Color.OrangeRed, FullName = "Project: EquivalenZ" },
            BartPa = new GroupDetail() { GroupId = 6, Color = Color.Aqua, FullName = "BART Psychogeographical Association" },
            Aesthematics = new GroupDetail() { GroupId = 7, Color = Color.DarkRed, FullName = "University of Aesthematics" },
            Universalists = new GroupDetail() { GroupId = 8, Color = Color.WhiteSmoke, FullName = "Universalists" };
    }

    public class GroupSummary
    {
        public int GroupId { get; private set; }
        public string Name { get; private set; }
        public Color Color { get; private set; }

        private GroupSummary()
        {
            
        }

        public static readonly GroupSummary Snide = new GroupSummary() {GroupId = 1, Color = Color.DimGray, Name = "S.N.I.D.E."},
            Humanitarian = new GroupSummary() { GroupId = 2, Color = Color.Gold, Name = "Humanitarian"},
            Biome = new GroupSummary() { GroupId = 3, Color = Color.LawnGreen, Name = "Biome" },
            Chrono = new GroupSummary() { GroupId = 4, Color = Color.MediumPurple, Name = "Chrononautic" },
            Equivalenz = new GroupSummary() {GroupId = 5, Color = Color.OrangeRed, Name = "EquivalenZ" },
            BartPa = new GroupSummary() { GroupId = 6, Color = Color.Aqua, Name = "BARTpa" },
            Aesthematics = new GroupSummary() { GroupId = 7, Color = Color.DarkRed, Name = "Aesthematics"},
            Universalists = new GroupSummary() { GroupId = 8, Color = Color.WhiteSmoke, Name = "Universalists"};
    }

    public enum Group
    {
        Snide,
        Humanitarian,
        Biome,
        Chrono,
        Equivalenz,
        BartPa,
        Aesthematics,
        Universal,
    }

    public class AffinitySummary
    {
        
    }

    public class AffinityDetail
    {
        
    }

    public class Team
    {
        
    }

    public class Events
    {
        
    }

    public class BadgeSummary
    {
        
    }

    public class BadgeDetail
    {
        
    }

    public class CommentSummary
    {
        
    }

    public class CommentDetail
    {
        
    }

    public class MessageSummary
    {
        
    }

    public class MessageDetail
    {
        
    }

    public class ChallengeSummary
    {
        
    }

    public class ChallengeDetail
    {
        
    }
}
