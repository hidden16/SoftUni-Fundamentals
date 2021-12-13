using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExercise1
{
    class ComposerKey
    {
        public string Composer { get; set; }
        public string Key { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ComposerKey> pieceInfo = new Dictionary<string, ComposerKey>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var cmds = Console.ReadLine().Split("|");
                var piece = cmds[0];
                var composer = cmds[1];
                var key = cmds[2];
                if (!pieceInfo.ContainsKey(piece))
                {
                    pieceInfo.Add(piece, new ComposerKey());
                    pieceInfo[piece].Composer = composer;
                    pieceInfo[piece].Key = key;
                }
            }
            var commands = Console.ReadLine();
            while (commands != "Stop")
            {
                var tokens = commands.Split("|");
                if (tokens[0] == "Add")
                {
                    var piece = tokens[1];
                    var composer = tokens[2];
                    var key = tokens[3];
                    if (!pieceInfo.ContainsKey(piece))
                    {
                        pieceInfo.Add(piece, new ComposerKey());
                        pieceInfo[piece].Composer = composer;
                        pieceInfo[piece].Key = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    var piece = tokens[1];
                    if (pieceInfo.ContainsKey(piece))
                    {
                        pieceInfo.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (tokens[0] == "ChangeKey")
                {
                    var piece = tokens[1];
                    var newKey = tokens[2];
                    if (pieceInfo.ContainsKey(piece))
                    {
                        pieceInfo[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                commands = Console.ReadLine();
            }
            pieceInfo = pieceInfo.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer).ToDictionary(x => x.Key, x => x.Value);
            foreach (var piece in pieceInfo)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }
}
