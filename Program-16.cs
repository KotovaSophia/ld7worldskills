class Store<T>
{
    public T[] Add_elem_Arr(T[] arr, T element)
    {
        T[] temp = new T[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }
        temp[temp.Length - 1] = element;
        return temp;
    }
    public T[] Delete_elem_Arr(T[] arr, T element)
    {
        T[] temp = new T[arr.Length - 1];

        for (int i = 0, k = 0; i < arr.Length; i++)
        {
            if (Convert.ToString(arr[i]) != Convert.ToString(element))
            {
                temp[k] = arr[i];
                k++;
            }
        }
        return temp;
    }
    public void Get_Elem_Index_Arr(T[] arr, int index) => Console.WriteLine($"{index} элемент массива - это {arr[index - 1]}");
    public void Get_Length_Arr(T[] arr) => Console.WriteLine($"Длина массива: {arr.Length}");
}
internal class Program
{
    private static void Main(string[] args)
    {
        Store<int> integersStore = new();
        Store<double> decimalsStore = new();
        Store<string> stringStore = new();

        int[] integers = { 1, 2, 3 };
        double[] decimals = { 1.2, 2.2, 3.3, 4.4 };
        string[] strings = { "one", "two", "three", "four", "five" };

        integersStore.Get_Length_Arr(integers);
        decimalsStore.Get_Length_Arr(decimals);
        stringStore.Get_Length_Arr(strings);

        integersStore.Get_Elem_Index_Arr(integers, 2);
        decimalsStore.Get_Elem_Index_Arr(decimals, 4);
        stringStore.Get_Elem_Index_Arr(strings, 1);

        integers = integersStore.Add_elem_Arr(integers, 5);
        decimals = decimalsStore.Add_elem_Arr(decimals, 5.5);
        strings = stringStore.Add_elem_Arr(strings, "six");

        integers = integersStore.Delete_elem_Arr(integers, 3);
        decimals = decimalsStore.Delete_elem_Arr(decimals, 3.3);
        strings = stringStore.Delete_elem_Arr(strings, "one");
    }
}