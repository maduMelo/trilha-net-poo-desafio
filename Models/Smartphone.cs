namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // ✅ Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo, _imei;
        private int _memoria;

        // Não podem ser alterados depois do objeto ser criado, só podem ser lidos
        public int Memoria { get => _memoria; }
        public string Imei { get => _imei; }
        public string Modelo { get => _modelo; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // ✅ Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}