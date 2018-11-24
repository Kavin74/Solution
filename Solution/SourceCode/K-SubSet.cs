using System;

namespace SourceCode
{
    public class AllSubSetOfSizeK
    {

        public void subset(int[] A, int k, int start, int currLen, bool[] used)
        {

            if (currLen == k)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (used[i] == true)
                    {
                        Console.Write(A[i] + " ");
                    }
                }
                Console.WriteLine();
                return;
            }
            if (start == A.Length)
            {
                return;
            }
            // For every index we have two options,
            // 1.. Either we select it, means put true in used[] and make currLen+1
            used[start] = true;
            subset(A, k, start + 1, currLen + 1, used);
            // 2.. OR we dont select it, means put false in used[] and dont increase
            // currLen
            used[start] = false;
            subset(A, k, start + 1, currLen, used);
        }

        public static void Main(String[] args)
        {
            int[] dataSet = { 1, 2, 3, 4, 5 };
            Boolean[] B = new Boolean[dataSet.Length];
            AllSubSetOfSizeK i = new AllSubSetOfSizeK();
            i.subset(dataSet, 3, 0, 0, B);

        }

    }
}

//void subset(int arr[], int data[], int start, int end, int index, int r)
//{
//    int j, i;
//    if (index == r)
//    {
//        for (j = 0; j < r; j++)
//            printf("%d ", data[j]);
//        printf("\n");
//        return;
//    }
//    for (i = start; i <= end && end - i + 1 >= r - index; i++)
//    {
//        data[index] = arr[i];
//        subset(arr, data, i + 1, end, index + 1, r);
//    }
//}
///*  End of subset()  */

///*  Function to print the subset  */
//void printsubset(int arr[], int n, int r)
//{
//    int data[r];
//    subset(arr, data, 0, n - 1, 0, r);
//}
///*  End of printsubset()  */

///*  The main() begins  */
//int main()
//{
//    int arr[20], k, n, i;
//    printf("Enter the number of input : ");
//    scanf("%d", &n);
//    printf("\nEnter the integers: \n");
//    for (i = 0; i < n; i++)
//    {
//        scanf("%d", &arr[i]);
//    }
//    printf("Enter value of k: ");
//    scanf("%d", &k);
//    printsubset(arr, n, k);
//    return 0;
//}