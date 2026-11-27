namespace Pr31_ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubject p = new Academy("UCL", "Seebladsgade");

            IObserver s1 = new Student(p, "Jens");
            IObserver s2 = new Student(p, "Niels");
            IObserver s3 = new Student(p, "Susan");

            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            p.Message = "Så er der julefrokost!";

            p.Detach(s2);

            p.Message = "Så er der fredagsbar!";
        }

    }
}
