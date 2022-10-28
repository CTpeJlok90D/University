using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tree
{
    public class FloatBinarTreeBranch
    {
        private float _value;
        private FloatBinarTreeBranch _parent;
        private FloatBinarTreeBranch[] _branches = new FloatBinarTreeBranch[] { null,null };

        internal FloatBinarTreeBranch(float value, FloatBinarTreeBranch parent = null)
        {
            _value = value;
            _parent = parent;
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
        public float Value => _value;
        public FloatBinarTreeBranch Parent => _parent;

        internal void AddBranch(float value)
        {
            if(_branches[value > _value ? 1 : 0] != null)
            {
                _branches[value > _value ? 1 : 0].AddBranch(value);
                return;
            }

            _branches[value > _value ? 1 : 0] = new FloatBinarTreeBranch(value, this);
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
            while (currentBrach.HaveLeftBrench)
            {
                currentBrach = currentBrach.LeftBranch;
            }
            removingItem._value = currentBrach._value;
            removingItem.Parent._branches[0] = currentBrach.RightBranch;
        }

        public void RemoveIt()
        {
            if (Parent == null)
            {
                throw new Exception("You cant remove root");
            }
            Parent.RemoveItem(Parent._branches[0] == this ? 0 : 1);
        }

        public override string ToString() 
        {
            return ToString("_");
        }

        internal void AddAllBranchesToList(List<FloatBinarTreeBranch> previewBranches)
        {
            foreach (FloatBinarTreeBranch branch in _branches)
            {
                if (branch != null)
                {
                    previewBranches.Add(branch);
                    branch.AddAllBranchesToList(previewBranches);
                }
            }
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
