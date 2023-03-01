using System.Drawing;

namespace CustomCharacter
{
    public class Extremities : BodyComponent
    {
        public float LineWidth { get; set; }
        public Extremities(float x, float y, float width, float height, float lineWidth) : base(x, y, width, height)
        {
            LineWidth = lineWidth;
        }

        public override void Draw(Graphics g, Pen _pen)
        {
            Point[] points =
            {
                new Point((int)(X - Width / 2), (int)(Y + Height)), new Point((int)X, (int)Y),
                new Point((int)(X + Width / 2), (int)(Y + Height))
            };
            g.DrawLines(new Pen(_pen.Color, LineWidth), points);
        }
    }
}