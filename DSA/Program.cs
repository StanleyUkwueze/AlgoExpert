

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
            arr[counter] =arr[i];
            counter++;
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
