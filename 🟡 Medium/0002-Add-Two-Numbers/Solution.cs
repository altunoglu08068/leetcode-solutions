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

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0); // Geçici baş düğüm.
        ListNode current = dummyHead; // İşaretçim.

        int carry = 0; // Elde değerini tutuyorum.

        // Bağlı listelerde eleman varsa veya eldemiz varsa döngüyü devam ettiriyorum.
        while (l1 != null || l2 != null || carry > 0)
        {
            int sum = carry; // Önceki basamaktan gelen elde değerini yeni toplama dahil ediyorum.

            if (l1 != null) // Eğer bağlı listede eleman varsa...
            {
                sum += l1.val; // Değeri toplama ata.
                l1 = l1.next; // Bir sonraki düğüme geç.
            }

            if (l2 != null) // Eğer bağlı listede eleman varsa...
            {
                sum += l2.val; // Değeri toplama ata.
                l2 = l2.next; // Bir sonraki düğüme geç.
            }

            carry = sum / 10; // Toplamdan elde etmek için 10'a bölüyorum.
            current.next = new ListNode(sum % 10); // Birler basamağını yeni düğüme atıyorum. 
            current = current.next; // Geçici düğümden bir sonraki düğüme geçiyorum.
        }
        return dummyHead.next; // Bağlı listeyi döndürüyorum.
    }
}