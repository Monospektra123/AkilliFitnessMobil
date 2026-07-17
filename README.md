# Akıllı Fitness 

Kişisel antrenman ve vücut ölçümlerini takip etmek için geliştirdiğim cross-platform bir mobil uygulama. .NET MAUI kullanarak tek bir kod tabanı üzerinden hem iOS hem de Android için tasarlandı.

## 🚀 Güncel Durum ve Özellikler

Proje şu an aktif olarak geliştiriliyor. Tamamlanan ve üzerinde çalıştığım modüller şu şekilde:

* **[Tamamlandı] Kimlik Doğrulama:** Firebase Authentication ile kullanıcı kayıt ve giriş sistemi.
* **[Tamamlandı] Yönlendirme:** Güvenli giriş sonrası Dashboard ekranına geçiş işlemleri.
* **[Geliştiriliyor] Veritabanı Bağlantısı:** Cloud Firestore entegrasyonu (Kullanıcı verilerinin kaydedilmesi ve okunması için CRUD operasyonları yazılıyor).

## 💻 Kullanılan Teknolojiler

* **Platform & Dil:** C#, .NET MAUI, XAML
* **Backend & Veritabanı:** Firebase Authentication, Cloud Firestore

## 🛠️ Kurulum

Projeyi bilgisayarında test etmek istersen:

1. Repoyu bilgisayarına klonla:
   `git clone https://github.com/kullaniciadi/AkilliFitnessMobile.git`
2. Visual Studio 2022 ile solution dosyasını aç (.NET MAUI iş yükünün kurulu olduğundan emin ol).
3. Kendi Firebase projeni oluştur ve `google-services.json` dosyasını projeye dahil et (Firebase ayarları olmadan uygulama crash verecektir).
4. Hedef platformu seç (Android/iOS) ve çalıştır.
