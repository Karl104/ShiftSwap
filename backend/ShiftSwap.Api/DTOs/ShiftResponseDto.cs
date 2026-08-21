namespace ShiftSwap.Api.DTOs;

public class ShiftResponseDto
{
    public int Id {get; set;}
    public int EmployeeId {get; set;}
    public string EmployeeName {get; set;} = string.Empty;
    public DateOnly ShiftDate {get; set;}
    public TimeOnly StartTime {get; set;}
    public TimeOnly EndTime {get; set;}
    public string Status {get; set;} = string.Empty;
}