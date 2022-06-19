 public class MinStack
    {
        ArrayList list;
        public MinStack()
        {
             list = new ArrayList();
        }

        public void Push(int val)
        {
            list.Add(val);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count-1);
        }

        public int Top() => (int)list[list.Count - 1];
        

        public int GetMin()  => (int)list.ToArray().Min();
        
    }