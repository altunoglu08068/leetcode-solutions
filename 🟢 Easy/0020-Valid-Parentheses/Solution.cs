public class Solution
{
    public bool IsValid(string s)
    {
        /* Parantezlerin açılış sırasını ve en son açılanı
        (LIFO - Last In First Out) takip etmek için bir Stack
        oluşturuyorum. */
        Stack<char> stack = new Stack<char>();

        foreach (char i in s) // s string dizisini geziyorum.
        {
            // Eğer açılış karekteriyse karakteri stack'e atıyoruz.
            if (i == '(' || i == '{' || i == '[') stack.Push(i);
            else if (i == ')' || i == '}' || i == ']') // Kapanış karakteriyse...
            {
                // Kapanış parantezi geldi ama stack boşsa false döndürüyorum.
                if (stack.Count == 0) return false;

                char sonAcilan = stack.Pop(); // En son açılmış olan parantezi stack'ten çıkarıyorum.

                // Çıkarılan açılış parantezi ile mevcut kapanış parantezinin türü uyuşmuyorsa dizi geçersizdir (Örnek: "(]").
                if (i == ')' && sonAcilan != '(') return false;
                if (i == '}' && sonAcilan != '{') return false;
                if (i == ']' && sonAcilan != '[') return false;
            }
        }
        // Dize bittiğinde Stack tamamen boşalmışsa tüm parantezler doğru eşleşip kapanmıştır (true).
        // Eğer Stack içinde hâlâ eleman kalmışsa kapatılmamış parantez var demektir (false, Örn: "((").
        return stack.Count == 0;
    }
}