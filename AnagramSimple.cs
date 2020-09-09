namespace AnagramSolution
{
  class Solution
  {

    /*
        1. Sort the items in List(A)
        2. Make a new list(B)
        3. Add items to the new list(B)
        4. Loop thru the List(A)
        5. If new List(B) contains items, continue to next item

    */
        //Sort the string
       static string Sort(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        //Anagram compare
        static List<string> AnagramWords(List<string> anagram){
            List<string> result = new List<String>(); //actual holder of data
            List<string> temp = new List<string>(); //temp holder for comparing 

            //Loop thru the list
            foreach(string word in anagram){
                //Check if the word exist in ? go to next word : add to list
                if (temp.Contains(Sort(word))){
                    continue;
                }
                else
                {
                    temp.Add(Sort(word));
                    result.Add(word);
                }
            }
            return result;
        }
    }
}