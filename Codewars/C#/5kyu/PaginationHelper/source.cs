using System.Collections.Generic;

    public class PagnationHelper<T> {
        /// <summary>
        /// List of our in-comming items
        /// </summary>
        private List<T> _items;

        /// <summary>
        /// Variable, stored an item count that may be placed on one page
        /// </summary>
        private int _itemsPerPage;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage) {
            _items = new List<T>(collection);
            _itemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount {
            get {
                return _items.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount {
            get {
                if(ItemCount == 0 || _itemsPerPage <= 0) {
                    return -1;
                }
                var count = ItemCount / _itemsPerPage;
                return ItemCount % _itemsPerPage == 0 ? count : ++count;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex) {
            if(pageIndex >= PageCount || pageIndex < 0) {
                return -1;
            }
            if(pageIndex == PageCount - 1) {
                return ItemCount % _itemsPerPage;
            }
            
            return _itemsPerPage;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex) {
            if(itemIndex < 0 || itemIndex >= ItemCount) {
                return -1;
            }
            var page = 0;
            var counter = 1;

            for(int i = 0; i < itemIndex; ++i, ++counter) {
                if(counter == _itemsPerPage) {
                    ++page;
                    counter = 0;
                }
            }

            return page;
        }
    }