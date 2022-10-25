/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
         if (list1 == null) { return list2; }
            if (list2 == null) { return list1; }

            var arr1 = ConvetToArr(list1);
            var arr2 = ConvetToArr(list2);

            var NewArr = arr1.Concat(arr2).ToArray();

            Array.Sort(NewArr);
            return ConvetToListNode(NewArr);
    }
     public int[] ConvetToArr(ListNode x)
        {
            List<int> arr = new List<int>();
            while (x.next != null)
            {
                arr.Add(x.val);
                x = x.next;
            }
            arr.Add(x.val);
            return arr.ToArray();
        }
        //Output: [1,1,2,3,4,4]
        public ListNode ConvetToListNode(int[] NewArr)
        {
            ListNode resNode = new ListNode();
            ListNode nowNode = null;

            if (NewArr.Length > 0)
            {
                resNode.val = NewArr[0];
                ListNode lastNode = resNode;
                for (int i = 1; i < NewArr.Length; i++)
                {
                    nowNode = new ListNode();
                    nowNode.val = NewArr[i];
                    lastNode.next = nowNode;
                    lastNode = nowNode;
                }
            }
            return resNode;
        }
}