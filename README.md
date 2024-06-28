# SOLUTION TO LEETCODE PROBLEM 1480 - C#

This is my solution to LeetCode Problem 1480 - **Running Sum of 1d Array** - in C# and a brief explanation

Link to problem on LeetCode -> [https://leetcode.com/problems/running-sum-of-1d-array/](https://leetcode.com/problems/running-sum-of-1d-array/)

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

Firstly, the **nums** numeric (int) array (int[]) is initialized by using basic array initialization. This part of code is commented out currently.

```cs
int[] nums = { 1, 2, 3, 4 };
```

Currently, the **nums** numeric (int) array is initialized by using next structure:

- Console Write -> where it displays that the length of the array needs to be inputted.
- int input = int Parse Console ReadLine -> where user input is stored into a numeric input (int).
- int[] array = new int[input] -> where new array is initialized and instantiated with the length specified in the previous input.
- for loop -> which iterates from _0 to input_ and allows us to input array member values one at a time.
- Console Write -> where it displays which array member's value needs to be inputted.
- array[i] = int Parse Console ReadLine -> where user input is stored into the array.

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
<summary>CODE EXPLAINED IN GREATER DETAIL</summary><br>
- When initializing an array and at once filling it with values, notice that array Length does not need to be specified. This is because the Length of the array is implied by the number of values provided. Also, array does not need to be specifically instantiated (new int[input]). This is because instantiation is implied.<br><br>
- When initializing an array first before filling it with values, array Length needs to be specified and array needs to be specifically instantiated (new int[input]).<br><br>
- Console.ReadLine always takes user input in a text format (string) . To convert the text input (string) into a numeric input (int) -> int Parse needs to be used.<br><br>
- Array members can be accessed by using array[i].<br>
</details>

---

Next, the **RunningSum** function from **Solution** class is called. It takes an array (_int[] array_) and returns an array (_int[] array_). The returned array is stored into an existing array. The returned array is then printed out to the console by using the for loop and if statement.

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

- Console WriteLine -> where it displays that the code is done processing.
- Console ReadLine -> where it waits for user input.

---

<details>
<summary>WHY DOES CONSOLE READLINE WAIT FOR USER INPUT?</summary><br>
To stop the code from automatically completing and exiting and us not being able to check the result of the code.<br>
</details>

---

```cs
Console.WriteLine("\nDone processing");
Console.ReadLine();
```

### Solution class 

I have created a new class and named it **Solution**. I have made it public. I have created the **RunningSum** function and mirrored the example provided in the LeetCode problem. I have made it static.

```cs
public class Solution
{
    public static int[] RunningSum(int[] nums)
    {
```

The **for** loop is initialized that iterates from _1 to array Length_.

---

<details>
<summary>WHY DOES <strong>i</strong> GO FROM 1 AND NOT 0? </summary><br>
Because the first array member value remains the same.<br>
</details>

---

```cs
for (int i = 1; i < nums.Length; i++)
{
```

The value of the current array member is set as the sum of current array member value and previous array member value.

---

<details>
<summary>WHY DO WE NOT NEED TO RUN THE TOTAL SUM OF ALL PREVIOUS ARRAY MEMBER VALUES? </summary><br>
Because the value of the previous array member already contains the total sum of all previous array member values.<br>
</details>

---

```cs
nums[i] = nums[i] + nums[i - 1];
```

At the end of the **Solution** class, the **nums** array is returned.

```cs
return nums;
```

## POTENTIAL MISTAKES (I HAVE MADE)

In **Solution** class, instead of storing the modified array values into the existing array, I created a new array and populated it with values. Even though this is **NOT WRONG**, it **IS SPACE INEFFICIENT**.

---

<details>
<summary>WHY IS IT SPACE INEFFICIENT?</summary><br>
Because the original array values are not needed, and they can be overwritten with new values.<br>
</details>

---

```cs
int[] sums = new int[nums.Length];
```

In **Solution** class, instead of iterating from _1 to array Length_ I iterated from _0 to array Length_. Then based on the if else statement, I populated the array values. Keep in mind that the modified values are stored in the new array I created in the step before. Even though this is **NOT WRONG**, it **IS TIME INEFFICIENT**.


---

<details>
<summary>WHY IS IT TIME INEFFICIENT?</summary><br>
Because with every for loop iteration it needs to check the if-else statement.<br>
</details>

---

```cs
for (int i = 0; i < nums.Length; i++)
{
    if (i == 0) { sums[i] = nums[i]; }
    else { sums[i] = nums[i] + sums[i - 1]; }
```
Any advice regarding making the code _MORE TIME AND SPACE EFFICIENT_ is **MORE THAN WELCOME**.

## RUNNING THE CODE - RESULT

![image](https://github.com/jerkdavi/LeetCode-Problem-1480-Solution-CSharp/assets/75536158/6ea62122-f6c8-43e9-8b9b-99982cc79789) ![image](https://github.com/jerkdavi/LeetCode-Problem-1480-Solution-CSharp/assets/75536158/8379897d-fa89-43ba-b50e-2825047b76a6) ![image](https://github.com/jerkdavi/LeetCode-Problem-1480-Solution-CSharp/assets/75536158/182345d8-b101-493b-91cd-591a9484280c)
