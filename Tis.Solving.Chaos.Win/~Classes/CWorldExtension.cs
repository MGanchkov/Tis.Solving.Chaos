using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tis.Solving.Chaos
{
    public static class CWorldExtension
    {
        public static Pen Back { get; set; } = Pens.Black;

        public static PointF LocationDraw(this CWorld THIS, SizeF size)
        {
            float sW = (float)((size.Width - 10) / THIS.Size.Width);
            float sH = (float)((size.Height - 10) / THIS.Size.Height);

            if (sW < sH)
                sH = sW;
            else
                sW = sH;

            if (sW == 0) sW = 1;
            if (sH == 0) sH = 1;

            float dW = (float)(size.Width - THIS.Size.Width * sW) * 0.5f;
            float dH = (float)(size.Height - THIS.Size.Height * sH) * 0.5f;

            return new PointF(dW, dH);
        }
        public static RectangleF RectangleDraw(this CWorld THIS, RectangleF rect)
        {
            float sW = (float)((rect.Width - 10) / THIS.Size.Width);
            float sH = (float)((rect.Height - 10) / THIS.Size.Height);

            if (sW < sH)
                sH = sW;
            else
                sW = sH;

            if (sW == 0) sW = 1;
            if (sH == 0) sH = 1;

            float dW = (float)(rect.Width - THIS.Size.Width * sW) * 0.5f;
            float dH = (float)(rect.Height - THIS.Size.Height * sH) * 0.5f;

            return new RectangleF(dW, dH, (float)THIS.Size.Width * sW, (float)THIS.Size.Height * sH);
        }

        public static void Draw(this CWorld THIS, Graphics GL)
        {
            RectangleF rect = GL.ClipBounds;

            float sW = (float)((rect.Width - 10) / THIS.Size.Width);
            float sH = (float)((rect.Height - 10) / THIS.Size.Height);

            if (sW < sH)
                sH = sW;
            else
                sW = sH;

            if (sW == 0) sW = 1;
            if (sH == 0) sH = 1;

            float dW = (float)(rect.Width - THIS.Size.Width * sW) * 0.5f;
            float dH = (float)(rect.Height - THIS.Size.Height * sH) * 0.5f;

            GL.TranslateTransform(dW, dH);
            GL.ScaleTransform(sW, sH);

            foreach (CBody body in THIS.Bodies)
                if (body.IsEnable)
                    body.Draw(GL);

            GL.DrawRectangle(Back, 0, 0, (float)THIS.Size.Width, (float)THIS.Size.Height);
        }
    }
}
