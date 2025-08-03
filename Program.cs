using System;

namespace twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 3 };
            int target = 6;

            // 使用暴力法
            Console.WriteLine("暴力法：");
            forloop(nums, target);

            // 使用哈希表
            Console.WriteLine("哈希表：");
            hashMap(nums, target);

        }

        private static void forloop(int[] nums, int target)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output.Add(i);
                        output.Add(j);
                        break;
                    }
                }
            }
            Console.WriteLine("return : " + string.Join(", ", output.ToArray()));
        }
        
        private static void hashMap(int[] nums, int target)
        {
            // 數值 key : 內容值nums[i] value : index 位置
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> output = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    output.Add(map[complement]);
                    output.Add(i);
                    Console.WriteLine("return : " + string.Join(", ", output.ToArray()));
                    break;
                }
                else
                {
                    // 因為我有的key是內容值，所以map[0]要放ContainsKey(complement)
                    map[nums[i]] = i;
                }
            }
        }
    }
}
