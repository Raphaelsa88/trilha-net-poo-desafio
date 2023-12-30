using DesafioPOO.Models;


Iphone phone1 = new Iphone("987654321", "11", "3500000", 128);
phone1.Ligar();
phone1.ReceberLigacao();
phone1.InstalarAplicativo("Whatsapp");

Nokia phone2 = new Nokia("987654322", "N11", "3500001", 2);
phone2.Ligar();
phone2.ReceberLigacao();
phone2.InstalarAplicativo("Jogo da Cobrinha");