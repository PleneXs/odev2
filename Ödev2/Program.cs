using System;


class Program
{

    static void Main()
    {
        // Kullanıcıdan kenar uzunluğu al
        Console.Write("Karenin bir kenar uzunluğunu girin: ");
        int kenar = Convert.ToInt32(Console.ReadLine());

        // Alan hesapla 
        int alan = kenar * kenar;

        // Sonucu ekrana yaz
        Console.WriteLine($"Karenin alanı: {alan}");

    }
}

