namespace Tree
{
    public class Leave<T>
    {
        private List<Leave<T>> _leaves = new();
        T _value;

        internal Leave(T value, List<Leave<T>> leaves)
        {
            _value = value;
            _leaves = leaves;
        }
        internal Leave(T value)
        {
            _value = value;
        }

        public T Value => _value;

        public void AddLeave(T value)
        {
            _leaves.Add(new Leave<T>(value));
        }
        public Leave<T> this[int index]
        {
            get => _leaves[index];
        }
    }
}
