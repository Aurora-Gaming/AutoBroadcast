namespace AutoBroadcast;

public class Broadcast
{
	public string Name = string.Empty;
	public bool Enabled = false;
	public string[] Messages = Array.Empty<string>();
	public float[] ColorRGB = new float[3];
	public int Interval = 0;
	public int StartDelay = 0;
	public string[] TriggerRegions = Array.Empty<string>();
	public string RegionTrigger = "none";
	public string[] Groups = Array.Empty<string>();
	public string[] TriggerWords = Array.Empty<string>();
	public bool TriggerToWholeGroup = false;
}
