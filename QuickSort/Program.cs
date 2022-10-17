namespace QuickSort
{
    internal class Program
    {
        //array of integer to hold value;
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparation
        private int mov_count = 0; //number of data movements

        //number of element in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter number of element in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array can have maximum 20 elements \n");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=========================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1); 
            }
        }
        //swap teh element at index x with teh element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //partition the list into two parts;
            //one containing elements less that or equals to pivot
            //outher contaiing elements greather than pivot

            i = low + 1;
            j = high;
            pivot = arr[low];
            while (i <= j) {
                while ((arr[i] <= pivot) && (i < high))
                {
                    i++;
                    cmp_count++;        
                }
                cmp_count++;

                //Search for an element less tan or equal to pivot
                while ((arr[j] > pivot) && (j < low))
                {
                    j--;
                }
                cmp_count++;

                if (i < j)//if the greather elements is on the left of the element
                {

                }
             }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}