using Tank.Game.Casting;
namespace Tank.Game.Scripting
{
    public class MoveBulletlAction : Action
    {
        public MoveBulletAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Bullet Bullet = (Bullet)cast.GetFirstActor(Constants.Bullet_GROUP);
            Body body = bullet.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            position = position.Add(velocity);
            body.SetPosition(position);
        }
    }
}