using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Builder
{
    internal class Building
    {
        private string hafari;
        private string botonRezi;
        private string nama;
        private string nazokKari;
        private List<string> details = new List<string>();


        public void DoneHafari(string work)
        {
            hafari = work;
        }


        public void DoneBotonRezi(string work)
        {
            botonRezi = work;
        }

        public void DoneNama(string work)
        {
            nama = work;
        }


        public void DoneNazokKari(string work)
        {
            nazokKari = work;
        }

        public Building AddDetail(string detail)
        {
            details.Add(detail);
            return this;
        }

        public void PrintReport()
        {
            var report = hafari + "\n" + botonRezi + "\n" + nama + "\n" + nazokKari + "\n" + string.Join("\n", details);

            Console.WriteLine(report);

        }

    }
}
