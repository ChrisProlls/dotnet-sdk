using Dapr.Actors;

public interface IMyActor : IActor
{
    /// <summary>
    /// Method to save data.
    /// </summary>
    /// <param name="data">DAta to save.</param>
    /// <returns>A task that represents the asynchronous save operation.</returns>
    void SaveString(string data);

    /// <summary>
    /// Method to get data.
    /// </summary>
    /// <returns>A task that represents the asynchronous save operation.</returns>
    string GetData();
}