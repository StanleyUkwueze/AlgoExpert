

//Partial Word Searching
static string[] WordSearch(string query, string[] seq)
{
    var result = new List<string>();

    foreach (var r in seq)
    {
        if (r.ToLower().Contains(query.ToLower()))
        {
            result.Add(r);
        };
    }
    if (result.Count < 1) return new string[] { "Empty" };
    return result.ToArray();
}

var query = "me";
var seq = new string[] { "home", "milk", "Mercury", "fish" };
//var res = WordSearch(query, seq);

//Console.WriteLine(res);


//Moving Zeros To The End
static int[] MoveZeroes(int[] arr)
{
    //Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

    int counter = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if(arr[i] != 0)
        {
            arr[counter++] =arr[i];
           
        }
    }

    for(int i = counter; i < arr.Length; i++ )
    {
        arr[i] = 0;
    }

    return arr;
}

var result = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
foreach (var r in result) Console.WriteLine(r);

 static int TrailingZeros(int n)
{
    //Solution
    var product = 1;

    for (int i = n; i >= 1; i--)
    {
        product *= i;
    }

    int counter = 0;

    string str = product.ToString();

    for (int i = str.Length - 1; i > 0; i--)
    {
       

        if (str[i].Equals('0'))
        {
            counter++;
        }
        else
        {
            break;
        }
    }

    return counter;
}

var res = TrailingZeros(6);

Console.WriteLine($"++++++={res}");
