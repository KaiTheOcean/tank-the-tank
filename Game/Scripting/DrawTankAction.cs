using Tank.Game.Casting;
using Tank.Game.Services;


namespace Tank.Game.Scripting
{
    public class DrawTankAction : Action
    {
        private VideoService videoService;
        
        public DrawTankAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket tank = (Tank)cast.GetFirstActor(Constants.TANK_GROUP);
            Body body = tank.GetBody();

            if (tank.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Animation animation = racket.GetAnimation();
            Image image = animation.NextImage();
            Point position = body.GetPosition();
            videoService.DrawImage(image, position);
        }
    }
}