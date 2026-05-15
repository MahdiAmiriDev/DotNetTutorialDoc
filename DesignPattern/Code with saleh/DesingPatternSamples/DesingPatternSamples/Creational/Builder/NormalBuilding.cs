using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Creational.Builder
{
    internal class NormalBuilding :BuildingBuilder
    {
        private Building building;
        public NormalBuilding()
        {
            building = new Building();
        }

        public void AddDetail()
        {
            building.AddDetail("2Rooms")
                    .AddDetail("bathcRoom")
                    .AddDetail("kitchen");
        }

        public void DoBotonRezi()
        {
            building.DoneBotonRezi("boton rezi is Done  !");
        }

        public void DoHafari()
        {
            building.DoneHafari("hafari is done !");
        }

        public void DoNama()
        {
            building.DoneNama("nama is done !");
        }

        public void DoNazokKari()
        {
            building.DoneNazokKari("nazok kari is done !");
        }

        public Building GetBuilding()
        {
            return building;
        }
    }
}
