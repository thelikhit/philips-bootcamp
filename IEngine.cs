public interface IEngine
{
	void Start();
	void Stop();
}

public class DiCorEngine : IEngine
{
	public void Start() { }
	public void Stop() { }
}

public class VeriCorEngine : IEngine
{
	public void Start() { }
	public void Stop() { }
}


public class MultiJetEngine : IEngine
{
	public void Start() { }
	public void Stop() { }
}

public class RevorTron : IEngine
{
	public void Start() { }
	public void Stop() { }
}

public class TataCar
{
	IEngine engine;

	// DI
	public TataCar(IEngine engine)
	{
		this.engine = engine;
	}

	public void Drive()
	{
		engine.Start();
	}

	public void Halt()
	{
		engine.Stop();
	}
}

public class Class1
{
	public static void Main()
	{

		// Harrier
		IEngine harrierEngine = new MultiJetEngine();
		TataCar harrier = new TataCar(harrierEngine);

		// Nexon
		IEngine nexonEngine = new RevorTron();
		TataCar nexon = new TataCar(nexonEngine);

		// Hexa
		IEngine hexaEngine = new VeriCorEngine();
		TataCar hexa = new TataCar(hexaEngine);
	}
}
