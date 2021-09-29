using System;
using System.Collections.Generic;

public abstract class Document {	
}

public class MSWord: Document {
	List<Page> pages = new List<Page>();
}

public class Page {
	Header header = new Header();
	Margin margin = new Margin();
	Footer footer = new Footer();
	Paragraph paragraph = new Paragraph();
}

public class Header {
}

public class Margin {
}

public class Footer {
}

public class Paragraph {
}
			
public class Program
{
	public static void Main()
	{		
		MSWord msWord = new MSWord();
	}
}
