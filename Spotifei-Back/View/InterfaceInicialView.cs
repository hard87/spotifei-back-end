static class InterfaceInicialView
{
    public static void Exibir()
    {
        System.Console.WriteLine("Digite 1 se você for Usuário , 2 se for Artista e 3 para sair");
        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 1)
        {
            System.Console.WriteLine("O que você gostaria de fazer? 1 - Reproduzir uma música, 2 -  Curtir uma música, 3 - Criar uma playlist ou 4 - Adicionar uma música a uma playlist");
            int escolha = int.Parse(Console.ReadLine());
        }

        if (resposta == 2)
        {
            System.Console.WriteLine("O que você gostaria de fazer? 1 - Reproduzir uma música, 2 -  Curtir uma música, 3 - Criar uma playlist ou 4 - Adicionar uma música a uma playlist ou 5 - Entrar no seu estpudio de artista");
            int escolha = int.Parse(Console.ReadLine());

        }
        if (resposta == 3)
            {
                return;
            }
        else
        {
            System.Console.WriteLine("Digite novamente");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
    
   
}