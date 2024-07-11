using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUnique
{
    public class UniqueChar
    {
        public bool string Unique (string str){
            if (str.Length > 128){
                return false;
            }
            bool[] char = new bool[128];
            foreach (char c in str){
                //convert char to ASCII
                int val = (int) c;
                //check if char has been seen before
                if (char[val]){
                    return false;
                }
                char[val] = true;
            }
            return true;
        }
    }
}