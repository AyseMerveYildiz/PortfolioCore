#  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Rocket.png" alt="Rocket" width="35" height="35" /> Kişisel Portfolyo Projesi
 Merhaba! Bu proje, M&Y Akademi bünyesinde, değerli eğitmenimiz Murat Yücedağ rehberliğinde .NET Core 6.0 kullanılarak geliştirdiğim kişisel portfolyo uygulamasıdır. Amacım, hem teknik becerilerimi sergilemek hem de dinamik içeriklerle kullanıcı dostu bir web sitesi oluşturmaktı.

## <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Glowing%20Star.png" alt="Glowing Star" width="25" height="25" /> Kullanılan Teknolojiler ve Yapılar

- **ASP.NET Core 6.0**: Proje altyapısı olarak modern .NET Core mimarisi tercih edildi.
- **Entity Framework (Code First)**: Veritabanı işlemleri için EF Code First yöntemi kullanıldı.
- **MSSQL**: Veritabanı sistemi olarak tercih edildi.
- **Partial View & ViewComponent**: UI yapısı bölünerek düzenli ve yeniden kullanılabilir hale getirildi.
- **Tek Katmanlı Mimari**: Projede basit ve anlaşılır bir katman yapısı izlendi.

 ## 📁 Proje Yapısı

## 🔹 Kullanıcı Arayüzü (UI)
Ziyaretçilerin erişebileceği, veritabanından dinamik olarak gelen içeriklerin yer aldığı tasarımsal arayüzdür. Aşağıdaki bölümlerden oluşur:

- **Hakkımda**  
- **İstatistikler (ViewBag + LINQ ile)**  
- **Yeteneklerim**  
- **Eğitim & Deneyim**  
- **Projeler (Kategori bazlı filtreleme)**  
- **Hizmetler (Sınırlı gösterim mantığı)**  
- **Referanslar & Yorumlar**  
- **İletişim & Mesaj Gönderme (SweetAlert ile bildirim)**  
- **Google Harita & Footer**  
- **404 Hata Sayfası**

  ## 🔹 Yönetim Paneli (Admin)
Admin kullanıcıların içerikler üzerinde CRUD işlemleri gerçekleştirdiği bölümdür. Her alan ID üzerinden tanımlanarak düzenleme kolaylaştırılmıştır:

- Deneyimlerim  
- Eğitimlerim  
- Hakkımda  
- İletişim Bilgileri  
- Hizmetlerim  
- Referanslarım  
- Projelerim / Portfolyo  
- Yeteneklerim  
- Gelen Kutusu (Okundu/Okunmadı takibi)  
- Sosyal Medya Bağlantıları  
- İstatistikler (Toplam, ortalama ve filtreli veriler)

## 🔹 Kullanıcı Arayüzü (UI)
### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Öne Çıkanlar

