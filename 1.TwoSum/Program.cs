﻿using System.Collections.Generic;


/// <summary>
/// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// Example:
/// Given nums = [2, 7, 11, 15], target = 9,
///
/// Because nums[0] + nums[1] = 2 + 7 = 9,
/// return [0, 1].
/// </summary>
namespace _1.TwoSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = {
				230, 863,   6, 585, 981, 404, 316, 785, 88,  12,
                70,  435, 384, 778, 887, 755, 740, 337,  86, 92,
                325, 422, 815, 650, 920, 125, 277, 336, 221, 847,
                168, 23,  677, 61,  400, 136, 874, 363, 394, 199,
                863, 997, 794, 587, 124, 321, 212, 957, 764, 173,
                314, 422, 927, 783, 930, 282, 306, 506,  44, 926,
                691, 568,  68, 730, 933, 737, 531, 180, 414, 751,
                28,  546,  60, 371, 493, 370, 527, 387,  43, 541,
                13, 457, 328, 227, 652, 365, 430, 803,	 59, 858,
                538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };

            //int[] numbers = { 3, 2, 4 };


            //var index = TwoSum2(numbers, 6);
            //var index1 = TwoSum(numbers, 542);
            //var index2 = TwoSum2(numbers, 100);
            var index2 = TwoSum2(numbers, 236);

		}


		// simple solution
		public static int[] TwoSum(int[] nums, int target)
		{
			var result = new int[2];

			for (int i = 0; i < nums.Length; i++)
			{
				var diff = target - nums[i];
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[j] == diff)
					{
						result[0] = i;
						result[1] = j;
						return result;
					}
				}
			}

			return null;
		}

		//O(n) solution
		public static int[] TwoSum2(int[] nums, int target)
		{
			var result = new int[2];

			var dic = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
                // I use the number as a key.
				if (dic.ContainsKey(target - nums[i]))
				{
					result[1] = i;
					result[0] = dic[target - nums[i]];
					return result;
				}

				if (dic.ContainsKey(nums[i]))
				{
					dic.Remove(nums[i]);
				}

				dic.Add(nums[i], i);
			}

			return result;
		}
	}
}
