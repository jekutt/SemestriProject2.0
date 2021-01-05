using System.Collections.Generic;
using System.Linq;
using SemestriProject.Data.SeaFreight;

namespace SemestriProject.Infra.SeaFreight
{
    public static class SeaFreightDbInitializer
    {
        internal static AfricaData madagaskar = new AfricaData
        {
            Id = "LV",
            Direction = "Riga",
            OrderTime = "kek",
            LiftingCapacity = "",
            ContainerType = "kek",
            TravelTime = ""
        };

        internal static List<AfricaData> africa => new List<AfricaData>
        {
            madagaskar
        };

        public static void Initialize(SeaFreightDbContext db)
        {
            initializeBaltic(db);
        }

        private static void initializeBaltic(SeaFreightDbContext db)
        {
            if (db.Africa.Count() != 0) return;
            db.Africa.AddRange(africa);
            db.SaveChanges();
        }
    }
}
