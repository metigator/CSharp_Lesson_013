namespace MulticastDelegate
{
      public delegate void RecDelegate(decimal width, decimal height);
        internal class Program
        {
            static void Main(string[] args)
            {

                var helper = new RectangleHelper();
                helper.GetArea(10, 10);
                helper.GetPerimeter(10, 10);

                // After Delegate

                Console.WriteLine("After Delegate");
                RecDelegate rect;
                rect = helper.GetPerimeter;
                rect += helper.GetArea;
                rect(10, 10);

                rect -= helper.GetArea;  

                Console.WriteLine("After unsbuscribing rect.Area");

                rect(10, 10);

                Console.ReadKey();
            }
        }


    public class RectangleHelper
    {
        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($" Area = {width} x {height} = {result}");
        }

        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($" Perimeter = 2 x ({width} + {height}) = {result}");
        }
    }
}