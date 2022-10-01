using Newtonsoft.Json;

namespace AutoBroadcast;

public class ABConfig
{
	public Broadcast[] Broadcasts = Array.Empty<Broadcast>();

	public ABConfig Write(string file)
	{
		File.WriteAllText(file, JsonConvert.SerializeObject(this, Formatting.Indented));
		return this;
	}

	public static ABConfig Read(string file)
	{
		if (!File.Exists(file))
		{
			WriteExample(file);
		}
		return JsonConvert.DeserializeObject<ABConfig>(File.ReadAllText(file));
	}

	public static void WriteExample(string file)
	{
		var Ex = new Broadcast()
		{
			Name = "Example Broadcast",
			Enabled = false,
			Messages = new string[]
			{
				"This is an example broadcast",
				"It will broadcast every 5 minutes",
				"Broadcasts can also execute commands",
				"/time noon"
			},
			ColorRGB = new float[] { 255f, 0f, 0f },
			Interval = 300,
			StartDelay = 60
		};
		var Conf = new ABConfig()
		{
			Broadcasts = new Broadcast[] { Ex }
		};
		Conf.Write(file);
	}
}
