using System;
using System.Drawing;

namespace FourthLabwork
{
    internal sealed class GameObject
    {
        public delegate void CollisionEventHandler();

        public event CollisionEventHandler CollisionEnterEvent;

        public static GameObject[] GameObjects;

        public Image Sprite { get; }

        public Rectangle BoxCollider { get; private set; }

        public bool Active { get; set; }

        private Vector2 position;

        public Vector2 Position
        { 
            get { return position; }
            set
            {
                Rectangle newBoxCollider = new Rectangle(value.X, value.Y, this.Sprite.Width, this.Sprite.Height);

                foreach (GameObject gameObject in GameObjects)
                {
                    if (this == gameObject)
                        continue;

                    if (newBoxCollider.IntersectsWith(gameObject.BoxCollider))
                    {
                        this.CollisionEnterEvent?.Invoke();
                        return;
                    }
                }

                position = value;
                this.BoxCollider = newBoxCollider;
            }
        }

        public GameObject(Vector2 position, Image sprite, int boxColliderMultiplierX = 1, int boxColliderMultiplierY = 1)
        {
            sprite = sprite.GetThumbnailImage(sprite.Width * boxColliderMultiplierX, sprite.Height * boxColliderMultiplierY, null, IntPtr.Zero);
            this.BoxCollider = new Rectangle(position.X, position.Y, sprite.Width, sprite.Height);
            this.position = position; 
            this.Sprite = sprite;
            this.Active = true;
        }
    }

    internal struct Vector2
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static Vector2 Up { get => new Vector2(0, -1); }

        public static Vector2 Down { get => new Vector2(0, 1); }

        public static Vector2 Right { get => new Vector2(1, 0); }

        public static Vector2 Left { get => new Vector2(-1, 0); }

        public static Vector2 Zero { get => new Vector2(0, 0); }

        public Vector2(int x, int y)
        {
            this.X = x; 
            this.Y = y;  
        }

        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X, a.Y + b.Y);

        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);

        public static Vector2 operator *(Vector2 a, int value) => new Vector2(a.X * value, a.Y * value);

        public static bool operator !=(Vector2 a, Vector2 b) => a.X != b.X || a.Y != b.Y;

        public static bool operator ==(Vector2 a, Vector2 b) => a.X == b.X && a.Y == b.Y;
    }
}
