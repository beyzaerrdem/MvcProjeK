using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendBox(string p);
        Message GetByID(int id);
        void MessageUpdate(Message message);
        void MessageAdd(Message message);
        void MessageDelete(Message message);  
    }
}
