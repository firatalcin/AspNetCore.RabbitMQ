# AspNetCore.RabbitMQ
Net 8 ile RabbitMQ

<h2>Message Queue Nedir?</h2>

<p>Message Queue, yazılım sistemlerinde iletişim için kullanılan bir yapıdır.</p>
<p>Birbirinden bağımsız sistemler arasında veri alışverişi yapmak için kullanılır.</p>
<p>Message Queue, gönderilen mesajları kuyrukta saklar ve sonradan bu mesajların işlenmesini sağlar.</p>
<p>Kuyruğa mesaj gönderene Prosuder(Yayıncı) ya da Publisher, kuyruktaki mesajları işleyene ise Consumer(Tüketici) denir</p>
<p>Asenkron çalışma modeli benimsemiştir.</p>

<h2>Message Broker Nedir?</h2>

<p>İçerisinde Message Queue'yi barındıran ve bu queue üzerinden publisher/producer ile consumer arasındaki iletişimi sağlayan sistemdir.</p>
<p>Bir Message Broker içerisinde birden fazla queue bulunabilir.</p>

<h2>RabbitMQ Nedir?</h2>

<p>RabbitMQ mesaj kuyruğu (message queue) sistemidir. Yazdığımız programımız üzerinden yapılacak asenkron (asynchronous) işlemleri sıraya koyup, bunları sırayla kuyruktan çekip gerçekleyerek ilerleyen ölçeklenebilir ve performanslı bir sistemdir. RabbitMQ kullanımına potansiyel bir örnek verecek olursak, bulk mail gönderme işlemlerini Server’ı yormayacak bir sisteme çevirmek için RabbitMQ kullanabilirsiniz. RabbitMQ bir çok yazılım diline destek vermektedir, bir çok işletim sistemi üzerinde çalışabilmektedir ve open source’dur.</p>

<h2>RabbitMQ Neden Kullanır?</h2>

<p>Günlük hayattan bir örnek verelim. Örneğin 1 mail atma işlemi gerçekleştireceksiniz. Bunun için yapmanız gereken tek şey gönderilecek mail’i ve içeriği ayarlayıp, gönder butonuna tıklamak. Sonrasında 2–3 saniye içerisinde gönderiniz gittiğine dair bir bildirim alacaksınız. Peki bu gönderilmesi gereken mail miktarı 1000 olsaydı. RabbitMQ gibi bir teknoloji kullanmadan böyle bir işlem yapmanız halinde, mail gönderilecek kişileri for döngüsünde maillerine tek tek göndermeniz gerekirdi. Peki bu işlem ne kadar sürer? 1 dakika sürdüğünü farz edin. 2022 yılındayız ve 1000 maili gönderdikten sonra 1 dakika onu bekliyoruz. Ne kadar berbat bir senaryo. İşte burada imdadımıza RabbitMQ yetişiyor.</p>
<p>Konunun daha iyi anlaşılması için bir örnek daha verelim. Bir sesi videoya gömülmesini sağlayan bir servisiniz var. Bu işlem videonun uzunluğuna göre değişecektir elbet. Örneğin 2 saatlik bir videoya sesin gömülmesi 10 dakika sürsün. Bu işlem başladığında her hangi bir nedenden gömme işlemi duraksamış olsun. Bu durumda sistem nerede kaldığını bilmediği için işlemi tekraradan başlatmamız gerekir. Bu çok sorun değil, sonuçta 10 dakikalık bir işlem. Peki bu işlemi YouTube kadar büyük bir platformda yaşandığını düşünün. Saate 5 milyon videonun yüklendiği bir platformda böyle bir şeyin yaşanması büyük kullanıcı kaybına neden olurdu. Tahmin edin burada imdadımıza kim yetişiyor :)</p>

<h3>Nelerlerde Kullanılabilir?</h3>
<ul>
<li>Yoğun E-mail gönderilen senaryolarda</li>
<li>Yoğun bir şekilde veri işlenmesinin bulunduğu alanlarda</li>
<li>Yoğun işlem hacminin bulunduğu yerlerde</li>
<li>Verilerin önemli olduğu yerlerde</li>
</ul>
