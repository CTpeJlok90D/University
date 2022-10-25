namespace Tree
{
    public class FloatBinarTreeBranch
    {
        private float _value;
        private List<FloatBinarTreeBranch> _branches = new();

        internal FloatBinarTreeBranch(float value)
        {
            _value = value;
        }

        public int BranchCount => _branches.Count;

        internal void AddBranch(float value)
        {
            if(BranchCount >= 2)
            {
                throw new Exception("Binar tree cannont content more then 2 Branchs");
            }
            _branches.Add(new FloatBinarTreeBranch(value));
            if (BranchCount == 2) 
            {
                SortBranches();
            }
        }

        public FloatBinarTreeBranch this[int index]
        {
            get => _branches[index];
        }

        private void SortBranches()
        {
            if (_branches[0]._value > _branches[1]._value) 
            {
                float bufer = _branches[0]._value;
                _branches[0]._value = _branches[1]._value;
                _branches[1]._value = bufer;
            }
        }

        internal void RemoveItem(int index) 
        {
            if (_branches[index].BranchCount == 0) 
            {
                _branches.RemoveAt(index);
                return;
            }

            FloatBinarTreeBranch currentBrach = this[0];
            FloatBinarTreeBranch previewBrach = this[0];
            while (currentBrach.BranchCount > 0)
            {
                previewBrach = currentBrach;
                currentBrach = currentBrach[0];
            }

            _branches[index]._value = currentBrach._value;
            previewBrach._branches.RemoveAt(0);
        }

        public override string ToString() 
        {
            return ToString("_");
        }

        internal string ToString(string Layer) 
        {
            string result = $"#{_value}\n";
            if (_branches.Count == 0)
            {
                return result;
            }

            foreach (FloatBinarTreeBranch branch in _branches)
            {
                result += Layer + $"{branch.ToString(Layer + "_")}";
            }
            return result;
        }
    }
}
