public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        
        Array.Sort(nums); // 1 1 3

        var n = nums.Length; 
        var low = 0; 
        var high = nums[n-1]-nums[0];

        int Count(int mid) {
            var right = 0;
            var left = 0;
            var ret = 0; 
            for(; right<n; right++) {
                while(nums[right] - nums[left] > mid) left++;
                ret += (right - left);
            }

            return ret;
        }

        while(low<high) {
            var mid = low + (high-low)/2;
            var pairs = Count(mid);

            if(pairs>=k) {
                high = mid;
            } else {
                low = mid+1;
            }
        }

        return low;
    }
}
