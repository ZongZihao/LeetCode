/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    //迭代的方式反转单链表
    public ListNode ReverseList(ListNode head) {
        //如果链表长度小于等于1  则直接返回
        if(head == null || head.next == null)return head;
        
        //定义前置和当前指针
        ListNode pre = head;
        ListNode cur = head.next;
        while(cur != null){
            //定义临时指针,用来辅助反转
            ListNode tmp = cur.next;
            cur.next = pre;
            //后移前置和当前指针
            pre = cur;
            cur = tmp;
        }
        //将尾节点指针置空
        head.next = null;
        //将head设置为头结点
        head = pre;
        
        return head;
        
    }
}