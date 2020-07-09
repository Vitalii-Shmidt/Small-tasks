using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars {
    public class PagnationHelperT {
         summary
         List of our in-comming items
         summary
        private ListT _items;

         summary
         Variable, stored an item count that may be placed on one page
         summary
        private int _itemsPerPage;

         summary
         Constructor, takes in a list of items and the number of items that fit within a single page
         summary
         param name=collectionA list of itemsparam
         param name=itemsPerPageThe number of items that fit within a single pageparam
        public PagnationHelper(IListT collection, int itemsPerPage) {
            _items = new ListT(collection);
            _itemsPerPage = itemsPerPage;
        }

         summary
         The number of items within the collection
         summary
        public int ItemCount {
            get {
                return _items.Count;
            }
        }

         summary
         The number of pages
         summary
        public int PageCount {
            get {
                if(ItemCount == 0  _itemsPerPage = 0) {
                    return -1;
                }
                var count = ItemCount  _itemsPerPage;
                return ItemCount % _itemsPerPage == 0  count  ++count;
            }
        }

         summary
         Returns the number of items in the page at the given page index 
         summary
         param name=pageIndexThe zero-based page index to get the number of items forparam
         returnsThe number of items on the specified page or -1 for pageIndex values that are out of rangereturns
        public int PageItemCount(int pageIndex) {
            if(pageIndex = PageCount  pageIndex  0) {
                return -1;
            }
            if(pageIndex == 0) {
                return _itemsPerPage;
            }
            return Math.Abs(ItemCount - _itemsPerPage  pageIndex);
        }

         summary
         Returns the page index of the page containing the item at the given item index.
         summary
         param name=itemIndexThe zero-based index of the item to get the pageIndex forparam
         returnsThe zero-based page index of the page containing the item at the given item index or -1 if the item index is out of rangereturns
        public int PageIndex(int itemIndex) {
            if(itemIndex  0  itemIndex = ItemCount) {
                return -1;
            }
            var page = 0;
            var counter = 1;

            for(int i = 0; i  itemIndex; ++i, ++counter) {
                if(counter == _itemsPerPage) {
                    ++page;
                    counter = 0;
                }
            }

            return page;
        }
    }
}