using System.Linq;

namespace codewars
{
    public class Beginner___Reduce_but_Grow
    {
        public static int Grow(int[] x) => x.Aggregate((acc, num) => acc * num);
    }
}