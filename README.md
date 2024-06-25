# SOLUTION TO LEETCODE PROBLEM 1480 - C#

This is my solution to LeetCode Problem 1480 - **Running Sum of 1d Array** - in C# and a brief explanation

Link to problem on LeetCode -> [https://leetcode.com/problems/merge-strings-alternately/](https://leetcode.com/problems/running-sum-of-1d-array/)

## PROJECT EXPLANATION

I have created a new project in _Visual Studio 2022 Community Edition_, selected the **Console App** project template, named the project **RunningSumOf1DArray**, selected _.NET Core 3.1 (Out of support) Framework_.

I have two classes, **Program** class and **Solution** class.

## CODE EXPLANATION

### Program class 

I am using the automatically generated **Program** class and **Main** function.

```cs
internal class Program
{
    static void Main(string[] args)
    {
```

Firstly, the **nums** int array (int[]) is being initialized by using basic array initialization. This part of code is commented out currently.

```cs
int[] nums = { 1, 2, 3, 4 };
```

Currently, the **nums** int array is being initialized by using next structure:

- Console Write -> where it is evident that first the length of the array must be specified
- int input = int Parse Console ReadLine -> where user input is being stored into a variable
- int[] array = new int[input] -> where new array is initialized with the length of the previous input
- for loop -> which goes through 0 to input to be able to input array members value one at a time
- Console Write -> where it is evident which array member value needs to be inputted
- array[i] = int Parse Console ReadLine_ -> where user input is being stored into a variable

```cs
Console.Write("What is the length of the array: ");
int numsLength = int.Parse(Console.ReadLine());
int[] nums = new int[numsLength];
for (int i = 0; i < numsLength; i++)
{
    Console.Write($"Enter array[{i + 1}] value: ");
    nums[i] = int.Parse(Console.ReadLine());
}
```

---

<details>
<summary>STRUCTURE EXPLAINED IN GREATER DETAIL</summary><br>
- When initializing an array and imediately filling it with values, notice that array Length does not need to be provided. This is because the Length of the array is implied by the number of values provided. Also, array does not need to be specifically instantiated (new int[input]). This is because instantiation is implied.<br>
- Console.ReadLine always takes user input in a string format. To convert the string input to a int value -> int.Parse needs to be used.<br>
- When initializing an array first before filling it with values, array Length needs to be provided and array needs to be specifically instantiated (new int[input]).<br>
- Array members can be accessed by using array[i].
</details>

---

Next, the **RunningSum** function from **Solution** class is being called. It takes an array (_int[] array_) and returns an array (_int[] array_). The returned array is being stored into an existing array. The returned array is then printed out to the console by using the for loop.

```cs
nums = Solution.RunningSum(nums);
for(int i = 0; i < nums.Length; i++)
{
    if(i != 0)
    {
        Console.Write(",");
    }
    Console.Write(nums[i]);
}
```

At the end of the **Program** class there is next structure:

- Console WriteLine -> displaying that the code is done processing.
- Console ReadLine -> where it is waiting for user input. Why are we waiting for user input? -> To stop the code from automatically completing and exiting and us not being able to check the result of the code.

```cs
Console.WriteLine("\nDone processing");
Console.ReadLine();
```

### Solution class 

I have created a new class and named it **Solution**. I have made it public. I have created the **RunningSum** function to replicate the example from LeetCode problem. I have made it static.

```cs
public class Solution
{
    public static int[] RunningSum(int[] nums)
    {
```

The for loop is created that iterates from _0_ to _array Length_.

```cs
string fullWord = "";
int counter = word1.Length + word2.Length;
```

Secondly, the **for** function is created that iterates from _1_ to _counter_.

Why does it go from 1 and not 0? Because first array value remains the same.

```cs
for (int i = 1; i < nums.Length; i++)
{
```

The value of the current array member is being set as a sum of current array value and previous array member value.

Why do we not need to sum all the previous array member values? Because the previous member value already contains the sum of all its previous member values.

```cs
nums[i] = nums[i] + nums[i - 1];
```

At the end of the **Solution** class, the array is being returned.

```cs
return nums;
```

## POTENTIAL MISTAKES (I HAVE MADE)



## RUNNING THE CODE - RESULT


