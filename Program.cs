using DesafioPOO.Models;

Nokia android = new Nokia("919425-55","NokiA15","AAAAAAAAA", 32);
Iphone ios = new Iphone("919233-22", "Iphone30","BBBBBBB", 126);
ios.Ligar();
ios.ReceberLigacao();
ios.InstalarAplicativo("Apple Store: Facebook");
ios.Exibir();
Console.WriteLine("----------------------------------------------------------------------------");
android.Ligar();
android.ReceberLigacao();
android.InstalarAplicativo("Play Strore: Dio");
android.Exibir();


// TODO: Realizar os testes com as classes Nokia e Iphone