using RabbitMQ.Client;
using System.Text;

// Bağlantı Oluşturma (CloudAMQP üzerinden bağlantı)
ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://tjoxyejw:aUyOaBIKUE6cdOvfFJvQhkIS16icNkmE@woodpecker.rmq.cloudamqp.com/tjoxyejw");

//Bağlantıyı Aktifleştirme ve Kanal Açma
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

//Queue Oluşturma
channel.QueueDeclare(queue:"example-queue",exclusive: false);

//Queue'ya Mesaj Gönderme
//RabbitMQ kuyruğa atacağı mesajları byte türünden kabul etmektedir. Byte'a dönüşüm gerekir.
byte[] message = Encoding.UTF8.GetBytes("Merhaba");
channel.BasicPublish(exchange: "", routingKey: "example-queue", body: message);

Console.Read();
