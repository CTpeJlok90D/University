namespace Tree
{
    public class Tree<T>
    {
        private Leave<T> _root;

        public Tree(T root)
        {
            _root = new Leave<T>(root);
        }

        public Leave<T> Root => _root;

        public Leave<T> this[int index]
        {
            get => _root[index];
        }
    }
}