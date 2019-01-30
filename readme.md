# Beginners to Advanced c# development

CSharp tutorials, start from the very basics and covers advanced concepts

```
```

> Loop through element in an array.

```c#
public static void ArrayLab()
{
    int[] array = new int[] { 1, 2, 3, 4, 5};

    Console.Write("Array output: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");        
    }
}
```