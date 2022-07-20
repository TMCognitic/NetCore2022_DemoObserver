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

            coca.Attach(amory.Annonce);

            cecemel.Attach(amory.Annonce);
            cecemel.Attach(olivier.Annonce);

            //coca.Price = .80;

            cecemel.Price = 1.20;

            cecemel.Detach(amory.Annonce);

            cecemel.Price = 1;
        }
    }
}