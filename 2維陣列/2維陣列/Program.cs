// 2維陣列

// row 橫排
// column 直排

/*int[,] nums =
{
    { 1 ,2 ,3 },
    { 4 ,5 ,6 },
    { 7 ,8 ,9 }
};

System.Console.WriteLine(nums[1, 0]); //0,0 =第一個直排,第一個橫排所以會顯示1
*/

int[,] nums =
{
    { 1 ,2 ,3 },
    { 4 ,5 ,6 },
    { 7 ,8 ,9 }
};

int[,] num = new int[3, 4];
num[0, 0] = 3;
num[0, 1] = 4;

System.Console.WriteLine(num[0, 1]);