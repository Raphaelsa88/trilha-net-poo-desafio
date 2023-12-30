namespace DesafioPOO.Models
{ public abstract class Smartphone
    {
        #region Properties
        public string Numero { get; set; }
      
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        #endregion
        #region Constructors
        public Smartphone(
            string numero,
            string modelo,
            string imei,
            int memoria)
        {
            Numero = numero;
            
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        #endregion
        #region Methods
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        #endregion
    }

}