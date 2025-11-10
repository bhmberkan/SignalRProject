using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDAl _orderDetailDAl;

        public OrderDetailManager(IOrderDetailDAl orderDetailDAl)
        {
            _orderDetailDAl = orderDetailDAl;
        }

        public void TAdd(OrderDetail entity)
        {
           _orderDetailDAl.Add(entity);
        }

        public void TDelete(OrderDetail entity)
        {
           _orderDetailDAl.Delete(entity);
        }

        public OrderDetail TGetById(int id)
        {
            return _orderDetailDAl.GetById(id);
        }

        public List<OrderDetail> TGetListAll()
        {
            return _orderDetailDAl.GetListAll();
        }

        public void TUpdate(OrderDetail entity)
        {
            _orderDetailDAl.Update(entity);
        }
    }
}
