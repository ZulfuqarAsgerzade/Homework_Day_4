/*
    Array elementlerini loop-suz ekrana cixarmaq:


   1. Elementleri bir bir index nomresine gore gostermek
   2. Recursion istifade etmek
   3. Go to vasitesiyle yazmaq
   4. string.join() funksiyasini isletmek

 */


int[] nums = new int[5] { 1, 2, 3, 4, 5 };
int counter = 1;


/*repeat:
if (counter <= nums.Length)
{
    Console.WriteLine(nums[counter - 1]);
    counter++;

    goto repeat;
}*/


// Console.WriteLine(string.Join(",", nums));




/*
    Consoldan eded daxil olunur. Array icinde yer alib almadiqi yoxlamaq. Loop istifade oluna bilmez.
 */

Console.Write("Please enter the number: ");

int userNum = Convert.ToInt32(Console.ReadLine());
bool answer = false;

repeat:
if (counter <= nums.Length)
{
    if (nums[counter - 1] == userNum)
    {
        answer = true;
    }

    counter++;
    goto repeat;
}

Console.WriteLine(answer);