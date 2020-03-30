namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
			if (count == 1 || (count > 20 && count % 10 == 1) && ((count - 11) % 100 != 0))
				return "рубль";
			else if ((count - 11) % 100 > 0 && (count - 11) % 100 < 10)
				return "рублей";
			else if (count % 10 > 1 && count % 10 < 5 && (count < 11 || count > 21))
				return "рубля";
			else
				return "рублей";
		}
	}
}