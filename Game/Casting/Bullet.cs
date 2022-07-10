using System;


namespace Tank.Game.Casting
{
    /// <summary>
    /// <para>A bullet for user to pick up.</para>
    /// <para>
    /// The responsibility of Bullet is to select a random position and for user to pick up.
    /// </para>
    /// </summary>
    public class Bullet : Actor
    {
        private int points = 0;

        /// <summary>
        /// Constructs a new instance of a bullet.
        /// </summary>
        public Bullet()
        {
            SetText("*");
            SetColor(Constants.RED); 
            Reset();
        }

        /// <summary>
        /// Selects a random position for the bullet.
        /// </summary>
        public void Reset()
        {
            Random random = new Random();
            points = random.Next(9);
            int x = random.Next(Constants.COLUMNS);
            int y = random.Next(Constants.ROWS);
            Point position = new Point(x, y);
            position = position.Scale(Constants.CELL_SIZE);
            SetPosition(position);
        }
    }
}