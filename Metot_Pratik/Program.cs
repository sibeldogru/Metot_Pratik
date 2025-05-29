// Geriye Değer Döndürmeyen Bir void metot.
// Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 


using System.Reflection.Metadata;

void SarkiSozuYazdir()
{
    Console.WriteLine("Özlemim içimde yine seni büyütür.");
}

SarkiSozuYazdir();


Console.WriteLine("---------------------------------------------");

// Geriye Tamsayı Döndüren Bir metot
// Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

int IkiyeBolumdenKalaniDondur()
{
    Random rnd = new Random();
    int rastgeleSayi = rnd.Next();

    return rastgeleSayi % 2;

}


Console.WriteLine("-------------------------------------------------------");

//Parametre Alan ve Geriye Değer Döndüren Bir Metot
//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

int SayilariCarp(int sayi1,int sayi2)
{
    return sayi1 * sayi2;

}

SayilariCarp(13, 84);


Console.WriteLine("-------------------------------------------------------");

// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

void HosGeldiniz()
{
    Console.WriteLine("Adınızı girin.");
    string ad = Console.ReadLine();

    Console.WriteLine("Soyadınızı girin.");
    string soyad = Console.ReadLine();

    Console.WriteLine("Hoş Geldiniz " + ad + " " + soyad);
}

HosGeldiniz();










