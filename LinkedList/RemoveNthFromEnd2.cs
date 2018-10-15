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
     * 一次遍历算法
     * 创建"哨兵"来消除极端情况
     */
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //创建空节点哨兵
        ListNode sentry = new ListNode(0);
        sentry.next = head;
        //定义先后两个节点
        ListNode first = sentry;
        ListNode second = sentry;
        //使两节点间隔N和节点
        int num = -1;
        while(num != n){
            first = first.next;
            num++;
        }
        //同时后移直至second为null, 即first为倒数n-1个节点
        while(first != null){
            first = first.next;
            second = second.next;
        }
        //删除
        second.next = second.next.next;
        //不可返回head!!!  链表长度为1是会删除失败,因为无法删除head指针指向唯一节点
        return sentry.next;
    }
}