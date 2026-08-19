namespace ShiftSwap.Api.Entities;

public class Shift
{
    public int Id { get; set; }
    
    public int EmployeeId { get; set; }

    public User Employee { get; set; } = null!;

    public DateOnly ShiftDate { get; set; }

    public TimeOnly StartTime { get; set; }
    
    public TimeOnly EndTime { get; set; }

    public ShiftStatus Status { get; set; } = ShiftStatus.Assigned;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}