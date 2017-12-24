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
                yield return GenerateStar(height);
            }
            
            for (int i = 0; i < height; i++)
            {
                yield return this.GenerateTreeRow(height,i);
            }         

           yield return this.GenerateRoot(height);
        }

        private String GenerateStar(int totalHeight) 
            => this.GenerateSpaces(totalHeight - 1) + STAR;

        private String GenerateTreeRow(int totalHeight, int currentHeight) 
            => this.GenerateSpaces(totalHeight - (currentHeight + 1))
                + this.GenerateChars(TREE, 2 * currentHeight + 1);

        private String GenerateRoot(int totalHeight) 
            => this.GenerateSpaces(totalHeight - 1) + ROOT;

        private String GenerateSpaces(int count) 
            => this.GenerateChars(' ', count);

        private String GenerateChars(char c, int count) 
            => new String(c, count);
    }
}