#### "Feature" alanında gösterilen öne çıkanlar verisi, veritabanından dinamik olarak çekilmiştir. Sosyal medya bileşenleri ise nested PartialView yapısıyla ayrı bir modül olarak yönetilmiş ve sayfa bütünlüğü bozulmadan entegre edilmiştir.
![image](https://github.com/user-attachments/assets/8fd24506-d009-45da-b686-564dc1545381)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Hakkımda
#### Hakkımda bölümü, Entity Framework aracılığıyla veritabanından dinamik olarak çekilen verilerle oluşturulmuş ve sayfa yapısına entegre edilmiştir.
![image](https://github.com/user-attachments/assets/a14466fc-331f-4d97-8ab5-766a73f90b50)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> İstatistik
#### İstatistik verileri, LINQ sorguları aracılığıyla işlenmiş ve ViewBag üzerinden UI katmanına taşınmıştır. Toplam referans sayısı, portfolyo adedi, yetenek sayısı gibi metrikler bu yöntemle hesaplanırken; ayrıca her sayfa yenilemesinde rastgele 10 ile 20 arasında sayı üreten özel bir algoritma da entegre edilmiştir.
![image](https://github.com/user-attachments/assets/654a5476-223e-4823-8233-34846edb3112)


### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Yetenekler
#### Yetenekler bölümü, Entity Framework aracılığıyla veritabanından dinamik olarak çekilen verilerle oluşturulmuş ve sayfa yapısına entegre edilmiştir.
![image](https://github.com/user-attachments/assets/cfcf9301-0ac7-4a64-93a2-e7b0a4fd15fe)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Eğitimler & Deneyimler
#### Eğitimler & Deneyimler bölümü, Entity Framework aracılığıyla veritabanından dinamik olarak çekilen verilerle oluşturulmuş ve sayfa yapısına entegre edilmiştir.
![image](https://github.com/user-attachments/assets/fc15ce0b-a71a-4418-97ba-ec87c3dfb4d1)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Projeler
#### Projeler, kategori tablosu ile ilişkilendirilmiş bir model yapısı kullanılarak düzenlenmiş ve her kategoriye ait projeler dinamik olarak sorgulanıp listelenmiştir. Bu sayede kategori bazlı filtreleme sağlanarak esnek ve genişletilebilir bir yapı oluşturulmuştur.
![image](https://github.com/user-attachments/assets/65a57797-fb76-4355-ba28-006012d11a42)
![image](https://github.com/user-attachments/assets/d85a7d6b-ca82-4fcb-acd6-420096ccfff5)
![image](https://github.com/user-attachments/assets/646d45b1-a848-4274-b767-70545bacdf9a)
![image](https://github.com/user-attachments/assets/a831d337-0c76-402f-a903-73050e78c0a9)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Hizmetler
#### Hizmetler bölümü, Entity Framework aracılığıyla veritabanından dinamik olarak çekilen verilerle oluşturulmuş ve sayfa yapısına entegre edilmiştir. Ancak, toplamda 8 hizmet verisi sisteme eklenmiş olup, sadece 6'sı UI katmanında kullanıcıya sunulacak şekilde filtrelenmiştir.
![image](https://github.com/user-attachments/assets/95b6a198-266c-4b22-a8a3-585a36b63ada)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Referanslar
#### Referanslar bölümü, Entity Framework aracılığıyla veritabanından dinamik olarak çekilen verilerle oluşturulmuş ve sayfa yapısına entegre edilmiştir.
![image](https://github.com/user-attachments/assets/d6a045ac-ef27-4e48-a105-e28fb008db4d)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> İletişim & Mesaj
#### İletişim bilgilerim, iki ayrı bileşene ayrılarak yapılandırılmıştır. İlk bileşen, "Contact" kısmı olarak tanımlanmış ve veritabanından dinamik veri çekimi için Entity Framework kullanılmıştır. İkinci bileşen, mesaj gönderme işlevi için özel olarak ayrılmış ve iç içe Partial View yapısı ile yönetilmiştir. Mesaj iletme işlemi, Message sınıfı üzerinden gerçekleştirilmiş ve POST yöntemiyle işlenmiştir. Mesaj gönderildikten sonra sayfa yenilenir ve işlem başarısı, kullanıcıya SweetAlert ile görsel bir bildirim olarak iletilir
![image](https://github.com/user-attachments/assets/969385b5-43f1-4aa7-bbe6-34411ccfa945)

![image](https://github.com/user-attachments/assets/4514f176-a9bc-45b3-80f6-f994ba4cdbab)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> Harita
#### Projeme, Google Maps entegrasyonu ile harita yapısı eklenmiştir. Lokasyon verisi ise veritabanından dinamik olarak çekilerek, harita üzerinde konum bilgisi görselleştirilmiştir. Bu sayede, harita üzerinde dinamik olarak güncellenebilen bir yapı oluşturulmuştur.
![image](https://github.com/user-attachments/assets/7b1a2827-84c9-4665-bf34-e5681857f619)

### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> 404 Not Found
#### Projeme, geçersiz veya hatalı bir URL girildiğinde kullanıcıya gösterilecek "404 Sayfa Bulunamadı" hata sayfası eklenmiştir. Bu işlem, .NET Core'un özelleştirilmiş hata yönetimi ve yönlendirme mekanizmaları kullanılarak gerçekleştirilmiştir. UseStatusCodePagesWithReExecute middleware'i, hata durumları için kullanıcıyı belirlenen bir hata sayfasına yönlendirmiştir. Bu sayede, 404 gibi hata kodları ile karşılaşıldığında, ilgili hata sayfası dinamik olarak yeniden işlenmiştir.
![image](https://github.com/user-attachments/assets/6783d8e4-3cee-4fc7-9c96-c2f3fed4a2fc)

#  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Smilies/Bomb.png" alt="Bomb" width="35" height="35" /> Admin Paneli

## <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Glowing%20Star.png" alt="Glowing Star" width="15" height="15" />Admin panelinde kullanıcı, sahip olduğu deneyim verilerini görüntüleyebilir ve bu veriler üzerinde CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirebilir. Güncelleme işlemi sırasında, ilgili veriler veritabanından ID'ye göre otomatik olarak yüklenir.
### <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Travel%20and%20places/Sun.png" alt="Sun" width="25" height="25" /> CRUD İşlemleri Yapılan Admin Panelinden Alıntılar;

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Hakkımda
![image](https://github.com/user-attachments/assets/9903c96a-9aba-47d7-9962-5bbd19a23929)
![image](https://github.com/user-attachments/assets/6efa4f19-a12f-4dd4-82b5-186aad4e56a8)
![image](https://github.com/user-attachments/assets/184b49c3-1a5c-46d5-b742-c58a899ddbf0)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Eğitim Hayatım
![image](https://github.com/user-attachments/assets/c3248cc1-a273-4081-a13e-0af8e37ace40)

![image](https://github.com/user-attachments/assets/fb909405-413a-4d02-b950-e95bc2daae32)
![image](https://github.com/user-attachments/assets/e2b33fff-81bf-492b-9881-0f2afec12847)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Deneyimler

![image](https://github.com/user-attachments/assets/52e2b100-a79c-4381-92ba-c60f3e67103b)
![image](https://github.com/user-attachments/assets/d33a5de3-03dc-4c04-a21b-7d89d549497b)
![image](https://github.com/user-attachments/assets/73765f2a-d249-4e45-ad90-e5eef2c24ed8)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Projeler


![image](https://github.com/user-attachments/assets/6b2df31a-144a-45c0-bbe3-545de2700e0a)
![image](https://github.com/user-attachments/assets/b535ed30-cf5e-4183-9407-6fe7a3b9d1f4)
![image](https://github.com/user-attachments/assets/fc3f1e39-d6fe-4e6c-9381-bd31d5f23258)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Projeler

![image](https://github.com/user-attachments/assets/cb72ec28-aa26-45c1-ba66-54fa0504d607)
![image](https://github.com/user-attachments/assets/92c451fa-8fd2-4865-938b-7c38365885b2)
![image](https://github.com/user-attachments/assets/84828acd-5442-483c-8d03-abed366f7e48)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Yetenekler
![image](https://github.com/user-attachments/assets/49a3c430-bc64-4f1c-91dc-89c3771558e3)
![image](https://github.com/user-attachments/assets/8cdb5b57-d6da-42ba-824e-ae13d838af17)
![image](https://github.com/user-attachments/assets/3a13135a-b5ac-4eed-a14f-85108b29e6fb)
####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  İstatistikler

![image](https://github.com/user-attachments/assets/ba9b5cd9-3aca-4ff7-abb5-4a7272c75b3e)
####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Hizmetler
![image](https://github.com/user-attachments/assets/2f45a3a9-31e9-468b-a743-2b45050ec561)
![image](https://github.com/user-attachments/assets/dadc8636-c893-4140-80bb-598829c6fb7e)
![image](https://github.com/user-attachments/assets/42628df1-7f29-4bfe-8064-8b78c02e8747)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Gelen Kutusu
Admin panelindeki mesaj yönetimi modülünde, kullanıcıya iletilen tüm mesajlar veritabanından dinamik olarak çekilmekte ve varsayılan olarak "Okunmadı" durumu ile işaretlenmektedir. Kullanıcı, mesajları detaylı şekilde görüntüleyebilir, okundu bilgisini güncelleyebilir veya ilgili mesajı sistemden silebilir. Bu yapı, mesajların durum yönetimi ve veri bütünlüğünü sağlamak adına optimize edilmiştir.

![image](https://github.com/user-attachments/assets/0a67dd45-233c-438f-8a20-bc5802b4bb04)
####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" />  Sosyal Medya
![image](https://github.com/user-attachments/assets/ea4df2f3-61a0-4620-ac25-f8ab65392d33)
![image](https://github.com/user-attachments/assets/f01160e2-d871-429d-b376-4ff8778f8c13)
![image](https://github.com/user-attachments/assets/31f3c6cc-3404-4dbb-a6b5-44662fa88cf7)

####  <img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Animated-Fluent-Emojis/master/Emojis/Symbols/Triangular%20Flag.png" alt="Triangular Flag" width="35" height="35" /> İletişim
![image](https://github.com/user-attachments/assets/eca97ac5-11fb-451e-b0e9-f916fb8530bc)
![image](https://github.com/user-attachments/assets/d77146e8-a23e-439e-8f95-35c247cc0c95)
![image](https://github.com/user-attachments/assets/1437a7de-cfee-4633-a048-c4c3d7827b92)




