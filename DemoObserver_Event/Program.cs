namespace DemoObserver_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product coca = new Product("Coca 33cl");
            Product cecemel = new Product("Cecemel");

            Customer olivier = new Customer("Olivier");
            Customer amory = new Customer("Amory");

            coca.Handler += amory.Annonce;

            cecemel.Handler += amory.Annonce;
            cecemel.Handler += olivier.Annonce;

            //coca.Price = .80;

            cecemel.Price = 1.20;

            cecemel.Handler -= amory.Annonce;

            cecemel.Price = 1;
        }
    }
}