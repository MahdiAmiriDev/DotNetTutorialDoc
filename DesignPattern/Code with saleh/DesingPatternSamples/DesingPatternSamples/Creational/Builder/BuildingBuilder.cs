using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Builder
{
    internal interface BuildingBuilder
    {
        void DoHafari();

        void DoBotonRezi();

        void DoNama();

        void DoNazokKari();

        void AddDetail();

        Building GetBuilding();
    }
}
