namespace Tank.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Body
    {
        private Point position;
        private Point size;
        private Point velocity;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Body(Point position, Point size, Point velocity)
        {
            this.position = position;
            this.size = size;
            this.velocity = velocity;
        }

        /// <summary>
        /// Gets the position
        /// </summary>
        public Point GetPosition()
        {
            return position;
        }

        /// <summary>
        /// Gets a rectangle enclosing this body.
        /// </summary>
        public Rectangle GetRectangle()
        {
            return new Rectangle(position, size);
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        public Point GetSize()
        {
            return size;
        }

        /// <summary>
        /// Gets the velocity
        /// </summary>
        /// <returns>The velocity</returns>
        public Point GetVelocity()
        {
            return velocity;
        }

        /// <summary>
        /// Sets the position to the given value.
        /// </summary>
        public void SetPosition(Point position)
        {
            this.position = position;
        }

        /// <summary>
        /// Sets the size to the given value.
        /// </summary>
        public void SetSize(Point size)
        {
            this.size = size;
        }

        /// <summary>
        /// Sets the velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity</param>
        public void SetVelocity(Point velocity)
        {
            this.velocity = velocity;
        }
    }
}