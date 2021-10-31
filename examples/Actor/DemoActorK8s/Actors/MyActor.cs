using Dapr.Actors.Runtime;

public class MyActor : Actor, IMyActor
{
    private string? _data;

    public MyActor(ActorHost host) : base(host) { }

    public string GetData()
        => this._data!;

    public void SaveString(string data)
        => this._data = data;
}