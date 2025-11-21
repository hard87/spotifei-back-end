using Microsoft.AspNetCore.Mvc; //Possivelmente instalar depois o pacote
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

var musicaGroup = app.MapGroup("/musicas");
var playlistGroup = app.MapGroup("/playlists");
// var usuarioGroup = app.MapGroup("/usuarios");
var ouvinteGroup = app.MapGroup("/ouvintes");
var artistaGroup = app.MapGroup("/artistas");

musicaGroup.MapGet("", () => 
{
    List<Musica> musicas = new MusicaController().ListarTodos();
    return Results.Ok(musicas);
});
musicaGroup.MapPost("", ([FromBody]Musica musica) => 
{
    new MusicaController().Adicionar(musica);
    return Results.Ok("musica adicionada com sucesso");
});
musicaGroup.MapPut("", ([FromBody]Musica musica) => 
{
    new MusicaController().Editar(musica);
    return Results.Ok("musica alterada com sucesso");
});
musicaGroup.MapDelete("", ([FromBody]Musica musica) => 
{
    new MusicaController().Remover(musica);
    return Results.Ok("musica deletada com sucesso");
});

playlistGroup.MapGet("", () => 
{
    List<Playlist> playlists = new PlaylistController().ListarTodos();
    return Results.Ok(playlists);
});
playlistGroup.MapPost("", ([FromBody] Playlist playlist) => 
{
    new PlaylistController().Adicionar(playlist);
    return Results.Ok("playlist adicionada com sucesso");
});
playlistGroup.MapPut("", ([FromBody] Playlist playlist) => 
{
    new PlaylistController().Editar(playlist);
    return Results.Ok("playlist alterada com sucesso");
});
playlistGroup.MapDelete("", ([FromBody] Playlist playlist) => 
{
    new PlaylistController().Remover(playlist);
    return Results.Ok("playlist removida com sucesso");
});

ouvinteGroup.MapGet("", () => 
{
    List<Ouvinte> ouvintes = new OuvinteController().ListarTodos();
    return Results.Ok(ouvintes);
});
ouvinteGroup.MapPost("", ([FromBody] Ouvinte ouvinte) => 
{
    new OuvinteController().Adicionar(ouvinte);
    return Results.Ok("ouvinte adicionada com sucesso");
});
ouvinteGroup.MapPut("", ([FromBody] Ouvinte ouvinte) => 
{
    new OuvinteController().Editar(ouvinte);
    return Results.Ok("ouvinte editado com sucesso");
});
ouvinteGroup.MapDelete("", ([FromBody] Ouvinte ouvinte) => 
{
    new OuvinteController().Remover(ouvinte);
    return Results.Ok("ouvinte removido com sucesso");
});

artistaGroup.MapGet("", () => 
{
    List<Artista> artistas = new ArtistaController().ListarTodos();
    return Results.Ok(artistas);
});
artistaGroup.MapPost("", ([FromBody] Artista artista) => 
{
    new ArtistaController().Adicionar(artista);
    return Results.Ok("artista adicionado com sucesso");
});
artistaGroup.MapPut("", ([FromBody] Artista artista) => 
{
    new ArtistaController().Editar(artista);
    return Results.Ok("artista alterado com sucesso");
});
artistaGroup.MapDelete("", ([FromBody] Artista artista) => 
{
    new ArtistaController().Remover(artista);
    return Results.Ok("artista removido com sucesso");
});


// usuarioGroup.MapGet("", () => 
// {});
// usuarioGroup.MapPost("", ([FromBody]) => 
// {});
// usuarioGroup.MapPut("", ([FromBody]) => 
// {});
// usuarioGroup.MapDelete("", ([FromBody]) => 
// {});

//var builder = WebApplication.CreateBuilder(args);


//var app = builder.Build();

app.UseCors("AllowAll");


app.MapGet("/", () => "API Spotifei rodando!");
app.Run();
