public class Program{

    static void Main(string[] args) {

        Console.WriteLine("Introduce el PAT: ");
        string personalaccesstoken = Console.ReadLine();
        Console.WriteLine(string.Format("PAT: {0}", personalaccesstoken));
        string result = Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(
                        string.Format("{0}:{1}", "", personalaccesstoken)));
        Console.WriteLine(string.Format("Resultado: {0}", result));
        Console.ReadLine();
    }

}


