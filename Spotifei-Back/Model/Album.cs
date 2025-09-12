class Album
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataCriacao { get; set; }
    public int NumeroMusicas { get; set; }
    public Artista Artista { get; set; }
    
    public List<Musica> Musicas { get; set; } = new List<Musica>(); 
}