# 0509. Fibonacci Number

**Zorluk:** Easy  
**Konu:** Math, Dynamic Programming, Recursion, Memoization  
**LeetCode Bağlantısı:** [Fibonacci Number](https://leetcode.com/problems/fibonacci-number/)

---

## 📝 Soru Açıklaması

**Fibonacci sayıları**, genellikle $F(n)$ ile gösterilen ve her sayının kendinden önceki iki sayının toplamı olduğu bir sayı dizisi oluşturur. $0$ ve $1$'den başlar:

* $F(0) = 0, F(1) = 1$
* $n > 1$ için $F(n) = F(n - 1) + F(n - 2)$

Verilen bir $n$ tam sayısı için $F(n)$ değerini hesaplayın.

---

## 💡 Örnekler & Sınır Durumları (Edge Cases)

**Örnek 1:**
```text
Girdi: n = 2
Çıktı: 1
Açıklama: F(2) = F(1) + F(0) = 1 + 0 = 1.