using System;
using System.Collections.Generic;
using System.Data;
using Tank.Game.Casting;
using Tank.Game.Services;

namespace Tank.Game.Scripting
{
    public class CollideTankAction : Action
    {
        private bool isGameOver = false; 
        public CollideTankAction()
        {

        }

        public void Execute(Actor actor, Script script)
        {
            if (isGameOver == false)
            {
                HandleBulletCollision(cast);
                HandleGameover(cast);
            }
        }

        private void HandleBulletCollision(Cast cast)
        {
            Tank tank = (Tank)cast.GetActors("tank1");
            Tank tank = (Tank)cast.GetActors("tank2");
            Bullet bullet = (Bullet)cast.GetActors("bullet1");
            Bullet bullet = (Bullet)cast.GetActors("bullet2");
            if (tank1.GetPosition().Equals(bullet2.GetPosition()))
            {
                isGameOver = true;
            }
            if (tank2.GetPosition().Equals(bullet1.GetPosition()))
            {
                isGameOver = true;
            }
        }

        private boid HandleGameover(Cast cast)
        {
            if (isGameOver == true)
            {
                Tank tank = (Tank)cast.GetActors("tank1");
                Tank tank = (Tank)cast.GetActors("tank2");

                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Activator message = new Activator();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                tank1.SetColor(Constants.WHITE);
                tank2.SetColor(Constants.WHITE);
            }
        }
    }
}