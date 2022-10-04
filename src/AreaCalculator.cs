namespace Assignment1
{
    public class AreaCalculator
    {
        public double Area(int r)
        {
            double x;
            if (r != 0)
            {
                x = Convert.ToDouble(r);
            }
            else
            {
                return 0;
            }
            double triangle_area = (2 * x * x) / 2;

            double quarter = (x * x) - (0.25 * Math.PI * (x * x));
            double sector = ((x * x) / 2) * (Math.PI - 2 * Math.Atan(x / (2 * x)));
            double isosceles = (x * x) * Math.Sin(Math.Atan(x / (2 * x))) * Math.Cos(Math.Atan(x / (2 * x)));

            return Math.Round(triangle_area - quarter - (sector - isosceles), 3);
        }
    }
}
