public class Solution
{
    public int AddDigits(int num) => num == 0 ? 0 : 1 + (num - 1) % 9;

    /*
        Sayı 0 ise sonuç 0'dır; sayı sıfır değilse 1 + (num - 1) % 9
        formülü basamakların tekrar eden toplamını doğrudan verir.
    */
}