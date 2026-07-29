public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length) // Eğer nums1 dizisi diğer diziden daha büyükse...
            return FindMedianSortedArrays(nums2, nums1); // Parametlerin yerini değiştirip tekrar çağırıyorum.

        int m = nums1.Length; // Küçük dizinin eleman sayısını tutuyorum.
        int n = nums2.Length; // Büyük dizinin eleman sayısını tutuyorum.

        int left = 0; // Sol sınır değeri.
        int right = m; // Sağ sınır değeri.

        while (left <= right) // Döngüyü sol sınır sağdan küçük veya eşitse devam ettiriyorum.
        {
            int i = left + (right - left) / 2; // Küçük dizi için bölüm noktası.
            int j = (m + n + 1) / 2 - i; // Büyük dizi için bölüm noktası.

            // SINIRLAR
            //Bölüm noktasının en başına veya sonuna gelirse başka eleman olmadığı için max ve min değerleri atıyorum.

            // nums1 için...
            int left1 = (i == 0) ? int.MinValue : nums1[i - 1];
            int right1 = (i == m) ? int.MaxValue : nums1[i];

            // nums2 için...
            int left2 = (j == 0) ? int.MinValue : nums2[j - 1];
            int right2 = (j == n) ? int.MaxValue : nums2[j];

            // Sol gruptaki elemanlar sağ gruptaki elemanlardan küçük veya eşitse (doğru bölüm noktası bulunduysa)...
            if (left1 <= right2 && left2 <= right1)
            {
                if ((m + n) % 2 != 0) return Math.Max(left1, left2); // Eğer eleman sayısı çift değilse ortadaki elemanı döndürüyorum.
                else return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0; // Çiftse ortadaki iki elemanın ortalamasını alıp döndürüyorum. 
            }
            // Eğer yanlış bölüm noktası belirlediysek düzeltiyoruz.
            else if (left1 > right2) right = i - 1; //num1'deki sol bölümden fazla sayı aldıysak sağ sınırı sola kaydırıyorum.
            else left = i + 1; // Tam tersi.
        }
        return 0.0; // Bulunmadıysa uygun değeri döndürüyoruz.
    }
}