using System.Collections.Generic;
using System.Linq;
using System;

public class DnaStrand
{
  private static Dictionary<char, char> dnaMapping = new Dictionary<char, char>()
		{
			{ 'A', 'T' },
			{ 'T', 'A' },
			{ 'G', 'C' },
			{ 'C', 'G' },
		};

	public static string MakeComplement(string dna)
	{

		var dnaChars = dna.ToCharArray();
		
		var complement = new String(dnaChars.Select(x => dnaMapping[x]).ToArray());
		return complement;
	}
}