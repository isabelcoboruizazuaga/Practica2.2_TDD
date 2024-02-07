namespace Personajes
{
    public class Personaje1
    {
        public int saltar(int altura)
        {
            if (altura == 0)
            {
                return 0;
            }
            else if (altura < 5)
            {
                return 1;
            }
            else if (altura >= 5 && altura <= 10)
            {
                return 2;
            }
            return -1;
        }
    }
}

