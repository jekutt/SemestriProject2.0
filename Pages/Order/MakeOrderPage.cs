using SemestriProject.Data.Order;
using SemestriProject.Domain.Order;
using SemestriProject.Facade.Order;
using SemestriProject.Pages.Common;

namespace SemestriProject.Pages.Order
{
    public abstract class MakeOrderPage : BasePage<IMakeOrderRepository, MakeOrder, MakeOrderView, MakeOrderData>
    {
        protected internal MakeOrderPage(IMakeOrderRepository r) : base(r)
        {
            PageTitle = "MakeOrder";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string getPageUrl() => "/Order/MakeOrder";

        protected internal override MakeOrder toObject(MakeOrderView view)
        {
            return MakeOrderViewFactory.Create(view);
        }

        protected internal override MakeOrderView toView(MakeOrder obj)
        {
            return MakeOrderViewFactory.Create(obj);
        }
    }
}
