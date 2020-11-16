namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			int r1 = count % 10;
			int r2 = count % 100;
			if ((r1 == 1) && (r2 != 11))
				return "рубль";
			else if ((r1 > 1) && (r1 < 5) && (r2 != 12) && (r2 != 13) && (r2 != 14))
				return "рубля";
			else return "рублей";
		}
	}
}