    public int FindKthLargest(int[] nums, int k) {
        
        int QuickSelect(int left, int right) {
            
            void Swap(int i, int j) {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }

            var p = nums[right];
            var i = left;
            var j = left;

            while(j<right) {
                if(nums[j]>p) {
                    Swap(i, j);
                    i++;
                }
                j++;
            }

            Swap(right, i);

            

            if(i==k-1) return nums[i];
            if(i<k-1) return QuickSelect(i+1, right);
            else return QuickSelect(left, i-1);
        }

        return QuickSelect(0, nums.Length-1);
    }
