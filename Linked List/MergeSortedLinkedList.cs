public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode Sortedlist = new ListNode(0);
        ListNode Current = Sortedlist;
        while (list1 != null && list2 != null) 
        {
            if (list1.val <= list2.val)
            {
                Current.next = list1;
                list1 = list1.next;
            }
            else
            {
                Current.next = list2;
                list2 = list2.next;
            }
            Current = Current.next;
        }

        if (list1 != null) Current.next = list1;
        if (list2 != null) Current.next = list2;

        return Sortedlist.next;
    }
}