using Common;

namespace Services.Point
{
    public class Score : SemanticType<double>
    {
        double score;//this is the score which is stored
        public Score(double scoreToAdd) : base((val) => true, scoreToAdd)
        {
            score = scoreToAdd;
        }
        public Score()
        {
            score = 0;
        }
    }
}