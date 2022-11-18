
dynamic caesarCipher(string input, int shift)
{
    string output = "";
    
    foreach (char c in input)
    {
        if (char.IsUpper(c))
        {
            output += (char)('A' + (c - 'A' + shift) % 26);
        }
        else if (char.IsLower(c))
        {
            output += (char)('a' + (c - 'a' + shift) % 26);
        }
        else
        {
            output += (c);
        }
    }
    return output;
};

string input;
int shift;

Console.WriteLine("Enter the text to be encrypted: ");
input = Console.ReadLine();

Console.WriteLine("Enter the shift value: ");
shift = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Encrypted text: " + caesarCipher(input, shift));
