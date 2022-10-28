namespace Tree
{
    public class FloatBinarTreeBranch
    {
        private float _value;
        private FloatBinarTreeBranch[] _branches = new FloatBinarTreeBranch[] { null,null };

        internal FloatBinarTreeBranch(float value)
        {
            _value = value;
        }

        public FloatBinarTreeBranch this[int index]
        {
            get => _branches[index];
        }
        public int BranchCount
        {
            get
            {
                int result = 0;
                foreach (FloatBinarTreeBranch branch in _branches)
                {
                    if (branch != null)
                    {
                        result++;
                    }
                }
                return result;
            }
        }

        public bool IsFull => BranchCount == 2;
        public bool IsEmpty => BranchCount == 0;
        public bool HaveLeftBrench => _branches[0] != null;
        public bool HaveRightBrench => _branches[1] != null;
        public FloatBinarTreeBranch LeftBranch => _branches[0];
        public FloatBinarTreeBranch RightBranch => _branches[1];

        internal void AddBranch(float value)
        {
            if(_branches[value > _value ? 1 : 0] != null)
            {
                _branches[value > _value ? 1 : 0].AddBranch(value);
                return;
            }

            _branches[value > _value ? 1 : 0] = new FloatBinarTreeBranch(value);
        }

        public void RemoveItem(int index) 
        {
            if (_branches[index].IsEmpty) 
            {
                _branches[index] = null;
                return;
            }

            if (_branches[index].HaveLeftBrench == false)
            {
                _branches[index] = _branches[index].RightBranch;
                return;
            }

            FloatBinarTreeBranch removingItem = this[index];

            FloatBinarTreeBranch currentBrach = removingItem.RightBranch;
            FloatBinarTreeBranch parentBranch = removingItem;
            while (currentBrach.HaveLeftBrench)
            {
                parentBranch = currentBrach;
                currentBrach = currentBrach.LeftBranch;
            }
            removingItem._value = currentBrach._value;
            parentBranch._branches[0] = currentBrach.RightBranch;
        }

        public override string ToString() 
        {
            return ToString("_");
        }

        private string ToString(string Layer) 
        {
            string result = $"#{_value}\n";
            if (BranchCount == 0)
            {
                return result;
            }

            foreach (FloatBinarTreeBranch branch in _branches)
            {
                if (branch != null)
                {
                    result += Layer + $"{branch.ToString(Layer + "_")}";
                }
            }
            return result;
        }
    }
}
