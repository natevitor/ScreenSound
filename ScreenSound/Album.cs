class Album {
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome) {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica) {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum() {
        Console.WriteLine($"Lista de musicas do álbum {Nome}:\n");
        foreach (var musica in musicas) {
            Console.WriteLine($"Musicas: {musica.Nome}:\n");
        }
        Console.WriteLine($"Para ouvir este album inteiro voce precisa de {DuracaoTotal}");
    }
}