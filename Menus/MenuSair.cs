using ScreenSoundDB.Banco;
using ScreenSoundDB.Modelos;

namespace ScreenSoundDB.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
