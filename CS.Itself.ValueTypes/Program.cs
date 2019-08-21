using System;

namespace CS.Itself.ValueTypes
{
    struct S
    {
        private double X;

        static int Main()
        {
            try
            {
                var a = new S(){X = 0.0};
                var b = new S(){X = -0.0};

                Console.WriteLine(a.X.Equals(b.X)); //True      
                Console.WriteLine(a.Equals(b)); //True
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
            

        }
    }
}
