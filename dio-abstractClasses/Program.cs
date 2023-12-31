using DesafioDio.Entities;

var fluxo = true;
while (fluxo)
{
    System.Console.WriteLine("---------------------------------");
    System.Console.WriteLine("Fazer ligação Nokia = 1");
    System.Console.WriteLine("Fazer receber ligação Nokia = 2");
    System.Console.WriteLine("Fazer ligação Iphone = 3");
    System.Console.WriteLine("Fazer receber ligação Iphone = 4");
    System.Console.WriteLine("Instalar aplicativo Nokia = 5");
    System.Console.WriteLine("Instalar aplicativo Iphone = 6");
    System.Console.WriteLine("Terminar fluxo? = 7");
    System.Console.WriteLine("---------------------------------");

    var inicio = Console.ReadLine();
    if (string.IsNullOrEmpty(inicio))
        break;

    var escolha = int.Parse(inicio);
    if (escolha == 7 || escolha > 7)
        break;

    Smartphone nokia = new Nokia("nokia-1", "nova geracao", "12345", 8);
    Smartphone iphone = new Iphone("iphone-1", "nova geracao", "12345", 16);

    switch (escolha)
    {
        case 1:
            nokia.Ligar();
            break;

        case 2:
            nokia.ReceberLigacao();
            break;

        case 3:
            iphone.Ligar();
            break;

        case 4:
            iphone.ReceberLigacao();
            break;

        case 5:
            System.Console.WriteLine("Qual aplicativo quer instalar?");
            var app = Console.ReadLine();
            if (String.IsNullOrEmpty(app))
            {
                System.Console.WriteLine("Valor invalido");
            }
            else
            {
                nokia.InstalarAplicativo(app);
            }
            break;

        case 6:
            System.Console.WriteLine("Qual aplicativo quer instalar?");
            var app2 = Console.ReadLine();
            if (String.IsNullOrEmpty(app2))
            {
                System.Console.WriteLine("Valor invalido");
            }
            else
            {
                iphone.InstalarAplicativo(app2);
            }
            break;

        default:
            break;
    }
}