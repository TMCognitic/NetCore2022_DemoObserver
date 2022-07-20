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

            coca.Attach(amory);

            cecemel.Attach(amory);
            cecemel.Attach(olivier);

            //coca.Price = .80;

            cecemel.Price = 1.20;

            cecemel.Detach(amory);

            cecemel.Price = 1;
        }
    }
}