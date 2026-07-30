# 0013. Roman to Integer

**Zorluk:** Easy  
**Konu:** Hash Table, Math, String  
**LeetCode Bağlantısı:** [Roman to Integer](https://leetcode.com/problems/roman-to-integer/)

---

## 📝 Soru Açıklaması

Romen rakamları yedi farklı sembolle temsil edilir: `I`, `V`, `X`, `L`, `C`, `D` ve `M`.

| Sembol | Değer |
| :---: | :---: |
| **I** | 1 |
| **V** | 5 |
| **X** | 10 |
| **L** | 50 |
| **C** | 100 |
| **D** | 500 |
| **M** | 1000 |

Romen rakamları genellikle soldan sağa doğru büyükten küçüğe yazılır. Ancak 4 ve 9 gibi sayılar için çıkarma kuralı uygulanır:
* `I`, `V` (5) ve `X` (10)'den önce gelebilir $\rightarrow$ 4 ve 9
* `X`, `L` (50) ve `C` (100)'den önce gelebilir $\rightarrow$ 40 ve 90
* `C`, `D` (500) ve `M` (1000)'den önce gelebilir $\rightarrow$ 400 ve 900

Verilen bir Romen rakamı dizgisini (`s`) tam sayıya (integer) dönüştürünüz.

---

## 💡 Örnekler

**Örnek 1:**
```text
Girdi: s = "III"
Çıktı: 3