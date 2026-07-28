public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false; // Sayı sıfırdan küçükse polindrom değildir.

        int orijinalSayi = x;
        int tersSayi = 0;

        while (x > 0)
        {
            int sonBasamak = x % 10;
            tersSayi = (tersSayi * 10) + sonBasamak;
            x /= 10;
        }
        return orijinalSayi == tersSayi;
    }
}