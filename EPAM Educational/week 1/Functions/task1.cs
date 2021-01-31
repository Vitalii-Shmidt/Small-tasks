        /*
        Task 1:
        Create function IsSorted, determining whether a given array of integer values of arbitrary length is sorted 
        in a given order (the order is set up by enum value SortOrder). 
        Array and sort order are passed by parameters. Function does not change the array.
        */
        public enum Order { less, greater };
        
        public static bool IsSorted(int[] arr, Order order) {
            var less = false;
            if(order == Order.less) {
                less = true;
            }
            for(int i = 0; i < arr.Length - 1; ++i) {
                if(less) {
                    if(arr[i] > arr[i + 1]) {
                        return false;
                    }
                } else {
                    if(arr[i] < arr[i + 1]) {
                        return false;
                    }
                }
            }

            return true;
        }