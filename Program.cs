using DesafioPOO.Models;

// ✅ Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando Nokia...");
Smartphone nokia = new Nokia(numero: "987824591", modelo: "Nokia 3310", imei: "123456789", memoria: 4);
nokia.Ligar("987654321");
nokia.InstalarAplicativo("Snake");
nokia.ReceberLigacao();
Console.WriteLine("\nInformações do Nokia:\n" +
    $"Número: {nokia.Numero}\n" +
    $"Modelo: {nokia.Modelo}\n" +
    $"IMEI: {nokia.Imei}\n" +
    $"Memória: {nokia.Memoria}GB\n");

Console.WriteLine("--------------------------------");

Console.WriteLine("\nTestando iPhone...");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "103050709", memoria: 128);
iphone.Ligar("987824591");
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
Console.WriteLine("\nInformações do iPhone:\n" +
    $"Número: {iphone.Numero}\n" +
    $"Modelo: {iphone.Modelo}\n" +
    $"IMEI: {iphone.Imei}\n" +
    $"Memória: {iphone.Memoria}GB");