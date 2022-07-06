using Tank.Game.Casting;

namespace Tank.Game.Services
{
    public interface MouseService
    {
        ///<summary>
        ///Gets the current mouse cursor coordinates.
        ///</summary>
        ///<returns>The mouse cursor coordinates.</returns>
        Point GetCoordinates();

        ///<summary>
        ///Whether or not the given button is down.
        ///</summary>
        ///<param name="button">The given key.</param>
        bool IsButtonDown(string button);

        ///<summary>
        ///Whether or not the given button has been released.
        ///</summary>
        ///<param name="button">The given key.</param>
        bool IsButtonReleased(string button);

        ///<summary>
        ///Whether or not the given button is up.
        ///</summary>
        ///<param name="button">The given key.</param>
        bool IsButtonUp(string button);
    }
}