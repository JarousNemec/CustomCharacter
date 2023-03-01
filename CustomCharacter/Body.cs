using System.Drawing;

namespace CustomCharacter
{
    public class Body : BodyComponent
    {
        public Body(float x, float y, float width, float height) : base(x, y, width, height)
        {
        }

        public override void Draw(Graphics g, Pen _pen)
        {
            if (Width < 25)
            {
                g.DrawLine(new Pen(_pen.Color, Width), X, Y, X, Y+Height);
            }
            else
            {
                g.DrawEllipse(_pen, X-Width/2, Y, Width, Height);
            }
        }
    }
}