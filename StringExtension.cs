using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static string [] OrderStringsByLength(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i].Length > array[j].Length) {
                        string temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
            throw new NotImplementedException();
        }
    }
}
