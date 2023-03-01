using System.Drawing;

namespace CustomCharacter
{
    public abstract class BodyComponent
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public BodyComponent(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public abstract void Draw(Graphics g, Pen _pen);

        public void UpdatePos(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}