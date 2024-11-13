//Bağlantı Oluşturma

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

//Consumer

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://hwwqiecq:nCfokA2j9gWejgJgrPKct-CLJTKGiJZ3@fish.rmq.cloudamqp.com/hwwqiecq");

//Bağlantı Aktifleştirme ve Kanal Açma

using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

//Queue Oluşturma

await channel.QueueDeclareAsync(queue: "example-queue", exclusive: false);

//Queue'dan Mesaj Okuma

AsyncEventingBasicConsumer consumer = new(channel);

await channel.BasicConsumeAsync(queue: "example-queue", autoAck: false, consumer: consumer);
consumer.ReceivedAsync += async (sender, e) =>
{
    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
};

// Mesajları tüketmeye başlamak için BasicConsume metodunu kullanıyoruz

Console.Read();
