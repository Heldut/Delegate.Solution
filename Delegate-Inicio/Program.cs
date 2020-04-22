using System;

namespace Delegate_Inicio
{
    /*         
        Neste exemplo vamos implementar o problema da fabrica.
        Uma fabrica possui 3 maquinas a qual o fornecedor disponibilizou as API paa o acesso ao seu sistema.
        Assim vamos implementar uma funcionalidade para que possamos desligar as maquinas de um só local, isto é,
        não vamos ter que acessar cada uma das maquinas - seu software -  e deslia uma a uma. Vamos implementar um método
        que quando chamado desligará as 3 maquinas.
        Maquina de Dobra, Maquina de Corte e Maquina e Pintura.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Referenciamos as classes e na sequencia chamados os métodos que desligam as maquinas
            MaquinaDobra.MaquinaDobraShutdown();
            MaquinaCorte.MaquinaCorteShutdown();
            MaquinaPintura.MaquinaPinturaShutdown();
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
