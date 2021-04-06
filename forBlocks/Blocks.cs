using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forBlocks
{
    class Blocks
    {
        public string blockOne = "KINGDOMABCEFHLPQRSTUVWXYZ";
        public string blockTwo = "VQEOKWRFMIXSHANYTLBGZUPCD";
        public string blockThree = "ZYXWVUTSRQPLHFECBAMODGNIK";
        public string blockFour = "ZYXWVUTSRQPLHFECBAMODGNIK";

        public string Encrypting(string text, string bOne, string bTwo, string bThree, string bFour)
        {
            string result="";

            text = text.ToUpper();

            bool value = true;

            for(int i=0; i< text.Length;i++)
            {
                if(value == true)
                {
                    var index = bOne.IndexOf(text[i]);
                    if (index >= 0)
                    {
                        result += bThree[index].ToString();
                        value = false;
                    }
                }  
                else if(value==false)
                {
                    var index = bTwo.IndexOf(text[i]);
                    if (index >= 0)
                    {
                        result += bFour[index].ToString();
                        value = true;
                    }
                }
            }
            return result;
        }

        public string Decrypting(string text, string bOne, string bTwo, string bThree, string bFour)
        {
            string result = "";

            text = text.ToUpper();

            bool value = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (value == true)
                {
                    var index = bThree.IndexOf(text[i]);
                    if (index >= 0)
                    {
                        result += bOne[index].ToString();
                        value = false;
                    }
                }
                else if (value == false)
                {
                    var index = bFour.IndexOf(text[i]);
                    if (index >= 0)
                    {
                        result += bTwo[index].ToString();
                        value = true;
                    }
                }
            }
            return result;
        }

        public string EncryptText(string plainText)
        {
            return Encrypting(plainText, blockOne, blockTwo, blockThree, blockFour);
        }

        public string DecryptText(string plainText)
        {
            return Decrypting(plainText, blockOne, blockTwo, blockThree, blockFour);
        }

    }
}
