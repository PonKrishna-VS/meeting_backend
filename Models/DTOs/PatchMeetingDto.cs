namespace meeting_backend.Models.DTOs
{
    public class PatchMeetingDto
    {
        public string? Subject { get; set; }
        public string? StartTime { get; set; }   
        public string? EndTime { get; set; }   
        public List<AttendeeDto>? Attendees { get; set; }
        public string OrganizerEmail { get; set; } = "";
    }
}
