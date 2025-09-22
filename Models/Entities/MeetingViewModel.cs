using OutLook_Events;

namespace meeting_backend.Models.Entities
{
    public class MeetingViewModel
    {
        public string? Subject { get; set; }
        public string? StartTime { get; set; }   
        public string? EndTime { get; set; }    
        public string? Organizer { get; set; }
        public string? OrganizerEmail { get; set; }
        public string? Location { get; set; }
        public int AttendeeCount { get; set; }
        public string? Id { get; internal set; }
        public string? ICalUId { get; internal set; }
        public bool IsMultiRoom { get; internal set; }
    }
}