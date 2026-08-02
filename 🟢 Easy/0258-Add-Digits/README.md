# 0258. Add Digits

**Zorluk:** Easy  
**Konu:** Math, Number Theory, Simulation  
**LeetCode Bağlantısı:** [Add Digits](https://leetcode.com/problems/add-digits/)

---

## 📝 Soru Açıklaması

Negatif olmayan bir `num` tam sayısı verildiğinde, sonuç tek bir basamak olana kadar tüm basamaklarını tekrar tekrar toplayın ve sonucu döndürün.

Eski adıyla bu işlem **Digital Root (Sayısal Kök)** olarak bilinir.

---

## 💡 Örnekler & Sınır Durumları (Edge Cases)

**Örnek 1 (Çoklu Adımlı Toplam):**
```text
Girdi: num = 38
Çıktı: 2
Açıklama: 
1. Adım: 3 + 8 = 11
2. Adım: 1 + 1 = 2
Sonuç tek basamaklı olduğu için 2 döndürülür.