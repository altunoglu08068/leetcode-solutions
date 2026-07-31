# 0011. Container With Most Water

**Zorluk:** Medium  
**Konu:** Array, Two Pointers, Greedy  
**LeetCode Bağlantısı:** [Container With Most Water](https://leetcode.com/problems/container-with-most-water/)

---

## 📝 Soru Açıklaması

Uzunlukları $n$ olan `height` tam sayı dizisi veriliyor. Her biri $(i, 0)$ ve $(i, height[i])$ noktaları arasında dikey çizilmiş $n$ adet çizgi vardır.

x ekseni ile birlikte en çok su tutabilen iki çizgiyi bulun ve bu kabın tutabileceği **maksimum su miktarını** döndürün.

---

## 💡 Örnekler & Sınır Durumları (Edge Cases)

**Örnek 1 (Standart Durum):**
```text
Girdi: height = [1,8,6,2,5,4,8,3,7]
Çıktı: 49
Açıklama: Dikey çizgiler [1,8,6,2,5,4,8,3,7] ile temsil edilir. Bu durumda en çok su tutan alan (indeks 1 ve indeks 8 arasındaki) 8 ve 7 yüksekliğindeki çizgiler arasındadır. 
Genişlik = 8 - 1 = 7, Yükseklik = min(8, 7) = 7. Alan = 7 * 7 = 49.