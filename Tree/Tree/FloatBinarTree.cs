namespace Tree
{
    public class FloatBinarTree
    {
        private FloatBinarTreeBranch _root;
        public FloatBinarTree(float rootValue)
        {
            _root = new FloatBinarTreeBranch(rootValue);
        }

        public FloatBinarTreeBranch Root => _root;
        
        public FloatBinarTreeBranch this[int index] 
        {
            get => _root[index];
        }

        public override string ToString()
        {
            return $"{_root}";
        }
    }
}
