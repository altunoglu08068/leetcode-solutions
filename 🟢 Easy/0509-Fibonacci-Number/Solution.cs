public class Solution
{
    public int Fib(int n)
    {
        // 0 ve 1 için direkt döndürüyom.
        if (n <= 0) return 0;
        if (n == 1) return 1;

        int prev2 = 0; // Fib(i - 2) değerini tutuyorum. (Fib(0))
        int prev1 = 1; // Fib(i - 1) değerini tutuyorum. (Fib(1))
        int current = 0; // Toplam değişkenim.

        // 0 ve 1 belli olduğu için 2'den n'e kadar döngüye alıyorum.
        for (int i = 2; i <= n; i++)
        {
            current = prev1 + prev2; //Fonksiyonum: Fib(i) = Fib(i - 1) + Fib(i - 2)
            prev2 = prev1; // Bir sonraki adıma geçiyorum.
            prev1 = current; // Bulduğum toplamı, bir sonraki turun (i - 1) değeri yapıyorum.
        }

        return current; // Toplamı döndürüyorum.
    }
}