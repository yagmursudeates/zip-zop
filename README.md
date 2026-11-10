# Zip Zop — Midterm

Basic Game Dev Concepts I ara sınav projesi. Unity sürümü `6000.0.68f1`.

## Projeyi açma

1. RAR arşivini çıkart ve `YagmurSudeAtes_Project1` klasörünü Unity Hub’a ekle.
2. `Assets/Scenes/StartScene.unity` sahnesini aç.
3. Game görünümünde 1920 × 1080 çözünürlüğünü seç ve Play’e bas.
4. **Start** ile bölüme geç, **WASD** ile hareket et. **Esc** ana menüye döner. **Quit** Unity’de Play modunu durdurur, bağımsız derlemede uygulamayı kapatır.

## İçerik

Başlangıç sahnesinde beş parallax katmanı ve iki menü düğmesi var. Bölümde dört fiziksel sınır, beş göktaşı ve hareket animasyonu olan bir oyuncu bulunuyor. Karakterin `Assets/Character/ZipZop-Walk.png` sayfası üç kare içerir. Döngüde sol adım 0,20 sn, orta poz 0,10 sn, sağ adım 0,20 sn ve orta poz tekrar 0,10 sn sürer. Tuş bırakılınca karakter orta poza döner.

Sahne düzeni ve hareket sistemi, Yağmur Sude Ateş’in Fish and Chips projesinden uyarlanmıştır. Uzay çizimleri, Codex ile hazırlanan vektör çizimlerinden Unity dokularına dönüştürüldü. Menüde kullanılan Patrick Hand yazı tipinin lisansı `Assets/Fonts/PatrickHand/OFL.txt` dosyasında bulunur.
