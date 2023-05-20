<a href="https://www.youtube.com/c/@gencayyildiz">Kaynak : Gençay Yıldız - Youtube</a>

<h2>RabbitMQ</h2> 

<h3>Message Queue Nedir ?</h3>
<ul>
    <li>Message Queue, yazılım sistemlerinde iletişim için kullanılan bir yapıdır.</li>
    <li>Birbirinden bağımsız sistemler arasında veri alışverişi yapmak için kullanılır.</li>
    <li>Message Queue, gönderilen mesajları kuyrukta saklar ve sonradan bu mesajların işlenmesini sağlar.</li>
    <li>Kuyruğa mesaj gönderene Producer(Yayıncı) ya da Publisher, kuyruktaki mesajları işleyene ise Consumer(Tüketici) denir.</li>
    <li>Burada ki "message" kavramının anlamı, iki sistem arasında iletişim için kullanılan veri birimidir. Yani Producer'ın Consumer tarafından işlenmesini istediği verinin kendisidir.</li>
    <li>Örnek: Bir E-Ticaret sisteminden örnek vermek gerekirse eğer siparişe dair mesaj olarak; sipariş numarası, müşteri bilgileri, ürün bilgileri veya ödeme bilgileri örnek verilebilir.</li>
    <li>Message Queue içindekileri, Consumer sırasıyla tüketir.</li>
</ul>

<h3>Message Queue'nun Amacı Nedir ?</h3>
<p>Bazı senaryolarda birbirlerinden farklı sistemler arasında işlevsel açıdan senkron haberleşmek kullanıcı deneyimi açısından pek uygun olmayabilmektedir.</p>
<p>Buna örnek vermemiz gerekirse eğer, bir e-ticaret uygulamasında ödeme işlemi neticesinde fatura oluşturabilmek için ilgili servisin işlemi senkron bir şekilde beklemek ve bunu son kullanıcıya yansıtmak mantıklı bir davranış olmayacaktır. Bu tarz senaryolarda sistemler arasında senkrondan ziyade asenkron bir iletişim modeli benimsenmelidir. Ödeme neticesinde kullanıcıya siparişin başarıyla gerçekleştiğine dair sonuç dönülürken bir yandan da message queue'ya fatura ile ilgili bir mesaj gönderilmelidir. Bu mesaj, fatura servisi tarafından ilk fırsatta alınarak işlenir/tüketilir ve son kullanıcı fatura oluşturma sürecini beklemeksizin ilgili siparişe dair fatura asenkron şekilde üretilir. Böylece süreçte sistemler arasındaki iletişim daha verimli hale gelmiş olur ve işlemler arasında bekleme veya gecikme durumu söz konusu olmaz.</p>

<h3>Message Broker Nedir ?</h3>
<ul>
   <li>İçerisinde Message Queue'yi barındıran ve bu queue üzerinden publisher/producer ile consumer arasındaki iletişimi sağlayan sistemdir.</li>
   <li>Bir Message Broker içerisinde birden fazla queue bulunabilir.</li>
</ul>

<h3>Message Broker Teknolojileri Nelerdir ?</h3>
<ul>
    <li>RabbitMQ</li>
    <li>Kafka</li>
    <li>ActiveMQ</li>
    <li>ZeroMQ</li>
    <li>NSMQ</li>
    <li>IronMQ</li>
    <li>Redis</li>
</ul>

<h3>RabbitMQ Nedir ?</h3>
<ul>
    <li>Open Source olan bir message queuing sistemidir.</li>
    <li>Erland diliyle geliştirilmiştir.</li>
    <li>Cross platform desteklenmesinden dolayı farklı işletim sistemlerinde kurulabilir ve kullanılabilir.</li>
    <li>Zengin bir dökümantasyona sahiptir.</li>
    <li>Cloud'da hizmeti mevcuttur.</li>
</ul>

<h3>RabbitMQ'yu Neden Kullanmalıyız ?</h3>
<ul>
   <li>Yazılım uygulamalarında ölçeklendirilebilir bir ortam sağlayabilmek istiyorsak eğer RabbitMQ kullanılabilir.</li>
   <li>Uygulamalarımızda kullanıcılardan gelen isteklerin neticelerine anlık cevap veremiyorsak ya da anlık olmayan işlemleri devreye sokmamız gerekiyorsa kullanıcıyı oyalamak yerine bu tarz süreçleri Asenkron bir           şekilde işleyip uygulama yoğunluğunu düşünmemiz gerekmektedir.</li>
   <li>Aksi takdirde kullanıcı gereksiz bir response time süresine maruz kalacak ve yazılımımız aleyhine bir durum söz konusu olacaktır.</li>
   <li>İşte bu tarz durumlarda asenkron süreci kontrol edecek olan yapı RabbitMQ'dur.</li>
   <li>RabbitMQ, response time'ı uzun sürebilecek operasyonları uygulamadan bağımsızlaştırarak buradaki sorumluluğu farklı bir uygulamanın üstlenmesini sağlayacak olan bir mekanizma sunmaktadır.</li>
   <li>Bu mekanizma uzun sürebilecek maliyetli işlemleri RabbitMQ aracılığıyla kuyruğa gönderecektir ve bu kuyruktaki işlemler farklı bir uygulama tarafından işlenerek sonuç asenkron bir şekilde ana uygulamadan               bağımsız elde edilecek, böylece ana uygulamadaki yoğunluk mümkün Mertebe minimize edilmiş olacaktır.</li>
</ul>

<h3>RabbitMQ'nun İşleyişi Nasıldır ? </h3>
<ul>
   <li>RabbitMQ, bir message broker olduğu için mesajları yayınlayan publisher/producer ve bu mesajları tüketen consumer servisleri tarafından ortak olarak kullanılmaktadır.</li>
   <li>Yapısal olarak Exchange ve Queue ensturmanları üzerinden işlevsellik göstermektedir. <span style="color: red;">Exchange: Mesajların nasıl işleneceğinin modelini sunar.</span></li>
   <li>Publisher mesajı publish ettikten sonra ilgili mesajı Exchange karşılayacak. Exchange ise belirtilen route ile mesajı ilgili kuyruğa yönlendirecektir. (Mesajın hangi queue'ya gideceği exchange içerisindeki            route'dan öğrenilir).</li>
   <li>Burada publisher ile consumer'ın hangi platformda hangi dil ile geliştirildiğinin hiçbir önemi yoktur! Bu mimari bütünsel olarak yazılım dilinden bağımsız bir işlevsellik sergilemektedir.</li>
   <li>AMQP protokolünü benimser.</li>
</ul>


