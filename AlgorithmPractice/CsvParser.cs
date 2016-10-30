// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CsvParser.cs" company="Microsoft">
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>
//   Defines the CSV parser.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPractice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The CSV parser.
    /// </summary>
    public static class CsvParser
    {
        /// <summary>
        /// The index of next state.
        /// </summary>
        private const int NextState = 0;

        /// <summary>
        /// The index of output code.
        /// </summary>
        private const int Output = 1;

        /// <summary>
        /// The state transition table.
        /// </summary>
        /*
        [State transition table]

              \ Input       [0]       [1]       [2]       [3]       [4]       [5]
         State \            Char      ["]       [\r]      [\n]     Separator  End [\0]
         
         [0] Normal         [0,-1]    [1, 1]    [4, 1]    [5, 1]    [3, 1]    [6, 1]
         [1] Quote          [1,-1]    [2,-1]    [7,-2]    [7,-2]    [1,-1]    [7,-2]
         [2] Quote end      [0, 2]    [1,-1]    [4, 2]    [5, 2]    [3, 2]    [6, 2]
         [3] Separator      [0, 3]    [1, 3]    [4, 3]    [5, 3]    [3, 3]    [6, 3]
         [4] Return-line    [7,-2]    [7,-2]    [7,-2]    [5,-1]    [7,-2]    [6, 4]
         [5] Return end     [0, 4]    [1, 4]    [4, 4]    [5, 4]    [3, 4]    [6, 4]
         [6] End
         [7] Error
                            [Next State, Output]


        [Output list]
         -2     Error
         -1     Keep, not output
          1     Item
          2     Item in quote mode
          3     Seperator
          4     Return-line
         */
        private static readonly int[,,] StateTransitionTable =
        {
            { { 0, -1 }, { 1,  1 }, { 4,  1 }, { 5,  1 }, { 3,  1 }, { 6,  1 } },
            { { 1, -1 }, { 2, -1 }, { 7, -2 }, { 7, -2 }, { 1, -1 }, { 7, -2 } },
            { { 0,  2 }, { 1, -1 }, { 4,  2 }, { 5,  2 }, { 3,  2 }, { 6,  2 } },
            { { 0,  3 }, { 1,  3 }, { 4,  3 }, { 5,  3 }, { 3,  3 }, { 6,  3 } },
            { { 7, -2 }, { 7, -2 }, { 7, -2 }, { 5, -1 }, { 7, -2 }, { 6,  4 } },
            { { 0,  4 }, { 1,  4 }, { 4,  4 }, { 5,  4 }, { 3,  4 }, { 6,  4 } }
        };

        /// <summary>
        /// Parse the CSV content.
        /// </summary>
        /// <param name="csvContent">The CSV content.</param>
        /// <returns>The CSV items list.</returns>
        public static IEnumerable<IList<string>> Parse(this string csvContent)
        {
            csvContent = string.Concat(csvContent, '\0');

            var state = 0;
            var swap = new StringBuilder();
            var result = new List<string>();
            var lineNumber = 1;

            foreach (var chr in csvContent)
            {
                var input = GetInputCode(chr);
                var output = StateTransitionTable[state, input, Output];
                state = StateTransitionTable[state, input, NextState];

                switch (output)
                {
                    case 1: //// item
                        result.Add(swap.ToString());
                        swap = new StringBuilder();
                        break;
                    case 2: //// item in quote mode
                        result.Add(swap.ToString(1, swap.Length - 2).Replace(@"""""", @""""));
                        swap = new StringBuilder();
                        break;
                    case 3: //// separator
                        swap = new StringBuilder();
                        break;
                    case 4: //// return-line 
                        yield return result;
                        lineNumber++;
                        result = new List<string>();
                        swap = new StringBuilder();
                        break;
                }

                //// error
                if (state == 7)
                {
                    throw new ArgumentException(
                        @"It's invalid CSV format.",
                        "csvContent",
                        new ApplicationException(string.Format(@"Error content: [{1}], at line {0}.", lineNumber, swap)));
                }

                //// end
                if (state == 6)
                {
                    yield return result;
                    break;
                }

                swap.Append(chr);
            }
        }

        /// <summary>
        /// Gets input code of the character.
        /// </summary>
        /// <param name="chr">The character.</param>
        /// <returns>The input code.</returns>
        private static int GetInputCode(char chr)
        {
            switch (chr)
            {
                case '"':
                    return 1;
                case '\r':
                    return 2;
                case '\n':
                    return 3;
                case ',':
                    return 4;
                case '\0':
                    return 5;
                default:
                    return 0;
            }
        }
    }
}