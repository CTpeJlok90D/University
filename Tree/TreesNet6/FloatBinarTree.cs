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

        public void Add(float value)
        {
            _root.AddBranch(value);
        }

        public FloatBinarTreeBranch? FindBranch(float value)
        {
            foreach (FloatBinarTreeBranch branch in ToList())
            {
                if (branch.Value == value)
                {
                    return branch;
                }
            }
            return null;
        }

        public List<FloatBinarTreeBranch> ToList()
        {
            List<FloatBinarTreeBranch> result = new();
            if (_root.HaveRightBrench)
            {
                result.Add(_root.RightBranch);
                _root.RightBranch.AddAllBranchesToList(result);
            }
            if (_root.HaveLeftBrench)
            {
                result.Add(_root.LeftBranch);
                _root.LeftBranch.AddAllBranchesToList(result);
            }

            return result;
        }

        public void AddRange(float[] values)
        {
            foreach (float value in values)
            {
                Add(value);
            }
        }
    }
}
