/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        //如果给定链表有为null的,直接弹出结果
            if (l1 == null || l2 == null){ return l1 ?? l2; }

            //初始化结果链表
            ListNode res = new ListNode(0);
            //初始化结果链表光标
            ListNode cursor = res;
            //创建是否为第一次的标记
            bool isFirst = true;
            while(l1 != null && l2 != null)
            {
                //判断链表当前位置数字大小
                if(l1.val <= l2.val)
                {
                    //如果是第一次直接赋值
                    if (isFirst) { cursor.val = l1.val; } else { cursor.next = new ListNode(l1.val); }
                    //移动光标
                    l1 = l1.next;
                }
                else
                {
                    //如果是第一次直接赋值
                    if (isFirst) { cursor.val = l2.val; } else { cursor.next = new ListNode(l2.val); }
                    //移动光标
                    l2 = l2.next;
                }
                //移动光标位置
                cursor = isFirst ? cursor : cursor.next;
                isFirst = false;
            }
            cursor.next = l1 ?? l2;
            return res;
    }
}