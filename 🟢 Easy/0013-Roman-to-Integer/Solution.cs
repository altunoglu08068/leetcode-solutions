public class Solution
{
    public int RomanToInt(string s)
    {
        if (s.Length == 0) return 0;

        int sum = 0;

        // Roman değerlerini tuttuğum fonlsiyon.
        int Value(char c) => c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };

        for (int i = 0; i < s.Length; i++) // Döngüyü s dizisinin boyutu kadar döndürüyorum.
        {
            int now = Value(s[i]); // Şu anki roman sayımız.
            // Bir sonraki indeksimiz dizinin sınırını aşıyor mu diye kontrol ediyorum?
            // Eğer aşmıyorsa roman sayısının değerini alıp ve later değişkenine atıyorum aşıyorsa sıfır atıyorum.
            int later = (i + 1 < s.Length) ? Value(s[i + 1]) : 0;

            if (now < later) sum -= now; // Şu anki sembolümüzün değeri sonraki sembolümüzünkinden küçükse değeri çıkarıyorum. (Ör: IV = 4.)
            else sum += now; // Değilse topluyorum.
        }
        return sum; // Sonucu döndürüyorum.
    }
}