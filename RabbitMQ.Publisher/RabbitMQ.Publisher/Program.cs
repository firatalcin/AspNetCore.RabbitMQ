using RabbitMQ.Client;

// Bağlantı Oluşturma (CloudAMQP üzerinden bağlantı)
ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://tjoxyejw:aUyOaBIKUE6cdOvfFJvQhkIS16icNkmE@woodpecker.rmq.cloudamqp.com/tjoxyejw");

//Bağlantıyı Aktifleştirme ve Kanal Açma
using IConnection connection = factory.CreateConnection();
