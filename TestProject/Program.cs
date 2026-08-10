/*
Try It Out!
Copying an Array. Write code to create a copy of an array.
*/
// First, start by creating an initial array. (You can use whatever type of data you want.) Let’s start with 10 items. 
// Declare an array variable and assign it a new array with 10 items in it. 
int[] firstArray = new int[10];
// Use the things we’ve discussed to put some values in the array.
Random random = new Random();
for (int i = 0; i < firstArray.Length; i++)
{
    firstArray[i] = random.Next(1, 101);
}

// Now create a second array variable. Give it a new array with the same length as the first. 
// Instead of using a number for this length, use the Length property to get the size of the original array.
int[] secondArray = new int[firstArray.Length];

// Use a loop to read values from the original array and place them in the new array. 
// Also print out the contents of both arrays, to be sure everything copied correctly.
for (int i = 0; i < secondArray.Length; i++)
{
    secondArray[i] = firstArray[i];
}
Console.WriteLine("First array contains: " + string.Join(", ", firstArray));
Console.WriteLine("Second array contains: " + string.Join(", ", secondArray));