﻿Banda queen = new Banda("Queen");

Album albumDoQueen = new Album ("A night at the opera");

Musica musica1 = new Musica (queen, "Love of my live") 
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Boheim Rhapsody") {
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica (musica1);
albumDoQueen.AdicionarMusica (musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();








/* Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);


Musica musica2 = new Musica();
musica2.Nome = "Vetigo";
musica2.Artista = "U2";
musica2.Durcao = 367;
musica2.Disponivel = false; 

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();








