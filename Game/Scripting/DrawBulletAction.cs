using Tank.Game.Casting;
using Tank.Game.Services;


namespace Tank.Game.Scripting
{
    public class DrawBulletAction : Action
    {
        private VideoService videoService;
        
        public DrawBulletAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Bullet bullet = (Bullet)cast.GetFirstActor(Constants.BULLET_GROUP);
            Body body = ball.GetBody();

            if (bullet.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Image image = ball.GetImage();
            Point position = body.GetPosition();
            videoService.DrawImage(image, position);
        }
    }
}