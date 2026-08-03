public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        // 1. ADIM: Diziyi küçükten büyüğe QuickSort metoduyla sıralıyorum.
        QuickSort(nums, 0, nums.Length - 1);

        // 2. ADIM: En büyük çevreyi istediğim için sondan (en büyük elemanlardan) başa doğru geziyorum.
        // Komşu 3 elemanı alıyorum: nums[i], nums[i-1], nums[i-2]
        for (int i = nums.Length - 1; i >= 2; i--)
        {
            int c = nums[i];     // En büyük kenar
            int b = nums[i - 1]; // Ortanca kenar
            int a = nums[i - 2]; // En küçük kenar

            // Dizi sıralı olduğu için (a <= b <= c), sadece tek bir kontrol yeterlidir:
            // a + b > c sağlandığı an geçerli bir üçgen bulmuş olurum.
            if (a + b > c)
            {
                // Sondan başladığım için bulduğum ilk geçerli üçgen, en büyük çevreye sahiptir.
                return a + b + c;
            }
        }

        // Eğer hiçbir 3'lü üçgen oluşturamıyorsa 0 döndürüyorum.
        return 0;
    }

    // Diziyi sıralıyorum.
    private void QuickSort(int[] array, int start, int finish)
    {
        if (start < finish)
        {
            // Pivottan küçükleri sola, büyükleri sağa aktarıp pivotun doğru indeksini alıyorum.
            int pivotIndex = Fragmentation(array, start, finish);

            // Pivotun sol tarafını sıralıyorum.
            QuickSort(array, start, pivotIndex - 1);
            // Pivotun sağ tarafını sıralıyorum.
            QuickSort(array, pivotIndex + 1, finish);
        }
    }

    // Pivota göre diziyi bölme işlemi uyguluyorum.
    private int Fragmentation(int[] array, int start, int finish)
    {
        int pivot = array[finish]; // Son elemanı pivot seçiyorum.
        int i = start - 1;         // Pivottan küçük elemanların yerini tutan işaretçim.

        // Başlangıçtan pivot öncesine kadar tara
        for (int j = start; j < finish; j++)
        {
            // Eğer mevcut eleman pivottan küçük veya eşitse...
            if (array[j] <= pivot)
            {
                i++;
                // Elemanların yerini değiştiriyorum.
                int temporary = array[i];
                array[i] = array[j];
                array[j] = temporary;
            }
        }

        // Pivotu, kendisinden küçüklerin hemen sağına (i + 1) yerleştiriyorum.
        int temporary2 = array[i + 1];
        array[i + 1] = array[finish];
        array[finish] = temporary2;

        return i + 1; // Pivotun nihai indeksini döndürüyorum.
    }
}