/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public ListNode sortList(ListNode head) {
        //如果链表长度为1直接返回
        if (head == null || head.next == null) return head;

        //获得链表中心指针
        ListNode mid = getMid(head);

        //断开链表
        ListNode tmp = head;
        while (tmp.next != mid) {
            tmp = tmp.next;
        }
        tmp.next = null;

        //排序左右两边
        ListNode left = sortList(head);
        ListNode right = sortList(mid);

        //合并输出
        ListNode res = merge(left, right);
        return res;
    }
    
    //合并两个有序链表
    public ListNode merge(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode res = new ListNode(0);
        ListNode cursor = res;

        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                cursor.next = l1;
                l1 = l1.next;
            } else {
                cursor.next = l2;
                l2 = l2.next;
            }
            cursor = cursor.next;
        }

        if (l1 == null) cursor.next = l2;
        if (l2 == null) cursor.next = l1;

        return res.next;
    }
    
    //得到链表中点
    public ListNode getMid(ListNode head){
        //拆分左右两个链表
        ListNode fast = head;
        ListNode slow = head;
        while (fast.next != null && fast.next.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        }

        if(fast.next != null){
            slow = slow.next;
        }

        return slow;
    }
}