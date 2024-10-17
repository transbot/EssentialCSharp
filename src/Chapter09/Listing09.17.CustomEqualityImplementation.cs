namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_17;

public readonly record struct Angle(
    int Degrees, int Minutes, int Seconds, string? Name = null)
{
    // ÐÞ¸ÄEquals()ÒÔºöÂÔNameÊôÐÔ
    #region INCLUDE
    public bool Equals(Angle other) =>
        (Degrees, Minutes, Seconds).Equals(
            (other.Degrees, other.Minutes, other.Seconds));
    #endregion INCLUDE  
}
