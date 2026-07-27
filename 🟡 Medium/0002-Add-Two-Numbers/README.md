# 2. Add Two Numbers

- **Zorluk:** 🟡 Medium
- **LeetCode Linki:** [Add Two Numbers](https://leetcode.com/problems/add-two-numbers/)

## 📝 Soru Açıklaması
Boş olmayan iki bağlı liste (Linked List) veriliyor. Bu listelerdeki düğümler ters sırada rakamları tutmaktadır. Bu iki sayıyı toplayıp sonucu yine bağlı liste olarak döndür.

## 💡 Yaklaşım
* İki bağlı liste üzerinde basamak basamak (düğüm düğüm) ilerlenir.
* Her adımda toplam ve eldeli tutan bir `carry` (elde) değişkeni kullanılır.
* Toplam $10$ veya daha büyükse `carry = sum / 10` yapılır ve yeni düğüme `sum % 10` değeri aktarılır.

## ⏱️ Karmaşıklık Analizi
* **Time Complexity:** $O(\max(N, M))$ — $N$ ve $M$ listelerin uzunluklarıdır.
* **Space Complexity:** $O(\max(N, M))$ — Oluşturulan yeni bağlı liste için.