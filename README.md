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
