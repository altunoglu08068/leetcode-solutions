public class Solution
{
    public int Reverse(int x)
    {
        long reverseNumber = 0; // Ters sayıyı tutacak değişkenim.
        long y = x; // x'i bozmadan y'de işlem yapıyorum. Böylece orijinal sayı korunmuş oluyor.

        while (y != 0) // y, sıfır olana kadar döngüyü çalıştırıyorum..
        {
            reverseNumber = (reverseNumber * 10) + (y % 10); // Sayıyı matematiksel olarak ters oluşturuyorum.
            y /= 10; // Bir basamak kaydırıyorum.
        }

        // Eğer sayı int sınırlarını aşarsa sıfır döndürüyorum.
        if (reverseNumber > int.MaxValue || reverseNumber < int.MinValue)
            return 0;

        return (int)reverseNumber; // Oluşan ters sayıyı döndürüyorum.
    }
}