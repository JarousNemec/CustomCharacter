using System.Drawing;

namespace CustomCharacter
{
    public class Head : BodyComponent
    {
        public Head(float x, float y, float width, float height) : base(x, y, width, height)
        {
        }

        public override void Draw(Graphics g, Pen _pen)
        {
            g.DrawEllipse(_pen,X,Y, Width, Height);
        }

        public Point GetNeckPosition()
        {
            return new Point((int)(X+Width/2), (int)(Y+Height));
        }
    }
}