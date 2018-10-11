/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    /**
     * 快慢指针算法
    */
    public ListNode MiddleNode(ListNode head) {
        //如果长度为1 直接返回
        if(head.next == null)
            return head;
        //定义快慢指针
        ListNode slow = head;
        ListNode fast = head.next;
        
        while(fast.next != null && fast.next.next != null){
            //移动快慢指针
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow.next;
    }
}