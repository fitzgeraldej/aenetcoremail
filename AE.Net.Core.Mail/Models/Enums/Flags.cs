namespace AE.Net.Core.Mail.Models.Enums
{
    [System.Flags]
    public enum Flags
    {
        None = 0,
        Seen = 1,
        Answered = 2,
        Flagged = 4,
        Deleted = 8,
        Draft = 16
    }
}