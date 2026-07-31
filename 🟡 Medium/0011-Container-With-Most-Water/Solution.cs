public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0; // Sol işaretçim
        int right = height.Length - 1; // Sağ işaretçim.
        int maxCapacity = 0; // Maksimum hacimi tutan değişkenim.

        while (left < right) // Sol işaretçi, sağ işaretçiden küçük olduğu sürece döngüyü çalıştırıyorum.
        {
            int width = right - left; // Genişliği hesaplıyorum.
            int h = Math.Min(height[left], height[right]); // Suyun taşmaması için minumum yüksekliği seçiyorum.
            int capacity = width * h; // 2D hacmi hesaplıyorum.

            maxCapacity = Math.Max(maxCapacity, capacity); // Maksimum kapasiteyi güncelliyorum.

            if (height[left] < height[right]) left++; // Sol çubuk kısaysa, x'i sağa kaydırıyorum.
            else right--; // Sağ çubuk kısaysa, y'yi sola kaydırıyorum.
        }
        return maxCapacity; // Sonucu döndürüyorum.
    }
}