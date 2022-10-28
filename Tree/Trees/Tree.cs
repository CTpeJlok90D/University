namespace Tree
{
    public class Tree<T>
    {
        private Branch<T> _root;

        public Tree(T root)
        {
            _root = new Branch<T>(root);
        }

        public Branch<T> Root => _root;

        public Branch<T> this[int index]
        {
            get => _root[index];
        }

        public override string ToString()
        {
            return $"{_root}";
        }
    }
}