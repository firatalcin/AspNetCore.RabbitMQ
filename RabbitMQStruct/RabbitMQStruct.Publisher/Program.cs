using RabbitMQ.Client;
using System.Text;

//Publisher

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://hwwqiecq:nCfokA2j9gWejgJgrPKct-CLJTKGiJZ3@fish.rmq.cloudamqp.com/hwwqiecq"); //Bağlantı Oluşturma

//Bağlantıyı aktifleştirme ve Kanal Açma
var connection = await factory.CreateConnectionAsync();
var channel = await connection.CreateChannelAsync();

//Queue Oluşturma
await channel.QueueDeclareAsync(queue: "example-queue", exclusive: false);

//Queue'e Mesaj Gönderme
//RabbitMQ kuyruğa atacağı mesajları byte türünden kabul etmektedir.
var message = Encoding.UTF8.GetBytes("Merhaba");
await channel.BasicPublishAsync(exchange: "", routingKey: "example-queue", body: message);

Console.Read();