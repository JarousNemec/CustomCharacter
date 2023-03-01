using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomCharacter
{
    public class Legs : Extremities
    {
        public Legs(float x, float y, float width, float height, float lineWidth) : base(x, y, width, height, lineWidth)
        {
        }

        private PointF center;
        private float angleL = 180;
        private float angleR = 0;
        public override void Draw(Graphics g, Pen _pen)
        {
            if (LineWidth < 25)
            {
                Point[] points =
                {
                    new Point((int)(X - Width / 2), (int)(Y + Height)), new Point((int)X, (int)Y),
                    new Point((int)(X + Width / 2), (int)(Y + Height))
                };
                g.DrawLines(new Pen(_pen.Color, LineWidth), points);
            }
            else
            {
                using (Matrix rotate = new Matrix())
                {
                    GraphicsContainer container = g.BeginContainer();
                    
                    center = new PointF(X, Y);
                    rotate.RotateAt(angleL, center);
                    g.DrawEllipse(new Pen(Color.Blue, 3), X, Y, 250, 40);
                    g.EndContainer(container);
                    container = g.BeginContainer();
                    
                    rotate.RotateAt(angleR, center);
                    g.Transform = rotate;
                    
                    g.DrawEllipse(new Pen(Color.Blue, 3), X, Y, 250, 40);
                    
                    g.EndContainer(container);
                }
            }
        }
    }
}