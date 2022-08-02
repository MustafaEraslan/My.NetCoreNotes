# My.NetCoreNotes

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

- Strong OOP

## C# Language Versioning

![image](https://user-images.githubusercontent.com/44713722/182449885-1b170433-f402-4836-a6a7-d420d6a9f3b4.png)

Hello World in C#

using ile system namespace kullanılmış oluyor. System içierisindeki tüm referanslara erişebiliyoruz.

Console.writeline system'den geliyor. Onun içerisinde.

![image](https://user-images.githubusercontent.com/44713722/182450123-c4a3594f-2029-48ca-9ef5-f793c34f5fab.png)

##Types in C#

Referans ve Value type olarak ikiye ayrılıyor.

![image](https://user-images.githubusercontent.com/44713722/182450609-d535c736-bb50-4f28-8a7c-574320c599f1.png)


![image](https://user-images.githubusercontent.com/44713722/182450794-d3b55838-6a6d-489e-b347-a6c8e0983522.png)

##Stack vs Heap in Memory

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

Stack vs Heap in memory

![image](https://user-images.githubusercontent.com/44713722/182463869-cab91088-9dec-478d-b787-b293ddf484af.png)

heap'te size değişebliyor bu sebeple daha karmaşık.


Bütün tipler objectten geliyor. Tiplerin babası objecttir.

referans typle'lar default null olarak gelir.

Default vlues of C# typles
![image](https://user-images.githubusercontent.com/44713722/182465031-35f4b476-1dfb-40c6-b177-d1e6a375edb7.png)


Keywords in C#

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



    
    
