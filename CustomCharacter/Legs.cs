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
        private float angleL = 45.0f;
        private float angleR = 45.0f;
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
                    
                    center = new PointF(X + 15, Y + Height / 2);
                    
                    rotate.RotateAt(angleL, center);
                    
                    g.Transform = rotate;
                    
                    g.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, 200, 80);
                    
                    g.EndContainer(container);
                }
            }
        }
    }
}