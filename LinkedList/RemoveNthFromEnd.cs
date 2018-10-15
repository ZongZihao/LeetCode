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
     * 两次遍历算法
     */
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 0;
        if(head == null) return head; 
        //定义一个指针表示当前指向
        ListNode cur = head;
        while(cur != null){
            count++;
            cur = cur.next;
        }
        // //计算删除的为正数第几个
        // int num  = count - n + 1;
        //如果删除的为倒数最后一个
        if(n == count){
            return head.next;
        }
        //定义当前计算数
        int index = 1;
        //定义新的指针
        ListNode cur2 = head;
        //使指针指向待删除的前一个节点
        while(index != count - n){
            cur2 = cur2.next;
            index++;
        }
        cur2.next = cur2.next.next;
        return head;
        
    }
}