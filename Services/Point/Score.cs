using Common;

namespace Services.Point
{
    public class Score : SemanticType<double>
    {
        public Score(double score) : base((val) => true, score)
        {
            
        }
    }
}