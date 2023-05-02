# Hastane Otomasyon Sistemi

Bu proje C# programlama dili kullanarak bir hastane otomasyon sistemi oluşturmayı amaçlar. Projenin amacı, hastaların randevu alması, doktorların ve tıbbi personelin hasta kayıtlarını güncellemesi ve hastaların tıbbi geçmişlerini yönetmesi için bir arayüz sağlamaktır.

## Özellikler

- Hasta kaydı oluşturma, düzenleme ve silme işlemleri
- Randevu alma, randevu iptali ve randevu tarihçesi görüntüleme
- Doktorların hasta kayıtlarını görüntüleme ve güncelleme yeteneği
- Tıbbi personelin hasta kayıtlarını görüntüleme ve güncelleme yeteneği
- Hastaların tıbbi geçmişlerini görüntüleme

## Sorular

- Soru: Motivasyonunuz (Neden böyle bir proje yapmak istiyorsunuz)?

- Cevap: Bu proje, sağlık sektöründe daha verimli bir yönetim sağlamayı amaçlayan bir hastane otomasyon sistemi geliştirmek için yapılmaktadır. Projenin temel motivasyonu, hastaların, doktorların ve diğer tıbbi personelin verilerinin kolayca yönetilebilmesini ve hastaların sağlık hizmetlerine daha hızlı ve kolay erişim sağlamasını sağlamaktır. Bu proje, hastane otomasyon sistemlerinin nasıl çalıştığını anlamak ve benzer uygulamalar geliştirmek için iyi bir örnek oluşturacaktır.

- Soru: Amacınız (Proje sonunda ortaya çıkan yazılımın ne gibi özellikleri olacak)?

- Cevap: Bu proje sonunda ortaya çıkan yazılım, hastanelerdeki verilerin yönetimi için bir arayüz sağlayan bir hastane otomasyon sistemi olacaktır. Yazılımın temel özellikleri, hastaların kayıt oluşturma, randevu alma, randevu iptali, doktorların hasta kayıtlarını güncelleme ve tıbbi personelin hasta kayıtlarını görüntüleme olacaktır. Bu yazılım ayrıca, doktorların, tıbbi personelin ve hastaların farklı yetkilere sahip olabileceği bir rol tabanlı yetkilendirme sistemi de içerecektir.

- Soru: Projenizde kullanacağınız muhtemel veritabanı tabloları neler olacaktır?

- Cevap: Bu projede kullanılacak veritabanı tabloları, hastaların, doktorların, randevuların ve tıbbi kayıtların bilgilerini tutacak şekilde tasarlanacaktır. Hastane otomasyon sistemi için muhtemel tablolar arasında "Hasta", "Doktor", "Randevu" ve "Tıbbi Kayıt" tabloları yer alacaktır. Bu tabloların sütunları, ilgili verilerin yönetimi ve işlenmesi için gerekli olan bilgileri içerecektir. Örneğin, "Hasta" tablosu, hastaların adı, soyadı, doğum tarihi, telefon numarası, adresi gibi bilgileri içerebilir. "Doktor" tablosu, doktorların adı, soyadı, uzmanlık alanı, çalıştığı bölüm gibi bilgileri içerebilir. "Randevu" tablosu, randevu tarihi, saati, doktorun adı, hastanın adı gibi bilgileri içerebilir. "Tıbbi Kayıt" tablosu ise hastaların tıbbi geçmişi, tedavi geçmişi, ilaç kullanım


## Veritabanı Tasarımı
 
Bu hastane otomasyon sistemi projesi için aşağıdaki tabloların kullanılması önerilir:

1. Hasta Tablosu: Bu tablo, hastaların kişisel bilgilerini içerir. Bu bilgiler arasında ad, soyad, doğum tarihi, cinsiyet, telefon numarası, adres gibi bilgiler yer alabilir.

2. Doktor Tablosu: Bu tablo, hastanede çalışan doktorların bilgilerini içerir. Bu bilgiler arasında doktorun adı, soyadı, uzmanlık alanı, çalıştığı bölüm, telefon numarası, adres gibi bilgiler yer alabilir.

3. Randevu Tablosu: Bu tablo, hastaların doktorlarla randevu alması için kullanılır. Bu tablo, randevu tarihleri, saatleri, doktorun adı, hastanın adı gibi bilgileri içerebilir.

4. Tıbbi Kayıt Tablosu: Bu tablo, hastaların tıbbi kayıtlarını içerir. Bu bilgiler arasında hastanın tıbbi geçmişi, tedavi geçmişi, ilaç kullanımı, laboratuvar sonuçları gibi bilgiler yer alabilir.

Bu tabloların yanı sıra, kullanıcı hesapları için bir kullanıcı tablosu da oluşturulabilir. Bu tablo, kullanıcı adları, şifreler, roller gibi bilgileri içerebilir ve sisteme giriş yapan kullanıcıların kimlik doğrulama işlemleri için kullanılabilir.

## Kullanılan DML Komutları

Bu proje için aşağıdaki DML komutları kullanılabilir:

- SELECT: Veritabanından veri almak ve görüntülemek için kullanılır.
- INSERT: Veritabanına yeni veri eklemek için kullanılır.
- UPDATE: Veritabanındaki mevcut verileri güncellemek için kullanılır.
- DELETE: Veritabanından mevcut verileri silmek için kullanılır.

Ayrıca, WHERE, AND, OR, >=, <=, ve '' (tek tırnak) gibi diğer SQL sorgu anahtar kelimeleri de kullanılabilir.


## Gereksinimler

Bu proje için aşağıdaki gereksinimlere ihtiyaç duyulmaktadır:

- Visual Studio 2019 veya daha yükseği
- .NET Framework 4.7.2 veya daha yükseği
- Microsoft SQL Server 2016 veya daha yükseği

## Kurulum

1. Bu GitHub deposunu klonlayın: `git clone https://github.com/Iskenderun-Technical-University/donem-projesi-Atakan-Emre.git`
2. Visual Studio'da `HastaneOtomasyonu.sln` dosyasını açın.
3. Proje içindeki `HastaneOtomasyonu.bak` dosyasını SQL Server'a geri yükleyin.
4. `Web.config` dosyasını açın ve `connectionString` bölümünü kendi veritabanı bağlantı bilgilerinizle güncelleyin.
5. Proje başlatın ve kullanmaya başlayın!

## Katkıda Bulunma

Bu projeye katkıda bulunmak isterseniz, lütfen bir çekme isteği gönderin. Herhangi bir hatayı veya sorunu bildirmek için bir konu açabilirsiniz.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

## İletişim

- Sahin Atakan Emre - 222523302 - [sahinemre.mdbf22@iste.edu.tr](mailto:sahinemre.mdbf22@iste.edu.tr)
