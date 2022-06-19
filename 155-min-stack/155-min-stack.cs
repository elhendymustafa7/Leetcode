 public class MinStack
    {
        LinkedList<int> list;
        public MinStack()
        {
             list = new LinkedList<int>();
        }

        public void Push(int val)
        {
            list.AddLast(val);
        }

        public void Pop()
        {
            list.RemoveLast();
        }

        public int Top() => list.Last();
        

        public int GetMin()  => list.Min();
        
    }