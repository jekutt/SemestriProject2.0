using SemestriProject.Data.AirFreight;
using System.Collections.Generic;
using System.Linq;

namespace SemestriProject.Infra.AirFreight
{
    public static class AirFreightDbInitializer
    {
        internal static AmericaData newYork = new AmericaData
        {
            Id = "NY",
            Direction = "New York",
            OrderTime = "kek",
            TypeOfCargo = "New York",
            AirplaneType = "kek",
            TravelTime = ""
        };

        internal static List<AmericaData> america => new List<AmericaData>
        {
            newYork
        };

        public static void Initialize(AirFreightDbContext db)
        {
            initializeAmerica(db);
        }

        private static void initializeAmerica(AirFreightDbContext db)
        {
            if (db.America.Count() != 0) return;
            db.America.AddRange(america);
            db.SaveChanges();
        }
    }
}
