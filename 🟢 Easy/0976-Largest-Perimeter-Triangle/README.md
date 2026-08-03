# 0976. Largest Perimeter Triangle

**Zorluk:** Easy  
**Konu:** Array, Math, Greedy, Sorting  
**LeetCode Bağlantısı:** [Largest Perimeter Triangle](https://leetcode.com/problems/largest-perimeter-triangle/)

---

## 📝 Soru Açıklaması

Pozitif uzunluklara sahip tam sayılardan oluşan bir `nums` dizisi veriliyor. Bu kenarlarla sıfırdan farklı alana sahip bir üçgen oluşturulabiliyorsa, bu üçgenin **mümkün olan en büyük çevresini** döndürün. 

Eğer sıfırdan farklı alana sahip hiçbir üçgen oluşturulamıyorsa `0` döndürün.

---

## 💡 Örnekler & Sınır Durumları (Edge Cases)

**Örnek 1 (Geçerli Üçgen):**
```text
Girdi: nums = [2,1,2]
Çıktı: 5
Açıklama: Kenarları 1, 2, 2 olan üçgen oluşturulabilir. Çevre = 1 + 2 + 2 = 5.