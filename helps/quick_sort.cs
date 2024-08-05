class Solution
{
    //Function to sort an array using quick sort algorithm.
    static void quickSort(int arr[], int low, int high)
    {
        // code here
        if(low < high) {
            var p = partition(arr, low, high);
            quickSort(arr, p+1, high);
            quickSort(arr, low, p-1);
        }
    }
    
    static int partition(int arr[], int low, int high)
    {
        // your code here
        int pivot = arr[high];
        int i = low-1;
        int temp = 0; 

        for(var j = low; j<high; j++) {
            if(arr[j]<=pivot) {
                i++;
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }
        
        temp = arr[i+1];
        arr[i+1] = arr[high];
        arr[high] = temp;
        
        return i+1;
    } 
}
