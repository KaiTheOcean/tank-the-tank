using System;
using Tank.Game.Directing;
using Tank.Game.Services;

namespace Tank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(SceneManager.VideoService);
            director.Startgame();
        }
    }
}