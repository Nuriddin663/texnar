// KIRISH
//isim familiya
Console.WriteLine("ASSALOMU ALEKUM! TOSHKENT SHAXAR Texnika holatini nazorat qilish O'zagroinspeksiyaSIGA XUSH KELIBSIZ");
Console.WriteLine("XURMATLI MIJOZ, bIZ SIZGA NAMUNALI XIZMAT KO'RSATISHIMIZ UCHUN, MA'LUMOTINGIZNI KIRITING");
Console.WriteLine("");
Console.WriteLine("ILTIMOS SHAXSINGIZNI KIRITING, sizga murojat qilish uchun ismingizni kiriting");
string isim = string.Empty;
isim = Console.ReadLine();
Console.WriteLine($"Assalomu alekum yana bir bor {isim} iltimos familiyangizni kiriting");
string familiya;
familiya = Console.ReadLine();
Console.WriteLine($"{isim} {familiya} qaysi tumandan murojat qilyapganingizni kiriting");
string manzil;
manzil = Console.ReadLine();
Console.WriteLine($"TOSHKENT VILOYATI {manzil} dan {familiya}{isim} BO'LASIZ");
Console.WriteLine("murojat bo'yicha jismoniy yoki yuridikyoki shxs xisoblanasizmi?");
//SHAXSI
Console.WriteLine("1-jismoniy");
Console.WriteLine("2-yuridik");
Console.WriteLine("iltimos, ko'rsatilgan tartibda to'ldring");
bool shaxs;
string shaxsString = Console.ReadLine();

if (shaxsString == "1")
{
    shaxs = true;
    Console.WriteLine($"{isim} JISMONIY SHAXS");
    Console.WriteLine($"{isim} iltomos, siz xaqingizda ma'lumot olishim uchun pasportingizdagi  STIR raqamini kiritin");
    Console.WriteLine("TARTIBI MISOL: xxxx xxxx xxxx xx");
    string STIR;
    STIR = Console.ReadLine();
    Console.WriteLine($"sizning pasport {STIR} raqamingiz  ");
}
else if (shaxsString == "2")
{
    shaxs = false;
    Console.WriteLine($"{isim} YURIDIK SHAXS");
    Console.WriteLine($"{isim} iltomos, firma xaqingizda ma'lumot olishim uchun STIR raqamini kiritin");
    Console.WriteLine("TARTIBI MISOL: xxx xxx xxx");
    string INN;
    INN = Console.ReadLine();
    Console.WriteLine($"sizning pasport {INN} raqamingiz  ");

}
else
{
    Console.WriteLine($"XAROLIK! {isim} xato kititdingiz");
    Console.WriteLine($"ILTIMOS,{isim} (1) yoki (2) xarifini bosing");
}

Console.WriteLine($"");
Console.WriteLine("");
