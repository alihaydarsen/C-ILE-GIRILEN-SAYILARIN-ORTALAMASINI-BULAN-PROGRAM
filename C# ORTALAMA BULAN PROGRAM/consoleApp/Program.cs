//C# İLE GİRİLEN SAYILARIN ORTALAMASINI BULAN PROGRAM

Console.WriteLine("LÜTFEN ORTALAMASINI HESAPLAYACAGIMIZ SAYI ADEDİNİ GİRİNİZ:");
 int sayıAdedi= Convert.ToInt32(Console.ReadLine());
 Double toplam= 0;
 Double yeni;
  
 for( int i =1; i <=sayıAdedi; i++){
    Console.WriteLine($"LÜTFEN ORTALAMASINI HESAPLAYACAGIMIZ {i} .SAYIYI GİRİNİZ" );
    yeni = Convert.ToInt32(Console.ReadLine());
    toplam =yeni+toplam;
 }
 Console.WriteLine("----------------------------");
Console.WriteLine("GİRDİGİNİZ SAYILARIN ORTALAMASI: " +toplam/sayıAdedi); 

