public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode rev = null;
        ListNode current = head;
        ListNode nextNode;
        
        while (current != null) {
            nextNode = current.next;
            current.next = rev;
            rev = current;
            current = nextNode;
        }
        
        return rev;
    }
}