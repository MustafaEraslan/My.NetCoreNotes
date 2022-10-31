# My.NetCore and Git notes

## Git

Email düzenleme,
Global olarak düzenledik.
- Git config –global user.name “Mustafa Eraslan”
- Git config user.name
//sorguladık isim gelmiş
- Git config –global user.email mustafa.eraslan@arvato-scs.com
//kontol ettiğimde
- Git config user.email
//emailim geldiğini gördüm.
Git bir versiyon kontrol sistemidir.
Versiyonları kontrol edebiliyoruz. SavePoint gibi. 

Email ve kullanıcı kaydedilebiliyor. Daha sonrasında değiştirilebiliyor.

git config --global user.name "mustafa eraslan"

git config --global user.email eraslan.mustafa@outlook.com

![image](https://user-images.githubusercontent.com/44713722/198847304-77eed120-e0fc-4476-9645-f0421dd9c57e.png)

![image](https://user-images.githubusercontent.com/44713722/195627398-91bed67b-1e70-45f2-87c7-986ea8e402b8.png)

![image](https://user-images.githubusercontent.com/44713722/198847335-84088d2c-6482-4c0c-8ae2-12314fc10c5b.png)


Üstteki mavi baloncuklar birer commit olarak nitelendirebiliriz. Pembeler ise ayrı bir branch’tir.
Her bir commit’e geri dönebilirim. Turuncularda commitin açıklmasıdır.

![image](https://user-images.githubusercontent.com/44713722/195627439-34a302ff-3b02-426f-a245-8f70720a9d8a.png)

pwd: print working direcroty anlamındadır. Güncel olarak hangi klasörde olduğumuzu söyler.

- cd change Directory 
- cd .. //yaparsak bir önceki klasöre geliyor. 
- tab ile tamamlayabiliyor.
- mkdir make directory: klasör olıuşturur.
- rm not.txt :remove kaldırır. sadece dosyaları siliyor.
- rm -rf Gitklasörü dersem klasörü de siler.

Çalışma klasörü kodlarımızın bulunduğu klasördür.

- Gitt add //staging dediğimiz yere alıyoruz. Arafta duruyor.  git hangi dosyayı görmüşse onu indexlemiş oluyor.
- Git commit ile yukarıdaki mavi yuvarlaklar oluşuyor. 
- Ls //bulunduğumuz konumu gösteriyor 
- Mkdir GitTest //GitTest adında bir çalışma dosyası oluştur. 
- Cd GitTest // GitTest ismindeki klasörün içerisine gir. 
- Git status // git’in bu klasör ile bir bağlantısı yok bilgisini verdi.  Bağlantıyı kurmak için init komutunu kullanıyoruz.
- Git init // master ana branch’tir. İnit işlemi yapar. Artık git ile bağlantımız vardır. Master brach'ini görüyoruz. 2 kez init sakın yapma. 
- Ls -la // gizli dosyaları da görmemizi sağlar. .git klasörüne değişikliklerimizi kaydediyor. değişikliklerimizi loglanmış oluyor.
- Cd .git //diyip içeriisnie bakabiliriz. 
- Rm -rf .git //dediğimizde .git dosyasını siler 
- Git status // dediğimiz zaman not a git repositorty der bize 
- Touch ilkdefter.txt //dediğimizde bize ilkdefter.txt dosyası oluşturur. 
- Git add ilkdefter.txt // ilkdefter diyerek add yaptık. 
- Git commit -m “created ilkdefter.txt” //commit attık. 
- Git log // commit detayını görmüş olduk. 

Her commitin kendine ait bir hash’i oluyor.  Bu sayede commite dönebiliyoruz. 
HEAD -> master //master branch’i içerisinde olduğumuzu gösterir. 
- Gitt add . // her şeyi ekler. Yani 2 dosyamız varsa ikisini de ekler. 
- Gitt commit -m // “ilk satır kodlarımızı yazdık” 
- Git log // commit loğlarını görürüz 
- Gitt add . // her şeyi eklemiş olacak.
- Git commit -m “python kodunda bir satır değişti” 

head> master hangisini gösteriyorsa son commit o dur.
## gitignore
Touch ornek.html // ornek html oluşturur.
Touch gizli.txt //gizli dosya oluşturup. Klasörden içerisine edit yapıyor. Gereksiz detayları ekliyoruz. 
Git status // gizli.txt olduğunu gösterir. 
Gitignore ile görmezden gelceeği dosyaları oluşturuyoruz.  
- Touch . gitignore //gitignore oluşturdum. 
- Gitignore dosyası içerisine gizli.txt yazdığımda. Gizlitxt gözükmemeye başlayacak. 
- git add . // Artık yapabiliriz. 
- Git commit -m “gitignore dosyası oluşturuldu” 

![image](https://user-images.githubusercontent.com/44713722/196617979-915bf717-b453-437c-a319-a6d3985c0bd7.png)

- Cd Desktop 
- Ls 
- Cd GitTest 
- Git log 
Master bir ana branch son hali anlamındadır. 
(Head -> Master) // head git içerisinde hangi konumda olduğumuzu gösterir. Head genelde son konummuzu gösterir. Branch’ler açtıkça bu durum değişebilir.  

![image](https://user-images.githubusercontent.com/44713722/196618046-ec0897fb-badc-42e5-8990-4ac2a1d8e610.png)

HEAD:
bizim git içeriisndeahngi konumda olduğumuzu gösterir.

## Merge 

![image](https://user-images.githubusercontent.com/44713722/198867988-5a8ee635-3d1d-461f-b707-284bd3f0c41e.png)
- git branch branchname // branch açar.

Yeni bir branch açarsak head oraya geliyor.

- git switch master // master'a geçebiliriz.

İki tane brach'i daha sonra birleştirmek istersek;
git merge branchname // kullanabiliriz.

- git branch //kaç tane brach varsa onları gösterir.

![image](https://user-images.githubusercontent.com/44713722/199104981-49a26290-b0b8-4d61-b553-d57419e700ca.png)

Merge Conflict


### .Net Core Bilinmesi Gereken Kütüphaneler

.Net 5.0 startup.cs dosyasında 2 tane methodumuz bulunuyor. Bunlar; configureservice, configure methodlarıdır. Configureservice servislerimizi eklediğimiz yerdir. configure middleware'larımızı eklediğimiz yerdir.

.net 5.0 startup dosyasında configureservice'te bulunan servislerimi, .Net 6.0 'da builder.build'ten önce yapmam gerekiyor.
.Net 6.0 'da direkt builder.services. dediğimde AddScoped, AddSingleton, Trancied ekleyebiliyoruz.

Lambda neden kullanıyoruz?
Lambda İfadeleri kullanarak parametre geçilebilen ve değer döndüren isimsiz yerel fonksiyonlar oluşturabilirsiniz. Bu ifadeler genelde basit işlemleri bildirmekte kullanılabilir ve LINQ sorgularının yazımında çok işe yararlar.

1.hafta:
 
What is a C# 

![image](https://user-images.githubusercontent.com/44713722/182449917-335ce97f-bf45-4504-9680-d1398e00942d.png)


Dot net bir framework. C# ise bu framework üzerinde geliştirme yaptığımız bir yazılım dili. 
Özelliklerinden bir tanesi. Güçlü bir Garbage Collector olması. 
- Garbage Collector
Ram optimizasyonunu yapan bir yapı. Geçmişte objectif C, C dillerinde bu optimizasyonu kendimizin yapması gerekiyor. 

- nullable type
native olarak destekliyor.

- lampda linq expression

linq sorguları yazabliyoruz. 

- async operation

Bu işlemler yapılabiliyor

- exception handling

çok güçlü exception var. Bu noktada güçlü bir middileware yazabliyoruz.

middileware nedir?
Request/Response Pipeline’ı üzerinde özelleştirilmiş aksiyonlar alınmasını mümkün kılan, bu Pipeline akışının handle edilmesini sağlayan modüler ve etkili yapılardır.

Middleware yapıları, IApplicationBuilder Interface’inden türetilen bir Class’a Extension olarak tanımlanan Method’ların istenilen sırada çalıştırılmasıni sağlayan modüler yapılardır. Bu yapılar ile birlikte;

Request’lerin istenilen kontrollerden geçirilmesi sağlanabilir,
Response’ların cache üzerinden türetilmesi sağlanabilir,
Uygulama üzerinde loglama mekanizmaları oluşturabilir,
Exception Handling için çözümler sağlanabilir
ve bunlara benzer birçok ihtiyaca yönelik çözümler oluşturulabilir.

- Strong OOP

## C# Language Versioning

![image](https://user-images.githubusercontent.com/44713722/182449885-1b170433-f402-4836-a6a7-d420d6a9f3b4.png)

Hello World in C#

using ile system namespace kullanılmış oluyor. System içierisindeki tüm referanslara erişebiliyoruz.

Console.writeline system'den geliyor. Onun içerisinde.

![image](https://user-images.githubusercontent.com/44713722/182450123-c4a3594f-2029-48ca-9ef5-f793c34f5fab.png)

## Types in C#

Referans ve Value type olarak ikiye ayrılıyor.

![image](https://user-images.githubusercontent.com/44713722/182450609-d535c736-bb50-4f28-8a7c-574320c599f1.png)


![image](https://user-images.githubusercontent.com/44713722/182450794-d3b55838-6a6d-489e-b347-a6c8e0983522.png)

## Stack vs Heap in Memory

![image](https://user-images.githubusercontent.com/44713722/182450867-ace398bd-324f-4cf8-b847-26c6549114d4.png)

int a= 10;
int b= 20; diyelim. Gider bunları Ram'in stack bölgesine yazar.

Fakat bir obje referans type'a geçtiğinde yine değeri stack'te tutuluyor fakat bunun pointer'ı yani referansı Heap bölgesinde tutulmuş oluyor.

            A a = new A(); // A nesnesi oluşturdum.
            a.i = 2;


            A b = new A();
            b.i = 6;

            A c = b;
            c.i = a.i;


            Console.WriteLine(a.i);
            Console.WriteLine(b.i);
            Console.WriteLine(c.i);
            
     public class A
    {


        public int i { get; set; }
    }
    
    her birine a, b, c elemanlarına 2 değerini basar.
    
Buradaki tüm olay şöyle;

![image](https://user-images.githubusercontent.com/44713722/182463314-af2dce5e-4132-4eec-ab0c-aa77594073d6.png)

## Stack vs Heap in memory

![image](https://user-images.githubusercontent.com/44713722/182463869-cab91088-9dec-478d-b787-b293ddf484af.png)

heap'te size değişebliyor bu sebeple daha karmaşık.


Bütün tipler objectten geliyor. Tiplerin babası objecttir.

referans typle'lar default null olarak gelir.

Default vlues of C# typles
![image](https://user-images.githubusercontent.com/44713722/182465031-35f4b476-1dfb-40c6-b177-d1e6a375edb7.png)


## Keywords in C#

uygulamayı yazmamıza olanak sağlarlar.

goto: 
sealed: mühürlemek. bunu kalıtım alamazsın demek için kullanıyoruz. inharet almasını istemediğimiz durumlarda kullanabiliriz.
fixed: garraed collector ile iligi bir konu.

Goto örnek:

            var a = Sehirler.Ankara;

            switch (a)
            {
                case Sehirler.Adana:
                    break;
                case Sehirler.Ankara:
                    goto case Sehirler.Istanbul;
                case Sehirler.Antalya:
                    break;
                case Sehirler.Istanbul:
                    Console.WriteLine(" İstanbul !"); break;
                default:
                    break;
            }

![image](https://user-images.githubusercontent.com/44713722/182465238-df1c383c-19cb-4984-b4bf-0cfa871cd40c.png)


## Keywords : Access Modifiers

6 tanedir.

public : herhangi bir kısıtlama olmadan. using ekler erişiriz.
protected: ancak ve ancak türetilmiş class'larda. Base aldığınız class üzerinden erişebilirsin.
internal: türetilmiş sınıf üzerinden erişilir yine. O assembly yani o projede kullanırız. Bir sonraki proje görmez.
protected internal: hem aynı assembly hemde türetilmiş sınıf üzerinden. ikisinin birleşimi.
private: o an ki class'tan erişiriz. Dışarıdan erişemeyiz.
private protected

![image](https://user-images.githubusercontent.com/44713722/182468077-0a910e09-d2ae-4172-83ea-2cfaf04c9338.png)

## Keywords: Const & Readonly Modifiers

Const: sabit değer verebiliyoruz. sürekli değişen değerleri sabitleyeceğimiz zaman kullanıyoruz. ilk aldığı değerden sonra değiştirmeye izin vermez. 
Readonly: constracture içerisinde tanımlanıyor. Değişmeyecek bir değer. Sınıf içerisinde değiştirmeye izin veriyor. fakat contructer dışında tanımlamaya izin vermez.

![image](https://user-images.githubusercontent.com/44713722/182469741-4094a426-d209-4282-9a54-7630d46493b9.png)

Read only referanslarda kullanıldığında açık mı? Araştırılabilir.

Keywords: Stattements

## Exception handling Statement mıdır? mülakat sorusu :) cevap evet.

kendi içieriisnde 4'e ayrılıyor.

![image](https://user-images.githubusercontent.com/44713722/182471089-5e5ebce2-5461-4d8a-bdab-10bbe7bfa2d2.png)

Operator: Logical NEgotation

Bir değiştkene false atanmış. ! ie terisini alabiliyoruz. checbox'larda kullanabiliriz.

![image](https://user-images.githubusercontent.com/44713722/182471730-96d3b08a-3080-48e5-9579-9ff08e3e4067.png)


## Operator : Null Coalescing 

?? operatorudur soldaki değer null'sa sağdaki ifadeyi döndürür.

null - coalescing Assigment ise soldaki null'sa sağdaki ifadeyi assign ediyor.

Çıktı ne olur?

            List<int> numbers = null;
            int? a = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(a);
 
ilk başta numbers null olduğundan 5 atar yazdı.
numbers.Add(a ??= 0); a halen null o halde gitti 0'ı numbers dizisine atadı.
Console.WriteLine(a); a'yı sıfıra atadığımız için en son a yı yazdı.
Sonuç alt bölümdeki gibi.            
![image](https://user-images.githubusercontent.com/44713722/182474236-31ace240-22ff-4002-8ad5-b0f5c186b724.png)
            

## Boxing / Unboxing in C#

![image](https://user-images.githubusercontent.com/44713722/182475459-5668d192-34d0-4946-a699-7bdeabe9b30b.png)

int i 123 atadık.
object nesnesi tanımladık ve o 'ya i atadık. Bu işlem bir boxing işlemi.

![image](https://user-images.githubusercontent.com/44713722/182476340-40d63ef5-e817-42ea-878e-b40d75ffb6f0.png)

Yani value type olan bir şeyi referans type olarak tutmuş olduk. Buna boxing denir. int 123 değerini gdip heap bölgesinde tutabilmiş olduk.

.net'in birçok alanında boxing var. Bilemediği değerleri object olarak tutuyor.

## Exception Handling

Try:
Catch
Finally: Try ve catch'ten bağımsız olarak en son çalışan kod bloğudur.
Throw
![image](https://user-images.githubusercontent.com/44713722/182477596-90ba4aa2-d823-4251-b014-caff10929c15.png) 

Mülakat sorusu 2: stackoverflowexception nedir? Araştır.

Alttaki ne döner?
            try
            {
                ThrowEx();
            }
            catch (Exception _)
            {
                Console.WriteLine(_.Message);
            }
            
        static void ThrowEx()
        {
            try
            {
                throw new Exception("Try Exception");
            }
            catch (Exception _)
            {
                throw new Exception("Catch Exception");
            }
            finally
            {
                throw new Exception("Finally Exception");
            }
        }            
    
Finally çalışıyor.

![image](https://user-images.githubusercontent.com/44713722/182480706-f9c4ee75-db4f-47cc-ad29-a0820614e0cd.png)

exception en son yazmak lazım çünkü en genel sınıftır.

![image](https://user-images.githubusercontent.com/44713722/182583601-719fe6c9-677a-4376-a9a1-e46d07ed1246.png)

Readonly hatası verir. Constructure olarak çalışıyor üstü.

## Http Protocol

client server protokolüdür. 

![image](https://user-images.githubusercontent.com/44713722/182584535-b86a959b-c137-499a-988d-7808270db435.png)

![image](https://user-images.githubusercontent.com/44713722/182584583-a3db87ba-290f-4e76-bf93-74577a2355be.png)

## Web Api World

Rest is a web Protocol?

Hayır değildir. Standartlar bütünü diyebiliriz. 

Rest ile restfull farkı nedir?

Rest standartlar bütünü,
Restfull bu standartların çalıştığı tüm uygulamalardır.

![image](https://user-images.githubusercontent.com/44713722/182585522-f437f159-2564-4d6a-b56f-3c08bcba8815.png)


Stateles ne demek?

Sunucu istek yaptığımızda kim yaptığı bilgisini tutmaz. seasion tutmaz. state tutmaz.

Stateless tüm meta datalarının server'a iletilmesini belirtiyor. 
Sunucuya gelen isteğin istemcinin bütün bilgilerini üzerinde barındırması gerekiyor.

Responce'u catch yapabiliyoruz. Soap'ta yok

![image](https://user-images.githubusercontent.com/44713722/182586224-ff711399-4b03-4677-9c30-2c6bb01b97a3.png)

![image](https://user-images.githubusercontent.com/44713722/182586261-404c6946-fa58-4e17-a4cc-ce888235d963.png)

![image](https://user-images.githubusercontent.com/44713722/182586415-66d17c41-513d-463d-a21b-a81a8ad2851f.png)

## Json

Soap'a göre daha okunabilir. Hem okunabilir hem de makinanın anlayabilieceği bir dil.
![image](https://user-images.githubusercontent.com/44713722/182586569-42ea5100-be63-44ef-8de0-527bcc808223.png)

6 data type'ı destekliyor.
- number 
- string
- boolean
- array
- object 
- null

birtek datetime yok ama bunu da framework bazında datetime olarak parse ediyoruz.

## Soap Service
sales force, CRM Dynamic geliştirdiğimizde buna bulaşmak durumunda kalırız.

![image](https://user-images.githubusercontent.com/44713722/182587322-90996af9-39bc-4d01-a24a-83ac7e70c7ab.png)

## Object in C# Abstraction

Nesnelerin modellendiği bir yapı.

## OOP in C# : Class & Object 
![image](https://user-images.githubusercontent.com/44713722/182620618-9d915bfd-53ef-409f-969d-c95f5e7e5908.png)

## OOP in C# : Interface

- no access modifier
- implament verilen sınıfta declare etmek gerek.
![image](https://user-images.githubusercontent.com/44713722/182620707-2ce0b70b-b7c4-4155-a57f-5d6b62110b01.png)


## OOP in C# : Inheritance

![image](https://user-images.githubusercontent.com/44713722/182621056-e29e2b4d-34be-4622-b4c7-747af2452131.png)

ana sınıf base class
türetilmiş sınıf derived class olarak bilinir

## OOP in C# : Polymorphism

4'e ayrılır.
OOP'de kritik.
SOLID'te değişime kapalı fakat genişleyen kodlar kullanmamız gerekiyor.

- method overloading : Aynı isimde birden fazla parametre alabiliyor. 

![image](https://user-images.githubusercontent.com/44713722/182622308-1dd0140e-3665-4573-a37f-a2cdad867a5a.png)
- parameter overloading
virtual tanımlamlar derived class'larda ezilebiliyor.

![image](https://user-images.githubusercontent.com/44713722/182622498-868e5159-9178-42e0-9f8c-16207b434d25.png)

Türlere göre speak methodunu türettik. 
- method overriding

- method hiding
- 
![image](https://user-images.githubusercontent.com/44713722/182622948-591f3573-299f-4a59-96d1-d339ec4421ea.png)

OOP  in C# : Encapsulation
--yazılcak sonra

## Abstract Class ile Interface arasındaki fark nedir?

ikisinde de implemante ediliyor.

İkisinde de new yapamazsın. Ancak kalıtım verebliriz.

![image](https://user-images.githubusercontent.com/44713722/182624675-c5c1b09e-f615-424c-b38c-1957971b4c88.png)

Birds'u IFly dan imlemente edelim. >>>> Kuş uçabilir. Can Be durumu var burada.
Birds'u Animaldan abstract class alalım. >> Kuş bir hayvandır. Is A ilişkisi. Bu budur deriz.

## Nested Type nedir?

Sınıf içerisinde tanımlananlara denir.

![image](https://user-images.githubusercontent.com/44713722/182625932-7adf7f4e-1859-4bc2-9762-477d9f2cf831.png)

hazırlık sorum:
Ajax nedir?

AJAX, Asynchronous JavaScript and XML, Türkçe olarak Eşzamansız ve XML’in kısaltılmışıdır. Sunucuya gelen herhangi bir isteği arkaplanda işleyerek web uygulamalarının
eşzamanlı olmadan çalışmasına olanak sağlayan bir takım web geliştirme teknikleridir.
Hem JavaScript, hem de XML AJAX’da eşzamanlı olmadan çalışır. 
Sonuç olarak, AJAX kullanan herhangi bir web uygulaması tüm sayfayı yenileme ihtiyacı olmadan veri yollayabilir ve alabilir.

String ile StringBuilder farkı nedir?

StringBuilder dediğimiz sınıf,string verilerin + operatörüyle birleşme işleminin aynısını yapmaktadır.Ancak + operatörüyle stringler birleştirilirken bellekte birsürü
geçiçi string ifadeler oluşturulur.Bu işlemlerde büyük oranda performans kaybına sebep olmaktadır.Sonucta bu ifadelerin yan yana birleşmiş hali elde edilmeye
çalışılmaktadır.Ve bu işlemi StringBuilder sınıfını kullanarak yaparsak büyük oranda performans kaybını önlemiş oluruz.

Append(), AppendLine() methodları örnektir.



