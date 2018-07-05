using System;
using System.Collections.Generic;
using System.Text;

namespace IPolice.Core.Entities
{
    public enum State{
        Abia, Adamawa, AkwaIbom, Anambra, Bauchi, Bayelsa, Benue, Borno, CrossRiver, Delta, Ebonyi, Enugu, Edo, Ekiti, Gombe, Imo, Jigawa, Kaduna,
        Kano, Katsina, Kebbi, Kogi, Kwara, Lagos, Nasawara, Niger, Ogun, Ondo, Osun, Oyo, Plateau, Rivers, Sokoto, Taraba, Yobe, Zamfara, FCT
    }

    public class Location
    {
        public Guid ID { get; set; }
        public State State { get; set; }

        public ICollection<PoliceStation> PoliceStations { get; set; }
        public ICollection<FireServiceStation> FireServiceStations { get; set; }
        public ICollection<Hospital> Hospitals { get; set; }
        public ICollection<CivilDefense> CivilDefenses { get; set; }
        public ICollection<LocalAgency> LocalAgencies { get; set; }
        public ICollection<ArmyBarrack> ArmyBarracks { get; set; }

        public ICollection<Notification> Notifications { get; set; }
    }
}
