using System;

public class Permutation{

public bool CheckPer(string str1, string 2)
{
    if (str1.length != str2.length)
    {
        return false;
    }
    char[] array1 = str1.ToCharArray();
    char[] array2 = str2.ToCharArray();
    Array.Sort(array1);
    Array.Sort(array2);
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }
    return true;
}
}