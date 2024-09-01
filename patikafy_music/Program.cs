using patikafy_music;
using System.Linq;
    class Program
{
    public static void Main(string[] args)
    {
        //liste
        List<artist> artists = new List<artist>();
        artists.Add(new artist("Ajda Pekkan", "POP", 1968, 20000000));
        artists.Add(new artist("Sezen Aksu", "POP", 1971, 10000000));
        artists.Add(new artist("Funda Arar", "POP", 1999, 3000000));
        artists.Add(new artist("Sertab Erener", "POP", 1994, 5000000));
        artists.Add(new artist("Sıla", "POP", 2009, 3000000));
        artists.Add(new artist("Serdar Ortaç", "POP", 1994, 10000000));
        artists.Add(new artist("Tarkan", "POP", 1992, 40000000));
        artists.Add(new artist("Hande Yener", "POP", 1999, 7000000));
        artists.Add(new artist("Hadise", "POP", 2005, 5000000));
        artists.Add(new artist("Gülben Ergen", "POP", 1997, 10000000));
        artists.Add(new artist("Neşet Ertaş", "Türk Halk Müziği", 1960, 2000000));

        //satiş 10 milyonun üzerinde olanlar
        Console.WriteLine("Albüm satışları 10 milyonun üzerinde olanlar:");
        var result = from artist in artists
                     where artist.AlbumSales > 10000000
                     select artist;

        foreach (var artist in result)
        {
            Console.WriteLine($"Sanatçı adı: {artist.FullName}, Satış miktarı yaklaşık olarak: {artist.AlbumSales.ToString("N0")}");

        }

        Console.WriteLine("------------------------------");

        //2000 yılı öncesi çıkış yapmış ve pop müzik yapanlar
        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan sanatçılar:");

        var result2 = from artist in artists
                      where artist.ReleaseYear < 2000 && artist.MusicGenre == "POP"
                       select artist;

        foreach (var artist in result2)
        {
            Console.WriteLine($"Sanatçı adı: {artist.FullName}, Çıkış yılı: {artist.ReleaseYear}, Müzik türü: {artist.MusicGenre}");
        }

        Console.WriteLine("------------------------------");

        //en çok albüm satan sanatçı
        Console.WriteLine("En çok albüm satan sanatçı:");
        var result3 = artists.Max(x => x.FullName);
        Console.WriteLine($"En çok albüm satışı yapan sanatçı: {result3}");

        Console.WriteLine("------------------------------");

        //en eski çıkış yapan sanatçı
        Console.WriteLine("En eski çıkış yapan sanatçı:");
        var result4 = artists.OrderBy(y => y.ReleaseYear).FirstOrDefault();
        Console.WriteLine($"En eski çıkış yapan sanatçı: {result4.FullName}");


        Console.WriteLine("------------------------------");

        //en yeni çıkış yapan sanatçı
        Console.WriteLine("En yeni çıkış yapan sanatçı:");
        var result5 = artists.OrderByDescending(a=> a.ReleaseYear).FirstOrDefault();
        Console.WriteLine($"En yeni çıkış yapan sanatçı: {result5.FullName}");



    }

}