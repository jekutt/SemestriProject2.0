using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.RoadFreight
{
    public abstract class BalticsPage : BasePage<IBalticsRepository, Baltic, BalticView, BalticData>
    {
        protected internal BalticsPage(IBalticsRepository r) : base(r)
        {
            PageTitle = "Baltic";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string getPageUrl() => "/RoadFreight/Baltic";

        protected internal override Baltic toObject(BalticView view)
        {
            return BalticViewFactory.Create(view);
        }

        protected internal override BalticView toView(Baltic obj)
        {
            return BalticViewFactory.Create(obj);
        }
    }
}
