/* Rodriguez Gallardo Alan Paul
  Instituto Tecnologico de Tijuana
*/

namespace pairs;

class Program
{
    public string[] Solution(string str){
        /* Complete the solution so that it splits the string into pairs of two characters. 
         If the string contains an odd number of characters then it should replace the missing
         second character of the final pair with an underscore ('_') */

         /* 
         1.split the string
         2.make the array
         3.make the pairs
         4.return the array
         */
        
        //split the string into a char array
        char[] chars = str.ToCharArray();

        //The mount of pairs should it be half of the lenght from the original string, when the lenght of the string is
        //even we cilling to the next integral number
        //create the array
        int Length = (int)( str.Length % 2 == 0 ? str.Length/2 : Math.Ceiling((double) str.Length/2 ));
        string[] pairs = new string[Length];


        /* si tenemos la palabra monosilabo: mo,no,si,la,bo  */
        for (int counter = 0; counter < pairs.Length; counter++){
            
            //create a string that recolects the current char with the next char
            /* we multiply the current index by 2 in order to reach the starting index of the each pair */
            string pair = chars[counter*2].ToString();

            if((counter*2) + 1 < chars.Length){
                //there is an n*2 + 1 element in chars
                pair+= chars[(counter*2)+1].ToString();
            }
            else{
                //there isn't an n*2 + 1 element in chars
                pair+= "_";
            }

            //add it to the array
            pairs[counter] = pair;
        }

       return pairs;
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Solution("eeeeeeeee__ds");
    }
}
