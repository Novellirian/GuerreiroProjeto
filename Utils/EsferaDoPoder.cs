// /Utils/EsferaDePoder.cs
using JogoGuerreiros.Decorators;

namespace JogoGuerreiros.Utils
{
    public class EsferaDePoder
    {
        public void AumentarReflexo(AnelDecorator guerreiroComAnel)
        {
            guerreiroComAnel.ColetarEsfera();
        }
    }
}
