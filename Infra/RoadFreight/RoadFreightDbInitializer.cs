using System;
using System.Collections.Generic;
using System.Linq;
using SemestriProject.Data.RoadFreight;

namespace SemestriProject.Infra.RoadFreight

{
    public static class RoadFreightDbInitializer
    {
            internal static BalticData riga = new BalticData
            {
                Id = "LV",
                Direction = "Riga",
                OrderTime = "kek",
                Loading = "",
                Departures = "kek",
                TravelTime = ""
            };

            internal static List<BalticData> baltic => new List<BalticData>
            {
                riga
            };

            public static void Initialize(RoadFreightDbContext db)
            {
                initializeBaltic(db);
            }

            private static void initializeBaltic(RoadFreightDbContext db)
            {
                if (db.Baltics.Count() != 0) return;
                db.Baltics.AddRange(baltic);
                db.SaveChanges();
            }
        
    }
}
