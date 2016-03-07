using System;

namespace Common
{
    public abstract class SemanticType<T>
    {
        public T Value { get; private set; }

        protected SemanticType(Func<T, bool> validation, T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (validation == null)
            {
                throw new ArgumentNullException(nameof(validation));
            }

            if (!validation(value))
            {
                throw new ArgumentException($"Value provided for { this.GetType().Name } is invalid.");
            }

            Value = value;
        }
    }
}