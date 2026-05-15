using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Builder
{
    internal class BuildingDirector
    {
        private BuildingBuilder _builder;

        public BuildingDirector(BuildingBuilder builder)
        {
            _builder = builder;
        }

        public Building GetBuilding()
        {
            _builder.DoHafari();
            _builder.DoBotonRezi();
            _builder.DoNama();
            _builder.DoNazokKari();
            _builder.AddDetail();

            return _builder.GetBuilding();
        }
    }
}
