using System.Collections.Generic;
using Tank.Game.Casting;
using Tank.Game.Scripting;
using Tank.Game.Services;

namespace Tank.Game.Directing
{
    public class Director : ActionCallBack
    {
        private Cast cast;
        private Script script;
        private SceneManager sceneManager;
        private VideoService videoService;

        public Director(VideoService videoService)
        {
            this.videoService = videoService;
            this.cast = new Cast();
            this.script = new Script();
            this.sceneManager = new SceneManager();
        }

        public bool OnNext(string scene)
        {
            sceneManager.PrepareScene(scene, cast, script);
        }

        public void StartGame()
        {
            OnNext(Constants.NEW_GAME);
            ExecuteActions(Constants.INITIALIZE);
            ExecuteActions(Constants.LOAD);
            while (videoService.IsWindowOpen())
            {
                ExcuteActions(Constants.INPUT);
                ExcuteActions(Constants.UPDATE);
                ExcuteActions(Constants.OUTPUT);
            }
            ExecuteActions(Constants.UNLOAD);
            ExecuteActions(Constants.RELEASE);
        }

        private void ExecuteActions(string group)
        {
            List<Action> actions = script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(cast, script, this);
            }
        }
    }
}