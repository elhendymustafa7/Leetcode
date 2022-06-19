 public class MinStack
    {
        List<int> list;
        public MinStack()
        {
             list = new List<int>();
        }

        public void Push(int val)
        {
            list.Add(val);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count - 1);
        }

        public int Top() => list[list.Count - 1];
        

        public int GetMin()  => list.Min();
        
    }

