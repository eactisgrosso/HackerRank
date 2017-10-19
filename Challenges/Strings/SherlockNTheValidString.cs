using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank.Challenges.Strings 
{

    public class SherlockNTheValidString : IChallenge
    {
        const short MAX_LENGTH = 26;

        public void Run()
        {
            string result = isValid("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd");
            Console.WriteLine(result);
        }

        string isValid(string str)
        {
            int[] frequency = new int[MAX_LENGTH];

            for(var i = 0; i < str.Length; i++)
                frequency[str[i]-'a']++;
            
            int[,] ocurrences = new int[2,2];
            foreach(var o in frequency) {
                if (o == 0) continue;
                if (ocurrences[0,0] == o || ocurrences[0,0] == 0){
                    ocurrences[0,0] = o;
                    ocurrences[0,1]++;
                }else if (ocurrences[1,0] == o || ocurrences[1,0] == 0){
                    ocurrences[1,0] = o;
                    ocurrences[1,1]++;
                } else return "NO";
            }

            if (ocurrences[1,0] == 0) return "YES";

            if ((ocurrences[1,0] == 1 && ocurrences[1,1] == 1) ||  (ocurrences[0,0] == 1 && ocurrences[0,1] == 1)) return "YES";

            return (ocurrences[0,1] == 1 || ocurrences[1,1] == 1) && (Math.Abs(ocurrences[1,0] - ocurrences[0,0]) == 1) ? "YES" : "NO";
        }
    }
}