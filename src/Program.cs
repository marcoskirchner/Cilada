using System;
using System.Collections.Generic;

namespace Cilada
{
    class Program
    {
        static void Main(string[] args)
        {
            var combinations = GetPossibleCombinations();
            Console.WriteLine(combinations.Count);
        }

        private static List<string> GetPossibleCombinations()
        {
            List<string> combinations = new();

            for (var a = 4; a >= 0; a--)
            {
                for (var b = 3; b >= 0; b--)
                {
                    for (var c = 3; c >= 0; c--)
                    {
                        for (var d = 2; d >= 0; d--)
                        {
                            for (var e = 2; e >= 0; e--)
                            {
                                for (var f = 2; f >= 0; f--)
                                {
                                    for (var g = 1; g >= 0; g--)
                                    {
                                        for (var h = 1; h >= 0; h--)
                                        {
                                            for (var i = 1; i >= 0; i--)
                                            {
                                                for (var j = 1; j >= 0; j--)
                                                {
                                                    for (var k = 1; k >= 0; k--)
                                                    {
                                                        for (var l = 1; l >= 0; l--)
                                                        {
                                                            for (var m = 1; m >= 0; m--)
                                                            {
                                                                for (var n = 1; n >= 0; n--)
                                                                {
                                                                    if (((a + b + c + d + e + f) * 2 + (g + h + i + j + k + l + m + n) * 3) == 28)
                                                                    {
                                                                        combinations.Add(
                                                                            new string('A', a) +
                                                                            new string('B', b) +
                                                                            new string('C', c) +
                                                                            new string('D', d) +
                                                                            new string('E', e) +
                                                                            new string('F', f) +
                                                                            new string('G', g) +
                                                                            new string('H', h) +
                                                                            new string('I', i) +
                                                                            new string('J', j) +
                                                                            new string('K', k) +
                                                                            new string('L', l) +
                                                                            new string('M', m) +
                                                                            new string('N', n)
                                                                        );
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            combinations.Sort();
            return combinations;
        }
    }
}
