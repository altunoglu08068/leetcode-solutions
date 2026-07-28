public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        // Karakterleri ve onların indekslerini bir arada tutmak için bir sözlük oluşturuyorum.
        Dictionary<char, int> sonGorulme = new Dictionary<char, int>();

        int baslangic = 0; // Başlangıç indeksini tutuyorum.
        int maxUzunluk = 0; // Maksimum uzunluğu tutuyorum.

        for (int i = 0; i < s.Length; i++) // s dizisinin her karakterini dolaşıyorum.
        {
            char harf = s[i]; // Şu anki karakteri alıyorum.

            // Eğer karakter daha önce görülmüşse ve başlangıç indeksinden sonra görülmüşse, başlangıç indeksini güncelliyorum.
            if (sonGorulme.ContainsKey(harf) && sonGorulme[harf] >= baslangic)
            {
                // Başlangıç indeksini, karakterin son görüldüğü indeksin bir sonrasına güncelliyorum.
                baslangic = sonGorulme[harf] + 1;
            }
            sonGorulme[harf] = i; // Karakterin son görüldüğü indeksi güncelliyorum.

            // Maksimum uzunluğu güncelliyorum.
            maxUzunluk = Math.Max(maxUzunluk, i - baslangic + 1);
        }
        return maxUzunluk; // Çıkan sonucu döndürüyorum.
    }
}