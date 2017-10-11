using Ninject;
using Legato.BL;


namespace Legato.Middleware
{
    public class LegatoMiddlewareDI
    {
        public static void Register(IKernel kernel)
        {
            LegatoBLDI.Register(kernel);
        }
    }
}