using System;

namespace Delegate_Maquinas
{
    /*
        Vamos uilizar o delegate para implementar o processo da aplicação Delegate-Inicio.
        Temos nossa API representada pelas 3 classes, MaquinaDobra, MaquinaCorte e MaquinaPintura.
        Criamos a classe Controller que irá implementar o delegate. No consrutor inicializamos o 
        delegate com os metodos que quereos implementar.
    */

    class Program
    {

        static void Main(string[] args)
        {
            // Criamos a instancia da classe controler
            Controller cls = new Controller();

            // executamos o método PararMaquinas()
            cls.PararMaquinas();
        }
    }

    public class Controller
    {
        // Criamos o delegate
        delegate void pararMaquina();

        // Instancia do delegate criado acima
        private pararMaquina pararMaquinasProducao;

        public Controller()
        {
            // Aqui no construtor inicializamos o delegate com os tres metodos.
            pararMaquinasProducao += MaquinaDobra.MaquinaDobraShutdown;
            pararMaquinasProducao += MaquinaCorte.MaquinaCorteShutdown;
            pararMaquinasProducao += MaquinaPintura.MaquinaPinturaShutdown;
        }

        // Método que executa o delegate
        public void PararMaquinas()
        {
            pararMaquinasProducao();
        }
    }


    // Imaginemos que as classes abaixo foram referenciados da API fornecida pela empresa fabricante das maquinas
    public static class MaquinaDobra
    {
        public static void MaquinaDobraShutdown()
        {
            Console.WriteLine("Maquina Dobra Desligada");
        }
    }

    public static class MaquinaCorte
    {
        public static void MaquinaCorteShutdown()
        {
            Console.WriteLine("Maquina Corte Desligada");
        }
    }

    public static class MaquinaPintura
    {
        public static void MaquinaPinturaShutdown()
        {
            Console.WriteLine("Maquina Pintura Desligada");
        }
    }
}
