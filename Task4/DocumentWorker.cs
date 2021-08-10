using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class DocumentWorker
    {
        public void OpenDocument() 
        {
            Console.WriteLine("Default Документ открыт");
        }
        public virtual void EditDocument() 
        {
            Console.WriteLine("Default Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("Default Сохранение документа доступно в версии Про");
        }
    }
}
