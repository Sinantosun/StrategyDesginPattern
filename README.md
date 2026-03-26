Strategy Design Pattern Implementation in .NET 10
Bu repo, sürdürülebilir ve genişletilebilir bir backend mimarisi inşa etmek için Strategy Design Pattern'ın .NET 10 ve modern Dependency Injection (DI) prensipleriyle nasıl uygulanacağını gösteren örnek bir projedir.

📌 Not: Bu proje, geliştirme süreçlerini ve mimari kararlarını detaylandırdığım teknik blog yazımın uygulama örneğidir.

🚀 Projenin Amacı
Yazılım geliştirme süreçlerinde sıkça karşılaşılan "birbirine bağımlı if-else blokları" ve "Open/Closed Principle" ihlallerini, davranışları birbirinden ayrıştırarak (decoupling) çözmeyi hedefler. Örnek senaryo olarak bir Bildirim Sistemi (Notification System) ele alınmıştır.

Öne Çıkan Çözümler:

- Dinamik Strateji Seçimi: Çalışma zamanında (runtime) kullanıcı tercihine göre strateji belirleme.

- Yüksek Performans: Stratejilerin uygulama başlangıcında Dictionary ile önbelleğe alınması.

- SOLID Uyumu: Yeni bir bildirim kanalı eklerken mevcut koda dokunmadan genişleme imkanı.

Mimari Yapı

Proje üç ana katman üzerine inşa edilmiştir:

- Interface (INotificationStrategy): Tüm stratejilerin uyması gereken ortak sözleşme.

- Concrete Strategies: EmailNotification, SmsNotification gibi iş mantığını barındıran sınıflar.

- Strategy Provider: DI Container üzerinden gelen stratejileri yöneten ve hızlı erişim sağlayan merkez.

Blog Yazısı ve Teknik Detaylar
Bu projenin arkasındaki teorik altyapıyı, "Neden If-Else yerine bu deseni kullanmalıyız?" sorusunun yanıtını ve implementasyon detaylarını blog yazımda bulabilirsiniz:

👉 Strategy Pattern: Esnek ve Sürdürülebilir Mimari İnşası: https://sinantosun.com/blog-detayi/dotnet-10-strategy-design-pattern-ile-surdurulebilir-mimari
