// Approach: two pointers each pointing to positions m of nums1 and n of nums2. Now compare and move elements into nums1 to replace zeroes and arrange the numbers.
// Time Complexity: O(m+n) for given m and n
// Space Complexity: O(1)
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1=m-1, p2=n-1, i = m+n-1;
        
        while(p1 >= 0 && p2 >=0){
            if(nums1[p1]>nums2[p2])
            {
                nums1[i]=nums1[p1];
                p1--;
            } else {
                nums1[i] = nums2[p2];
                p2--;
            }
            i--;
        }
        
        while(p2>=0)
        {
            nums1[i] = nums2[p2];
            i--;
            p2--;
        }
    }
}
