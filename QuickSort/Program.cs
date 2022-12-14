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
                    //swap the element at index i with the element at index j
                    swap(i, j);
                    mov_count++;
                }
             }
            //j now contains the index of the last element in the sorted list
            if (low < j)
            {
                //move the pivot to its correct position in the list
                swap(low, j);
                mov_count++;
            }
            //sort the list on the left of pivot using quick sort
            q_sort(low, j);
            //sort the list on the left of pivot using quick sort
            q_sort(j + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n=====================");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("\n=====================");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons : ");
            Console.WriteLine("\nNumber of data movements : ");
        }
        int getSize()
        {
            return (n);
        }
        static void Main(string[] args)
        {
            //Declaring the object of the class
            Program myList = new Program();
            //Accept array elemts
            myList.read();
            //Calling the sorting funcyion
            //first call to quick sort Alogarithm
            myList.q_sort(0, myList.getSize() - 1);
            //display sorted array
            myList.display();
            //to exit from the console
            Console.WriteLine("\nPress Enter to exit");
            Console.Read();
        }
    }
}