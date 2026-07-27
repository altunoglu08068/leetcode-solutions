# 1. Two Sum

- **Zorluk:** 🟢 Easy
- **LeetCode Linki:** [Two Sum](https://leetcode.com/problems/two-sum/)

## 📝 Soru Açıklaması
Verilen bir tamsayı dizisi (`nums`) ve bir hedef sayı (`target`) içinde, toplamları `target` değerine eşit olan iki sayının indekslerini döndür.

## 💡 Yaklaşım (Dictionary / Hash Map)
* Dizi üzerinde tek bir döngü dönülür.
* Her elemanda `target - mevcut_sayi` farkı hesaplanır.
* Bu fark daha önce `Dictionary` içine eklenmiş mi diye bakılır.
* Bulunursa indeksler döndürülür, bulunamazsa mevcut sayı ve indeksi `Dictionary`'ye kaydedilir.

## ⏱️ Karmaşıklık Analizi
* **Time Complexity:** $O(n)$
* **Space Complexity:** $O(n)$