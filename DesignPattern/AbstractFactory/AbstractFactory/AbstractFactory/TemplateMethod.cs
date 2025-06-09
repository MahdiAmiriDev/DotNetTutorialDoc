using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Document
    {
        private string _path;

        //نکته تعریف کردن step ها مهم است
        //و آن های که مشترک است را یک حا تعریف می کنیم و قسمتی که 
        //می تواند بسته به نیاز ما متفاوت باشند را
        //پیاده سازی آن را به سایرین می سپاریم
        public void ProcessFile(string path)
        {
            this._path = path;
            Open();
            Read();
            ProcessContent();
            Save();
        }

        private void Save()
        {
            Console.WriteLine("saving file in {0}", _path);
        }

        private void Read()
        {
            Console.WriteLine("read file from {0}", _path);
        }

        private void Open()
        {
            Console.WriteLine("opening file from {0}", _path);
        }

        protected abstract void ProcessContent();

    }


    class InvoiceProcessor : Document
    {
        protected override void ProcessContent()
        {
            Console.WriteLine("Processing invoice to be generate");
        }
    }

    class PdfReportProcessor : Document
    {
        protected override void ProcessContent()
        {
            Console.WriteLine("Processing PDF to be generate");
        }
    }
}
