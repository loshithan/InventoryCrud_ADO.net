using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO3
{
    class ItemTypeBO
    {
        public List<ItemType> GetAllItemType()
        {
            return new ItemTypeDAO().GetAllItemType();
        }

        public bool DeleteItemType(string name)
        {
            return new ItemTypeDAO().DeleteItemType(name);
        }

        public ItemType GetItemTypeByName(string name)
        {
            return new ItemTypeDAO().GetItemTypeByName(name);
        }
    }

}
