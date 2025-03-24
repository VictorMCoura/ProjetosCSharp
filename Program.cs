using ListaDupla;

internal class Program 
{

    static void Main(string[] args)
    {
        ListaDuplamente l = new ListaDuplamente();
        l.inserirFim("a");
        l.inserirFim("b");
        l.inserirFim("c");
        l.inserirFim("d");
        l.imprimir();
        l.imprimirRev();
    }
}

