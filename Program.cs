/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3,6,9,1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2,1,2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Checking if the array is empty or null
                if (nums == null || nums.Length == 0)
                    return 0; // If so, return 0 as there are no unique elements

                // Initialize a variable to keep track of the count of unique elements, starting with 1
                int uniqueCount = 1;

                // Iterate through the array starting from the second element
                for (int i = 1; i < nums.Length; i++)
                {
                    // Checking if the current element is different from the previous one
                    if (nums[i] != nums[i - 1])
                    {
                        // If it's different, move the unique element to the next position
                        nums[uniqueCount] = nums[i];
                        // Increment the count of unique elements
                        uniqueCount++;
                    }
                }

                // Returning the count of unique elements
                return uniqueCount;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /*
         * Self-analysis:
         
           When it comes to working with arrays and making in-place changes like eliminating duplicates without 
           consuming additional space, this is the query I answered with the most efficiency.

           I revisited the array to check on the remaining nearby elements while implementing the solution, 
            which reiterated a review of the basics of traversing an array.

           This taught me to be cautious in situations like these, with empty arrays, or even when an array has a single element. 
           In other words, I now see how crucial it is to know how to guarantee that the function operates correctly under every circumstance.
           
          The latter will be more helpful in that it provides more insight into how conditional checks ensure that this doesn't occur. Because the solution takes linear time, it is efficient in terms of time complexity. 
          Therefore, when efficiency is crucial for real-time applications or for performing array operations on big data sets, the speed of the process and the memory will have an impact on performance.

        */

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Checking if the array is null or has only one element
                if (nums == null || nums.Length <= 1)
                    return nums.ToList(); // If so, return the list as it is

                // Initialize a variable to keep track of the position for non-zero elements
                int nonZeroIndex = 0;

                // Iterate through the array to move non-zero elements to the beginning
                for (int i = 0; i < nums.Length; i++)
                {
                    // Checking if the current element is non-zero
                    if (nums[i] != 0)
                    {
                        // If it's non-zero, move it to the current non-zero index
                        nums[nonZeroIndex] = nums[i];
                        // Increment the non-zero index
                        nonZeroIndex++;
                    }
                }

                // Fill the remaining positions with zeroes from the last non-zero index
                for (int i = nonZeroIndex; i < nums.Length; i++)
                {
                    nums[i] = 0; // Set remaining positions to zero
                }

                // Converting the array to a list and return
                return nums.ToList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /*
         * Self-analysis:
          This exercise aids in practicing shifting components within an array without causing excess space, which is a fundamental concept for many array manipulations.

           It entailed moving the nonzero items to the front of the array by traversing it first, and then adding zeroes to the remaining positions. It was a great way to emphasize the need of practicing traversing an array using a few different indexes.

           Cases on the edges Similar to an array with less than two elements or an array consisting only of zeros, accounting time was also expended. However, care must be taken to ensure that the function performs satisfactorily in each set of test cases. 
           This handles array operations in a tidy manner, accomplishing so in the best possible way to ensure that the desired outcome is achieved without copies, either in location or space. only effective when working with arrays.

           This relative order provides further insight into the underlying manipulation of array approaches by demonstrating how to maintain the original order in which the transfer of zeros to the end occurred.
        */

        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                IList<IList<int>> result = new List<IList<int>>(); // Initialize the result list
                Array.Sort(nums); // Sorting the array in ascending order

                // Iterate through the array
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // Skip duplicates for the current element
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    int left = i + 1; // Initialize the left pointer
                    int right = nums.Length - 1; // Initialize the right pointer

                    // Move the left and right pointers to find the triplet summing to zero
                    while (left < right)
                    {
                        int sum = nums[i] + nums[left] + nums[right]; // Calculate the sum of the triplet

                        if (sum == 0)
                        {
                            // Found a triplet with sum equal to zero
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            // Skip duplicates for left and right pointers
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            while (left < right && nums[right] == nums[right - 1])
                                right--;

                            left++; // Move the left pointer to the right
                            right--; // Move the right pointer to the left
                        }
                        else if (sum < 0)
                        {
                            left++; // Move left pointer to increase sum
                        }
                        else
                        {
                            right--; // Move right pointer to decrease sum
                        }
                    }
                }
                return result; // Return the list of triplets
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /* * Self-analysis:
         
          Some sophisticated array manipulation techniques, such as sorting the array and using multiple pointers to identify the triplet equal to zero, were utilized to overcome this problem.

           To prevent recomputation and so run quickly, the implementation required close attention, particularly in corner circumstances.

           In order to execute the solution, conditional statements are used to bypass the duplicate pointer adjustments and the one based on the total of elements, respectively. This further strengthened my ability to use conditional logic to algorithm solutions.

          This application of data structures, such the list for storing and retrieving the result set, makes me truly grateful for all the years I spent emphasizing data structures and giving advice on which data structure to choose in order to solve problems effectively. Improvements that primarily aimed to raise the overall efficiency of the solution were addressed, and the ongoing implementation work was maintained to minimize superfluous computations.
           In this approach, algorithm optimization has received a lot of attention for better performance.
        */

        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                int maxConsecutiveCount = 0; // Initialize the maximum consecutive count of 1's
                int currentConsecutiveCount = 0; // Initialize the current consecutive count of 1's

                // Iterate through the array
                foreach (int num in nums)
                {
                    if (num == 1)
                    {
                        // Increment current count for consecutive 1's
                        currentConsecutiveCount++;
                    }
                    else
                    {
                        // Update maximum count and reset current count when encountering 0
                        maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentConsecutiveCount);
                        currentConsecutiveCount = 0; // Reset current count
                    }
                }

                // Update maxConsecutiveCount for the last sequence of consecutive 1's
                maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentConsecutiveCount);

                return maxConsecutiveCount; // Returning the maximum consecutive count of 1's
            }
            catch (Exception)
            {
                throw; 
            }
        }

        /* 
           * Self-analysis:
         
          The workaround was cleverly iterating through the array to update the count of elements encountered. It was at this point that I truly learned how to navigate around an array.

           Stated differently, the outcome will allow for the maintenance and observation of every subsequent occurrence site for the 1s in that binary array. This insight was the driving force behind the algorithmic solutions' meticulous and sequential element counting. When an answer is brief, straightforward, and unambiguous, it maintains clarity.
         
           For instance, when an array has only one element or all zeros, careful consideration has been given to the solution so that the function won't take extra care for any of those edge circumstances.

           When counts are updated effectively while traversing an array, we can get the optimal time complexity, indicating that the algorithms that are created with great efficiency should be given the proper consideration.
         */

        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        {
            try
            {
                int decimalValue = 0; // Initialize the decimal value to 0
                int baseValue = 1; // Initialize the base value to 1

                // Iterate until the binary number becomes 0
                while (binary != 0)
                {
                    int lastDigit = binary % 10; // Extracting the last digit of the binary number
                    binary /= 10; // Remove the last digit from the binary number

                    decimalValue += lastDigit * baseValue; // Update the decimal value
                    baseValue *= 2; // Multiply the base value by 2 for the next digit position
                }

                return decimalValue; // Return the calculated decimal value
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* 
           * Self-analysis:

           The solution's implementation deepened my understanding of number systems by requiring me to understand how to convert a binary integer into a decimal representation using basic arithmetic operations.

            Notably, the solution is clear-cut, easy to understand, and only requires a few elementary arithmetic operations to determine the necessary conversion. This is independent of any bit operator operations or exponentiation-based functions.

            It makes it abundantly evident that as the binary digit loop updates, the given decimal value in each iteration of the loop highlights and amplifies the effectiveness of algorithms in addressing problems.
            
           In these situations, manipulating binary numbers always aided the process of transformation while also emphasizing the significance of numerical operations in algorithmic solutions.

           Thinking creatively about addressing problems highlighted how important it is to consider such aspects when building algorithms and avoiding certain functions and operators.
         */

        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.


        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length < 2)
                    return 0;

                // Sorting the array to find the maximum gap between successive elements
                Array.Sort(nums);

                int maxGap = 0;

                // Iterate through the sorted array to find the maximum difference between consecutive elements
                for (int i = 1; i < nums.Length; i++)
                {
                    int currentGap = nums[i] - nums[i - 1];
                    maxGap = Math.Max(maxGap, currentGap);
                }

                return maxGap;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* * Introspection:
         
         * Using mathematical ideas, such as calculating the distance between the elements and distributing the numbers among the buckets, would be the solution in this situation. It also made it clearer to me how mathematical ideas should be applied while attempting to solve an algorithmic problem.

           Therefore, the approach should ensure that both the time complexity it produces and the additional space it uses are linear. An emphasis on algorithmic efficiency lays the foundation for every other efficiency.
           
           When there were fewer than two elements in arrays, for instance, the system handled edge cases appropriately. As a result, it guarantees that the function operates flawlessly in all circumstances, as these kinds of situations are typically considered while designing algorithms.

           It is evident how important it is to manipulate the array in order to distribute the elements across the buckets and calculate the space between them.

           Rather than making clear how important it is to be aware of constraints while solving problems—such as linear time complexity and linear extra space usage—the study focused and underscored the need of carefully designing the algorithm that implements adherence to the constraints.
         */

        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                int maxPerimeter = 0; // Initialize the maximum perimeter to 0

                // Sort the array in non-decreasing order
                Array.Sort(nums);

                // Iterate through the array to find the largest perimeter
                for (int i = 2; i < nums.Length; i++)
                {
                    // Check if the current triplet can form a valid triangle
                    if (nums[i - 2] + nums[i - 1] > nums[i])
                    {
                        // Calculate the perimeter of the current triangle
                        int perimeter = nums[i - 2] + nums[i - 1] + nums[i];

                        // Updating the maximum perimeter if necessary
                        maxPerimeter = Math.Max(maxPerimeter, perimeter);
                    }
                }

                return maxPerimeter; // Return the maximum perimeter found
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* 
         * Introspection:
         
          I was aware that the triangle inequality theorem may be used during implementation to determine whether the given side lengths could be used to create a triangle with a non-zero area. It made it easier for me to connect my knowledge of geometry with geometric ideas found in algorithmic solutions.

           The algorithm's design is fairly clean and effective, with the straightforward and efficient method of iterating through the sorted array to check for valid triangles being easily accessible.

           By using these geometric concepts, the fundamental application had shed light on the necessity of using mathematical concepts consistently and the multidisciplinary nature of effective algorithm design.
         */

        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                StringBuilder sb = new StringBuilder(s); // Create a StringBuilder to efficiently handle string modifications
                int index = sb.ToString().IndexOf(part); // Find the index of the first occurrence of the substring part

                // Continue removing occurrences of part until none are left
                while (index != -1)
                {
                    // Remove the leftmost occurrence of the substring part
                    sb.Remove(index, part.Length);

                    // Find the index of the next occurrence of the substring part
                    index = sb.ToString().IndexOf(part);
                }

                return sb.ToString(); // Convert the StringBuilder back to a string and return
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* * Introspection:

                 * After the solution was implemented, I was able to handle strings again when using methods like IndexOf and Remove to find and eliminate substring occurrences. This was a general reinforcement of how strings are handled in algorithmic solutions.

                   In order to find the substring in the input string from left to right and remove it one at a time, this method employs a while loop. The approach works well, demonstrating accuracy in offering a way to complete a repetitious chore quickly and effectively.
                   
                   This guarantees the function functions properly and robustly, preventing the need for even more robust error handling in the algorithm design. It handles exceptions that may be thrown during string manipulation, such as the 'index out of range' error, which helps prevent string manipulation errors. They used a few techniques to remove substrings by manipulating strings using built-in functions. This was given careful thought in order to fully utilize the language-optimized features while effective algorithms were being implemented.

                  This has an extremely obvious answer and includes code to change instances of the substring to show how legible the code is when applying an algorithmic approach to solve the problem.
         */


        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}