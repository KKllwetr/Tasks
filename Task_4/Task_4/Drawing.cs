using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_4
{
    public class Drawing
    {
        static float ground = 0;
        public static void Draw(Bitmap bitmap, IList<Building> buildings)
        {
            ground = bitmap.Height / 1.4f;
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.SaddleBrown, 0, ground, bitmap.Width, bitmap.Height);
            g.FillEllipse(Brushes.Yellow, bitmap.Width - 100, 30, 80, 80);
            DrawHouse(bitmap, buildings);

        }
        private static void DrawHouse(Bitmap bitmap, IList<Building> buildings)
        {
            Graphics g = Graphics.FromImage(bitmap);
            int x = bitmap.Width / 5; // 5 участков
            for (int i = 0; i < buildings.Count; i++)
            {
                Building home = buildings[i];
                Brush brush = new SolidBrush(Color.Red);
                switch (home.Colours)
                {
                    case Colour.Red:
                        brush = new SolidBrush(Color.Red);
                        break;
                    case Colour.Blue:
                        brush = new SolidBrush(Color.Blue);
                        break;
                    case Colour.Gray:
                        brush = new SolidBrush(Color.Gray);
                        break;
                    case Colour.Green:
                        brush = new SolidBrush(Color.Green);
                        break;
                    default:
                        brush = new SolidBrush(Color.Blue);
                        break;
                }
                double partofhome = 90 / home.Floor;
                for (int j = 1; j <= home.Floor; j++)
                {
                    if (home.Progress > partofhome * j)
                    {
                        Pen p = new Pen(Color.Black, 2);
                        g.FillRectangle(brush, x * (buildings[i].Number - 1) + 20, (ground - 60*j), 70, 60);
                        g.DrawRectangle(p, x * (buildings[i].Number - 1) + 20, (ground - 60*j), 70, 60);
                        g.FillEllipse(Brushes.LightBlue, x * (buildings[i].Number - 1) + 40, (ground - 60 * j) + 20, 30, 30);
                        g.DrawLine(p, x * (buildings[i].Number - 1) + 40, (ground - 60 * j) + 35, x * (buildings[i].Number - 1) + 70, (ground - 60 * j) + 35);
                        g.DrawLine(p, x * (buildings[i].Number - 1) + 55, (ground - 60 * j) + 35, x * (buildings[i].Number - 1) + 55, (ground - 60 * j) + 50);
                    }
                    if (home.Progress > 95 && j == home.Floor && home.Roof)
                    {
                        Point[] p = new Point[] {new Point(x * (buildings[i].Number - 1) + 20, (int)(ground - 60 * j)),
                            new Point(x * (buildings[i].Number - 1) + 90, (int)(ground - 60 * j)),
                            new Point(x * (buildings[i].Number - 1) + 55, (int)(ground - 60 * j - 20))
                        };
                        g.FillPolygon(Brushes.RosyBrown, p);
                    }
                }
            }
        }
    }
}
