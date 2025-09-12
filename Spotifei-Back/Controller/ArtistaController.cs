class ArtistaController
{
    public void Cadastrar(Artista artista,string nome)
    {
        ArtistaDAO artistaDAO = new ArtistaDAO();
        artista.Nome = nome;
        artistaDAO.Cadastrar(artista)
    }
}