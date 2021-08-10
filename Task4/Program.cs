using System;

namespace Task4
{
    class Program
    {
        public static string versionKey;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter version (pro, exp, or default): ");
            versionKey = Console.ReadLine();
            switch (versionKey) 
            {
                case "pro":
                    ProDocumentWorker pro = new ProDocumentWorker();
                    ((DocumentWorker)pro).OpenDocument();
                    ((DocumentWorker)pro).EditDocument();
                    ((DocumentWorker)pro).SaveDocument();

                    break;
                case "exp":
                    ExpertDocumentWorker exp = new ExpertDocumentWorker();
                    ((DocumentWorker)exp).OpenDocument();
                    ((DocumentWorker)exp).EditDocument();
                    ((DocumentWorker)exp).SaveDocument();
                    break;
                default:
                    DocumentWorker doc = new DocumentWorker();
                    doc.OpenDocument();
                    doc.EditDocument();
                    doc.SaveDocument();
                    break;
            }
        }
    }
}
