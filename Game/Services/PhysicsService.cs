using Tank.Game.Casting;

namespace Tank.Game.Services
{
    public interface PhysicsService
    {
        /// <summary>
        /// Whether or not two parts have collided.
        /// </summary>
        /// <param name="subject1">The first part.</param>
        /// <param name="agent2">Tje second part. </param>
        /// <return></returns>
        bool HasCollided(Body subject1, Body subject2);
    }
}