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

<h3>Exchange Nedir ?</h3>
<p>Publisher tarafından gönderilen mesajların nasıl yönetileceğini ve hangi route'lara yönlendirileceğini belirlememiz konusunda kontrolü sağlayan, karar veren yapıdır</p>
<ul>
  <li>Route ise mesajların exchange üzerinden kuyruklara nasıl gönderileceğini tanımlayan mekanizmadır.</li>
  <li>Bu süreçte exchange'de bulunan routing key değeri kullanılır.</li>
  <li>Routing key ile mesajların hangi kuyruklara gönderileceği konusunda exchange'de bilgi tutulur.</li>
</ul>

<h3>Binding Nedir ?</h3>
<p>Exchange ve Queue arasındaki ilişkiyi ifade eden yapıdır. Exchange ile kuyruk arasında bağlantı oluşturmanın terminolojik adıdır.</p>

<h3>Direct Exchange</h3>
<p>Mesajların direkt olarak belirli bir kuyruğa gönderilmesini sağlayan exchange'dir.</p>
<p>Mesaj, routing key'e uygun olan hedef kuyruklara gönderilir. Bunun için mesaj gönderilecek kuyruğun adını routing key olarak belirtmek yeterlidir.</p>
<ul>
   <li>Genellikle hata mesajlarının işlendiği senaryolarda kullanılabilir. Şöyle ki; bir sistemde 'dosya yükleme hatası', 'veritabanı bağlantı hatası' vs. gibi farklı türde veya çeşitte hata mesajları olabilir. Bu hata mesajlarının izlenmesi ve gerektiği takdirde çözülmesi gerekebilir. Haliyle her bir hata türü için hususi ayrı bir kuyruk oluşturulabilir ve hata mesajları direkt olarak ilgili kuyruğa gönderilerek işlenebilir. Böylece hata mesajlarının izlenmesi ve çözülmesi için sadece kuyrukların takip edilmesi yeterli olacaktır.</li>
   <li>Başka bir örnek vermemiz gerekirse eğer; E-Ticaret sistemlerinde ki sipariş süreçlerini düşünebiliriz. Biliyorsunuz ki, bir sipariş 'onaylandı', 'iptal edildi' veya 'iade edildi' şeklinde üç farklı durumda gerçekleşmektedir bir sipariş sürecinde farklı durumlara nazaran davranışlar  geliştirmek ve yönetim sergileyebilmek için her bir durum için ayrı kuyruklar oluşturulabilir ve siparişler direkt olarak ilgili kuyruklara gönderilerek işlenebilir. Bu şekilde de her durum için aynı aksiyonları alabilmek ve siparişleri işlemek daha kolay hale gelecektir.</li>
</ul>

<h3>Fanout Exchange</h3>
<p>Mesajların, bu exchange'e bind olmuş olan tüm kuyruklara gönderilmesini sağlar. Publisher mesajların gönderildiği kutruk isimlerini dikkate almaz ve mesajları tüm kuyruklara gönderir.</p>
<ul>
  <li>Bir microservice yaklaşımı benimsenmiş olan mimaride tüm servislere ortak bildirilerde bulunabilmek için Fanout Exchange kullanılabilir. Böylece veri paylaşımı merkezi bir şekilde hızlı ve etkili hale getirilebilir.</li>
</ul>
    
<h3>Topic Exchange</h3>
<p>Routing Key'leri kullanarak mesajları kuyruklara yönlendirmek için kullanılan bir exchange'dir. Bu exchange ile routing key'in bir kısmına, formatına, yapısına ve yapısındaki key'lere göre kuyruklara mesaj gönderilir.</p>
<p>Kuyruklar da, routing key'e göre bu exchange'e abone olabilir ve sadece ilgili routing key'e göre gönderilen mesajları alabilirler.</p>
<ul>
  <li>Log sistemi senaryoları bu exchange için biçilmiş kaftan olacaktır. Kuyruklar, log seviyelerine göre abone olabilir ve sadece routing key'ine uygun ilgili log seviyesine ait mesajları alabilir. Böylece sistem yöneticileri ya da ilgili servisler; belirli bir kategoriye veya key'e göre logları filtreleyebilir ve böylece istekleri hata veya uyarı mesajlarına odaklanabilir, izleyebilir ve istedikleri log mesajlarını gözardı edebilirler.</li>
</ul>

<h3>Header Exchange</h3>
<p>Routing key yerine header'ları kullanarak mesajları kuyruklara yönlendirmek için kullanılan exchange'dir.</p>
    


