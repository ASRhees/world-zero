namespace Common
{
    public class Key<T> : SemanticType<T>
    {
        public Key(T value) : base(val => true, value)
        {
            
        }
    }
}