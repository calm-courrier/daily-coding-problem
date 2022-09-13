namespace DailyCodingProblem.Problem;

public static class Problem4 {
    public static int Solve(int[] nums) {
        for (var i = 0; i < nums.Length; i++) {
            // Number out of range => skip
            if (nums[i] <= 0 || nums[i] > nums.Length) {
                continue;
            }

            // Correct position => continue
            if (nums[i] == i + 1) continue;

            // Wrong position => swap with right position and process this index again
            (nums[nums[i] - 1], nums[i]) = (nums[i], nums[nums[i] - 1]);
            i--;
        }

        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != i +1) {
                return i+1;
            }
        }

        return nums.Length + 1;
    }
}