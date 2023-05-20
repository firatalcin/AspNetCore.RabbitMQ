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

