namespace Tree
{
    public class FloatBinarTreeBranch
    {
        public float Value;
        private List<FloatBinarTreeBranch> _branches = new();

        internal FloatBinarTreeBranch(float value)
        {
            Value = value;
        }

        public int BranchCount => _branches.Count;

        public void AddBranch(float value)
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
            if (_branches[0].Value > _branches[1].Value) 
            {
                float bufer = _branches[0].Value;
                _branches[0].Value = _branches[1].Value;
                _branches[1].Value = bufer;
            }
        }

        public void RemoveItem(int index) 
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

            _branches[index].Value = currentBrach.Value;
            previewBrach._branches.RemoveAt(0);
        }

        private FloatBinarTreeBranch GetMinLastBranch() 
        {
            if (_branches.Count == 0)
            {
                return this;
            }

            FloatBinarTreeBranch currentBrach = this[0];

            while (currentBrach.BranchCount > 0) 
            {
                currentBrach = currentBrach[0];
            }

            return currentBrach;
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

            foreach (FloatBinarTreeBranch branch in _branches)
            {
                result += Layer + $"{branch.ToString(Layer + "_")}";
            }
            return result;
        }
    }
}
