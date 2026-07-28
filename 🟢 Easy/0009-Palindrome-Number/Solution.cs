public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false; // Sayı sıfırdan küçükse polindrom değildir.

        int orijinalSayi = x; // Sayıyı koruyorum.
        int tersSayi = 0; // Şu an ters sayı olmadığı için 0 olarak belirliyorum.

        while (x > 0) // x değerini sıfırlanana kaadar döngüyü devam ettiriyorum.
        {
            int sonBasamak = x % 10; // Son basamağı tutuyorum.
            tersSayi = (tersSayi * 10) + sonBasamak; // Sayıyı tersten oluşturuyorum.
            x /= 10; // Basamağı kaydırıyorum.
        }
        return orijinalSayi == tersSayi; // Ters sayı ile orijinal sayı eşitse True döndürüyorum.
    }
}