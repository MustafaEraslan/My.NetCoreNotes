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


### Keywords : Access Modifiers

6 tanedir.

public : herhangi bir kısıtlama olmadan. using ekler erişiriz.
protected: ancak ve ancak türetilmiş class'larda. Base aldığınız class üzerinden erişebilirsin.
internal: türetilmiş sınıf üzerinden erişilir yine. O assembly yani o projede kullanırız. Bir sonraki proje görmez.
protected internal: hem aynı assembly hemde türetilmiş sınıf üzerinden. ikisinin birleşimi.
private: o an ki class'tan erişiriz. Dışarıdan erişemeyiz.
private protected

![image](https://user-images.githubusercontent.com/44713722/182468077-0a910e09-d2ae-4172-83ea-2cfaf04c9338.png)

Keywords: Const & Readonly Modifiers

Const: sabit değer verebiliyoruz. sürekli değişen değerleri sabitleyeceğimiz zaman kullanıyoruz. ilk aldığı değerden sonra değiştirmeye izin vermez. 
Readonly: constracture içerisinde tanımlanıyor. Değişmeyecek bir değer. Sınıf içerisinde değiştirmeye izin veriyor. fakat contructer dışında tanımlamaya izin vermez.

![image](https://user-images.githubusercontent.com/44713722/182469741-4094a426-d209-4282-9a54-7630d46493b9.png)

Read only referanslarda kullanıldığında açık mı? Araştırılabilir.

Keywords: Stattements

Exception handling Statement mıdır? mülakat sorusu :) cevap evet.

kendi içieriisnde 4'e ayrılıyor.

![image](https://user-images.githubusercontent.com/44713722/182471089-5e5ebce2-5461-4d8a-bdab-10bbe7bfa2d2.png)

Operator: Logical NEgotation

Bir değiştkene false atanmış. ! ie terisini alabiliyoruz. checbox'larda kullanabiliriz.

![image](https://user-images.githubusercontent.com/44713722/182471730-96d3b08a-3080-48e5-9579-9ff08e3e4067.png)


Operator : Null Coalescing 

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
            

BBoxing / Unboxing in C#

![image](https://user-images.githubusercontent.com/44713722/182475459-5668d192-34d0-4946-a699-7bdeabe9b30b.png)

int i 123 atadık.
object nesnesi tanımladık ve o 'ya i atadık. Bu işlem bir boxing işlemi.

![image](https://user-images.githubusercontent.com/44713722/182476340-40d63ef5-e817-42ea-878e-b40d75ffb6f0.png)

Yani value type olan bir şeyi referans type olarak tutmuş olduk. Buna boxing denir. int 123 değerini gdip heap bölgesinde tutabilmiş olduk.

.net'in birçok alanında boxing var. Bilemediği değerleri object olarak tutuyor.

Exception Handling

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



