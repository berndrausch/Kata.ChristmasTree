using System;
using System.Collections.Generic;

namespace Kata.ChristmasTree.Logic
{
    public class Tree
    {
        private const char STAR = '*'; 
        private const char TREE = 'X'; 
        private const char ROOT = 'I'; 

        public IEnumerable<String> GetLines(int height, bool addStar)
        {
            if (addStar)
            {
                yield return this.GenerateSpaces(height-1) + STAR;
            }
            
            for (int i = 0; i < height; i++)
            {
                yield return this.GenerateSpaces(height-(i+1)) + this.GenerateChars(TREE, 2*i+1);
            }         

           yield return this.GenerateSpaces(height-1) + ROOT;
        }

        private String GenerateSpaces(int count)
        {
            return this.GenerateChars(' ', count);
        }

        private String GenerateChars(char c, int count)
        {
            return new String(c, count);
        }
    }
}
