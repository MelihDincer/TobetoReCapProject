Start:
Console.WriteLine("\n\n------------------------\n\n");

Console.WriteLine("Hangi ödevi görmek istersiniz ?: ");
Console.WriteLine("1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.\r\n2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)\r\n3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.\r\n4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.\r\n5- String metotlarını araştırınız. Her bir metot için örnek yapınız.\r\n6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.\r\n7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.\r\n8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.\n 9- Çıkmak için");
int homeWorkNumber = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (homeWorkNumber == 1)
{
    //1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
    Console.WriteLine("Sipariş numaranızı giriniz(1-5): ");
    int orderNumber = Convert.ToInt32(Console.ReadLine());
    switch (orderNumber)
    {
        case 1:
            Console.WriteLine("1.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 2:
            Console.WriteLine("2.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 3:
            Console.WriteLine("3.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 4:
            Console.WriteLine("4.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 5:
            Console.WriteLine("5.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        default:
            Console.WriteLine("Yanlış değer girdiniz!");
            break;
    }
}

if (homeWorkNumber == 2)
{
    //2 - kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

    Console.WriteLine("Lütfen kaç ürün almak istediğinizi giriniz: ");
    int productCount = Convert.ToInt32(Console.ReadLine());
    double result = 0;
    for (int i = 1; i <= productCount; i++)
    {
        Console.WriteLine(i + ".ürünün fiyatını giriniz: ");
        result += Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Toplam alışveriş tutarı: " + result);
}

if (homeWorkNumber == 3)
{
    //3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
    int a = 0;
    int sayac = 0;
    do
    {
        Console.WriteLine("Lütfen " + (a + 1) + ". kişinin yaşını giriniz: ");
        int yas = Int32.Parse(Console.ReadLine());

        if (yas >= 20)
        {
            sayac++;
        }
        a++;
    } while (a < 10);

    Console.WriteLine("Askere gidebilen kişi sayısı=" + sayac);
    Console.WriteLine("Askere gidemeyen kişi sayısı=" + (10 - sayac));
    Console.ReadLine();
}

if (homeWorkNumber == 4)
{
    //4 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

    Console.WriteLine("Sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam = toplam + i;
        }
    }
    if (toplam == sayi)
    {
        Console.WriteLine(sayi + " sayısı Mükemmel Sayıdır");
    }
    else
    {
        Console.WriteLine(sayi + " sayısı Mükemmel Sayı Değildir");
    }
}

if (homeWorkNumber == 5)
{
    //5 - String metotlarını araştırınız. Her bir metot için örnek yapınız.

    string metin = "Bugün .NET FullStack eğitimimizin .Net bölümünün ilk dersine başladık ve ödevi yapmak için çok çalışıyoruz.         ";
    string metin2 = "metin2 yeni metnidir";
    string metin3 = "       Bu metnin başı ve sonu boşlukludur.        ";
    string[] text = { "C#", "Java", "C++" };
    string isim = "pair-6", tcNo = "11122233335", test = "test mesajı";

    Console.WriteLine(metin3.Trim());
    Console.WriteLine("   pair-6             ".TrimEnd());
    Console.WriteLine("      pair-6".TrimEnd());
    Console.WriteLine(metin3.Trim());
    Console.WriteLine(metin.ToLower());
    Console.WriteLine(metin.ToUpper());
    Console.WriteLine(metin.Any());
    Console.WriteLine(metin.Replace(".", ","));
    Console.WriteLine(metin.StartsWith("A"));
    Console.WriteLine(metin.Replace(" ", "").EndsWith("."));
    Console.WriteLine(String.Compare(metin, "Z"));/* => -1 olarak çıktı alırız  (soldaki sağdakinden alfanümerik olarak küçük demektir)*/
    Console.WriteLine(String.Compare(metin, "A"));/* => 1 olarak çıktı alırız  (soldaki sağdakinden alfanümerik olarak büyük demektir)*/
    Console.WriteLine(String.Compare(metin, metin));/*=> 0 olarak çıktı alırız yani eşittir anlamına gelir.*/
    Console.WriteLine(metin.CompareTo("Z"));/* => -1 olarak çıktı alırız  (soldaki sağdakinden alfanümerik olarak küçük demektir)*/
    Console.WriteLine(metin.CompareTo("A"));/* => 1 olarak çıktı alırız  (soldaki sağdakinden alfanümerik olarak büyük demektir)*/
    Console.WriteLine(metin.CompareTo(metin));/*=> 0 olarak çıktı alırız yani eşittir anlamına gelir.*/
    Console.WriteLine(String.Concat(metin, metin2));
    Console.WriteLine(metin.Contains(".NET"));
    Console.WriteLine(String.Equals(metin, metin2));
    Console.WriteLine(metin.IndexOf(".NET"));
    Console.WriteLine(String.Join(" - ", text));
    Console.WriteLine(metin2.Remove(6));
    Console.WriteLine(String.Format("TcNo: {0} olan {1} isimli kişinin mesajı: {2} ", tcNo, isim, test));
    Console.WriteLine(metin2.Substring(0, 15));
    char[] charList = metin2.ToCharArray();
    foreach (var item in charList)
    {
        Console.Write(item + ",");
    }
    Console.WriteLine("\n --------");
    string[] yeniMetin = metin2.Split(' ');
    foreach (var item in yeniMetin)
    {
        Console.Write(item);
    }
    Console.WriteLine("\n --------");
    Console.WriteLine(metin2.PadLeft(50, '*'));
    Console.WriteLine(metin2.PadRight(50, '*'));
}

if (homeWorkNumber == 6)
{
    //6 - Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

    Console.WriteLine("Ürünün Fiyatını Giriniz: ");
    int price = Convert.ToInt32(Console.ReadLine());
    if (price > 300)
        Console.WriteLine($"toplam tutar: {price}");
    else
        Console.WriteLine($"toplam tutar (kargo dahil): {price + 50} ");
}

if (homeWorkNumber == 7)
{
    //7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

    Console.WriteLine("1. Ürünün Fiyatını Giriniz: ");
    double price1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2. Ürünün Fiyatını Giriniz: ");
    double price2 = Convert.ToInt32(Console.ReadLine());
    double totalPrice = price1 + price2;
    if (totalPrice > 500)
    {
        totalPrice -= price2 * 0.4;
        Console.WriteLine($"Toplam Fiyat: {totalPrice}");
    }
    else
    {
        Console.WriteLine($"Toplam Fiyat: {totalPrice}");
    }
}

if (homeWorkNumber == 8)
{
    //8 - 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

    int sayac1 = 0;
    for (int number = 1; number < 200; number++)
    {
        if (number % 3 == 0 || number % 5 == 0)
        {
            sayac1++;
            Console.WriteLine(number);
        }
    }
    Console.WriteLine($"1 - 200 arasında 3'e veya 5'e tam bölünebilen sayıların adeti: {sayac1}");
}
else
{
    return;
}
goto Start;