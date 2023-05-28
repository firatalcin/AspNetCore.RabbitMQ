using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

//Bağlantı Oluşturma

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://tjoxyejw:aUyOaBIKUE6cdOvfFJvQhkIS16icNkmE@woodpecker.rmq.cloudamqp.com/tjoxyejw");



//Bağlantı Aktifleştirme ve Kanal Açma
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

//Queue Oluşturma
//Consumer'da da kuyruk publisher'daki ile birebir aynı yapılandırmada tanımlandırılmalıdır.
channel.QueueDeclare(queue: "example-queue", exclusive: false);

//Queue'dan Mesaj Oluşturma
EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(queue: "example-queue", false, consumer);
consumer.Received += (sender, e) =>
{
    //Kuyruğa gelen mesajın işlendiği yerdir.
    //e.Body : Kuyruktaki mesajın verisini bütünsel olarak getirecektir.
    //e.Body.Span veya e.Body.ToArray() : Kuyrukdaki mesajın byte verisini getirecektir.
    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
};

Console.ReadLine();