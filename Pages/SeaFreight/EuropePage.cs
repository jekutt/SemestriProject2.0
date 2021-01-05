using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Facade.SeaFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.SeaFreight
{
    public abstract class EuropePage : BasePage<IEuropeRepository, Europe, EuropeView, EuropeData>
    {
        protected internal EuropePage(IEuropeRepository r) : base(r)
        {
            PageTitle = "Europe";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string getPageUrl() => "/SeaFreight/Europe";

        protected internal override Europe toObject(EuropeView view)
        {
            return EuropeViewFactory.Create(view);
        }

        protected internal override EuropeView toView(Europe obj)
        {
            return EuropeViewFactory.Create(obj);
        }
    }
}
