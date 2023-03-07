using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomCharacter
{
    public class Legs : Extremities
    {
        public Legs(float x, float y, float width, float height, float lineWidth) : base(x, y, width, height, lineWidth)
        {
        }

        private float LRotation = 45;
        private float RRotation = 135;

        public override void Draw(Graphics g, Pen _pen)
        {
            if (LineWidth < 25)
            {
                base.Draw(g, _pen);
            }
            else
            {
                float LGama = Sawfunc(360, LRotation, 90);
                float RGama = Sawfunc(360, RRotation, 90);
                float distance = LineWidth / 2;

                PointF ROffset = new PointF((float)(Math.Cos(RGama*(Math.PI/180))) * distance, (float)(Math.Sin(RGama*(Math.PI/180))) * distance);
                PointF LOffset = new PointF((float)(Math.Cos(LGama*(Math.PI/180))) * distance, (float)(Math.Sin(LGama*(Math.PI/180))) * distance);

                PointF centerR = new PointF(X + ROffset.X, Y - ROffset.Y);
                PointF centerL = new PointF(X + LOffset.X, Y - LOffset.Y);
                using (Matrix rotate = new Matrix())
                {
                    GraphicsContainer container = g.BeginContainer();

                    rotate.RotateAt(LRotation, centerL);
                    g.Transform = rotate;
                    g.DrawEllipse(new Pen(Color.Black, 3), centerL.X, centerL.Y, 100, LineWidth);

                    rotate.RotateAt(360 - LRotation, centerL);
                    g.Transform = rotate;

                    rotate.RotateAt(RRotation, centerR);
                    g.Transform = rotate;
                    g.DrawEllipse(new Pen(Color.Black, 3), centerR.X, centerR.Y, 100, LineWidth);

                    g.EndContainer(container);
                }
            }
        }

        private float Sawfunc(float max, float x, float xmoved)
        {
            x += max - xmoved;
            float f = (max - (x - (int)(x / max) * max));
            return f;
        }
    }
}