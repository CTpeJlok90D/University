

namespace Tree
{
    public class Branch<T>
    {
        private List<Branch<T>> _branches = new();
        private T _value;

        internal Branch(T value, List<Branch<T>> leaves)
        {
            _value = value;
            _branches = leaves;
        }
        internal Branch(T value)
        {
            _value = value;
        }

        public T Value => _value;
        public int BranchCount => _branches.Count;

        public virtual void AddBranch(T value)
        {
            _branches.Add(new Branch<T>(value));
        }

        public Branch<T> this[int index]
        {
            get => _branches[index];
        }

        public override string ToString()
        {
            return ToString("_");
        }

        internal string ToString(string Layer)
        {
            string result = $"#{Value}\n";
            if (_branches.Count == 0)
            {
                return result;
            }

            foreach (Branch<T> branch in _branches)
            {
                result += Layer + $"{branch.ToString(Layer + "_")}";
            }
            return result;
        }
    }
}
