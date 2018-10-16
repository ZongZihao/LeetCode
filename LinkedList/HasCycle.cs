/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    //暴力法
    //空间复杂度 O(n)
    //时间复杂度 O(n²)
    public bool HasCycle(ListNode head) {
        //将遍历过的节点添加到数组中
        var list = new List<ListNode>();
        var cur = head;
        while(cur != null){
            list.Add(cur);
            if(list.Contains(cur.next)) return true;
            cur = cur.next;
        }
        return false;
    }

    //暴力法(保存在散列表)
    //空间复杂度 O(n)
    //时间复杂度 O(n)
    public bool HasCycle2(LIstNode head){
        var hashTable = new HashSet<ListNode>();
        var cur = head;
        while (cur != null)
        {
            hashTable.Add(cur);
            if (hashTable.Contains(cur.next)) return true;
            cur = cur.next;
        }
        return false;
    }
}