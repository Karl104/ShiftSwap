namespace ShiftSwap.Api.Entities;

public class SwapRequest
{
    public int Id {get; set;}
    public int ShiftId {get; set;}
    public Shift Shift {get; set;} = null!;
    public int RequestedByUserId {get; set;}
    public User RequestedByUser {get; set; } = null!;
    public SwapRequestStatus Status {get; set;} = SwapRequestStatus.Open;
    public DateTimeOffset RequestedAt {get; set;} = DateTimeOffset.UtcNow;
    public int? ReplacementUserId {get; set;}
    public User? ReplacementUser {get; set;}
    public string? Reason {get; set;}
    public DateTimeOffset? ReviewedAt {get; set;}
    public int? ReviewedByUserId {get; set;}
    public User? ReviewedByUser {get; set;}
}