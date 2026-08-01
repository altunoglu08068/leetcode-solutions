# 0020. Valid Parentheses

**Zorluk:** Easy  
**Konu:** String, Stack  
**LeetCode Bağlantısı:** [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/)

---

## 📝 Soru Açıklaması

Sadece `'('`, `')'`, `'{'`, `'}'`, `'['` ve `']'` karakterlerini içeren bir `s` dizesi veriliyor. Girdi dizesinin geçerli olup olmadığını belirleyin.

Bir girdi dizesi şu durumlarda geçerlidir:
1. Açılan parantezler aynı türdeki parantezlerle kapatılmalıdır.
2. Açılan parantezler doğru sırayla kapatılmalıdır.
3. Her kapanan parantezin aynı türde karşılık gelen bir açılış parantezi olmalıdır.

---

## 💡 Örnekler & Sınır Durumları (Edge Cases)

**Örnek 1 (Standart Geçerli Durum):**
```text
Girdi: s = "()"
Çıktı: true