public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Değerleri key, indekslerini value olarak tutuyorum. 
        Dictionary<int, int> memory = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Bir değeri gezerken hedefe giden değeri aramak için search değişkenini oluşturdum.
            int search = target - nums[i];

            // Eğer sözlükte, aranan değerimiz varsa...
            if (memory.ContainsKey(search))
            {
                // Değeri ve indeksini döndürüyorum.
                return new int[] { memory[search], i };
            }

            // Eğer sözlükte, dizideki değerimiz henüz yoksa... 
            if (!memory.ContainsKey(nums[i]))
            {
                // O değeri indeksi ile birlikte sözlüğe atıyorum.
                memory.Add(nums[i], i);
            }
        }
        // Uygun çift bulunamadığında varsayılan değer dönderiyoruz.
        return new int[] { 0, 0 };
    }
}