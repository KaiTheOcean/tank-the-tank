using Tank.Game.Casting;

namespace Tank.Game.Services
{
    public interface AudioServices
    {
        /// <summary>
        /// Initializes the audio device 
        /// </summary>
        void Initialize();

        /// <summary>
        /// Loads all the sound files in the given directory 
        /// </summary>
        /// <param name="directory">The given directory.</param>
        void LoadSounds(string directory);

        /// <summary>
        /// Plays the given sound.
        /// </summary>
        /// <param name="directory">The given directory.</param>
        void PlaySound(Sound sound);

        /// <summary>
        /// Release the audio device 
        /// </summary>
        void Release();

        /// <summary>
        /// Unloads the cached sounds
        /// </summary>
        void UnloadSounds();
    }
}