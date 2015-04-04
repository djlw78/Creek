/* Copyright (c) 2009 Richard G. Todd.
 * Licensed under the terms of the Microsoft Public License (Ms-PL).
 */

using Creek.Parsing.Generator;
using LinguaDemo.Calculator;

namespace Test.CalculatorParser.Terminals
{
    [Terminal(@"\(")]
    public class ParenthesisOpen : CalculatorTerminal
    {
    }
}