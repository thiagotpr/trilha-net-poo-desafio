using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Nokia nokia = new Nokia("123456789", "Nokia 8", "IMEI123", 64);
        Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.InstalarAplicativo("Telegram");
    }
}