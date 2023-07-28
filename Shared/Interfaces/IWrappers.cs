namespace Shared.Interfaces;

public interface IResult
{
    List<string> Messages { get; set; }
    string DetailsLink { get; set; }
    bool Succeeded { get; set; }
}

public interface IResult<out T> : IResult
{
    T Data { get; }
}
