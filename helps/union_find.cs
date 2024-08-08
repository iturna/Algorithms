public class UnionFind
{
    private int[] parent;
    private int[] rank;

    // Initialize the Union-Find data structure with n elements
    public UnionFind(int n)
    {
        parent = new int[n];
        rank = new int[n];
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }
    }

    // Find the representative of the set containing element x
    public int Find(int x)
    {
        if (parent[x] != x)
        {
            // Path compression
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }

    // Union the sets containing elements x and y
    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX != rootY)
        {
            // Union by rank
            if (rank[rootX] > rank[rootY])
            {
                parent[rootY] = rootX;
            }
            else if (rank[rootX] < rank[rootY])
            {
                parent[rootX] = rootY;
            }
            else
            {
                parent[rootY] = rootX;
                rank[rootX]++;
            }
        }
    }

    // Check if elements x and y are in the same set
    public bool Connected(int x, int y)
    {
        return Find(x) == Find(y);
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        int n = 10; // number of elements
        UnionFind uf = new UnionFind(n);

        uf.Union(1, 2);
        uf.Union(2, 3);
        uf.Union(4, 5);

        Console.WriteLine(uf.Connected(1, 3)); // Output: True
        Console.WriteLine(uf.Connected(1, 4)); // Output: False

        uf.Union(3, 4);

        Console.WriteLine(uf.Connected(1, 5)); // Output: True
    }
}
