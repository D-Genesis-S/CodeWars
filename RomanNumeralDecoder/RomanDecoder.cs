public class RomanDecoder
{
    public static int Solution(string roman)
    {
        Dictionary<int, char> romanNumeral = new Dictionary<int, char>
        {
            {1,'I'},
            {5,'V'},
            {10,'X'},
            {50,'L'},
            {100,'C'},
            {500,'D'},
            {1000,'M'}
        };

        int result = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            if (!romanNumeral.ContainsValue(roman[i]))
            {
                Console.WriteLine("Invalid Roman numeral.");
            }
            if (i < roman.Length - 1 && romanNumeral.First(x => x.Value == roman[i + 1]).Key > romanNumeral.First(x => x.Value == roman[i]).Key)
            {
                result += romanNumeral.First(x => x.Value == roman[i + 1]).Key - romanNumeral.First(x => x.Value == roman[i]).Key;
                i++;
            }
            else
            {
                result += romanNumeral.First(x => x.Value == roman[i]).Key;
            }
        }

        return result;

    }
}