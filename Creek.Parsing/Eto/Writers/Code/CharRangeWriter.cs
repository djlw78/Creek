using Lib.Parsing.Eto.Parsers;

namespace Lib.Parsing.Eto.Writers.Code
{
	public class CharRangeWriter : InverseWriter<CharRangeTerminal>
	{
		public override void WriteContents(TextParserWriterArgs args, CharRangeTerminal tester, string name)
		{
			base.WriteContents(args, tester, name);
			args.Output.WriteLine("{0}.Start = (char)0x{1:x};", name, (int)tester.Start);
			args.Output.WriteLine("{0}.End = (char)0x{1:x};", name, (int)tester.End);
		}
	}
}