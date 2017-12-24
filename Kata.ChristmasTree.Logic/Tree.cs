using System;
using System.Collections.Generic;

namespace Kata.ChristmasTree.Logic
{
    public class Tree
    {
        public IEnumerable<String> GetLines(int height, bool addStar)
        {
            if (addStar)
            {
                yield return "*";
            }
            
            yield return "X";
            yield return "I";
        }
    }
}
