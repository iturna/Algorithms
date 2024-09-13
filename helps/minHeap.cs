public class MinHeap {

    List<int> arr;
    int n = 0;
    public MinHeap() {
        arr = new();
    }

    public void Add(int num) {
        arr.Add(num);
        n++;
        HeapifyUp(n-1);
    }

    public int Peek() { 
        if(arr.Count==0) throw new Exception("no item");
        return arr[0];
    }

    public int GetMin() {
        if(arr.Count==0) throw new Exception("no item");

        var min = arr[0];
        arr[0] = arr[n-1];
        arr.RemoveAt(n-1);
        n--;
        HeapifyDown(0);
        return min;
    }

    public void HeapifyDown(int index) {
        
        var smallIndex = index;
        var leftIndex = index*2+1;
        var rightIndex = index*2+2;

        if(leftIndex<n && arr[smallIndex]>arr[leftIndex]) smallIndex = leftIndex;
        if(rightIndex<n && arr[smallIndex]>arr[rightIndex]) smallIndex = rightIndex;
        if(smallIndex!=index) {
            Swap(index, smallIndex);
            HeapifyDown(smallIndex);
        }
    }

    public void HeapifyUp(int index) {
        var parentIndex = (index-1)/2;

        while(index>0 && arr[index]<arr[parentIndex]) {
            Swap(parentIndex, index);
            index = parentIndex;
            parentIndex = (index-1)/2;
        } 
    }

    public int Count() {
        return n;
    }

    private void Swap(int index1, int index2) {
        var temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    } 

    public string Print() {
        var sb = new StringBuilder();
        foreach(var num in arr) {
            sb.Append($"{num}/");
        }
        return sb.ToString();
    }
}
