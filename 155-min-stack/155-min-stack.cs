public class MinStack
    {
        Stack<int> list;
        Stack<int> ListOfMin;
        public MinStack()
        {
            list = new Stack<int>();
            ListOfMin = new Stack<int>();
        }

        public void Push(int val)
        {
            int min = 0;
            list.Push(val);
            if (ListOfMin.Count == 0)
            {
                ListOfMin.Push(val);
            }
            else
            {
                min = Math.Min(val, ListOfMin.Peek());
                ListOfMin.Push(min);
            }
        }

        public void Pop()
        {
            list.Pop();
            ListOfMin.Pop();

        }

        public int Top() => list.Peek();


        public int GetMin() => ListOfMin.Peek();

    }