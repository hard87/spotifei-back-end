static class ReproducaoMusicaView
{
    public static void Exibir()
    {
        if (1 == 1) System.Console.WriteLine("Aqui está a lista de músicas");
        // musicas = new MusicaController().ListarMusicas();
        // if (musicas.Count > 0)
        // {
        //    ListarMusicas(musicas);
        //  }
        else
        {
            System.Console.WriteLine("Nenhuma musica foi postada ...");
            InterfaceInicialView.Exibir();
        }
        System.Console.WriteLine("Digite o Id da música que você quer escutar");
        int escolhaMusicaId = int.Parse(Console.ReadLine());

        
    }

    private static void ListarMusicas(List<Musica> musicas)
    {
        foreach (Musica musica in musicas)
        {
            System.Console.WriteLine(musica.Id + " " + musica.Nome);
        }
    }

    
    
}