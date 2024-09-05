using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Single_Responsibility_Principle__SRP_
{
    public class DocumentContent
    {
        public string Content { get; set; }
    }
    public interface IDocumentFormatter
    {
        string Format(string content);
    }
    public class DocumentFormatter : IDocumentFormatter
    {
        public string Format(string content)
        {
            return "Formatted : " + content;
        }
    }
    public interface IDocumnentPrinter
    {
        void Print(string content);
    }
    public class DocumentPrinter : IDocumnentPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }


}
