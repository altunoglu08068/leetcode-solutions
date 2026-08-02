public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0) return false;
        /*
            Sayı, 0 veya negatifse 3'ün kuvveti olamaz.
        */

        while (n % 3 == 0) n /= 3;
        /*
            3'ün katı ise 3'e bölmeye devam ediyorum.
            Eğer n, 1 olmadıysa 3'ün kuvveti değildir.
        */
        return n == 1;
        /*
            İçindeki tüm 3 çarpanları çıkarıldıktan sonra
            geriye sadece 1 kalmışsa sayı 3'ün kuvvetidir.
        */
    }
}