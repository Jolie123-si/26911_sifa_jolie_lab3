namespace RoomManagement.Models
{
    // Role of a user account
    public enum UserRole
    {
        ADMIN,
        USER
    }

    // Status of a room
    public enum RoomStatus
    {
        AVAILABLE,
        MAINTENANCE
    }

    // Status of a booking
    public enum BookingStatus
    {
        PENDING,
        APPROVED,
        REJECTED,
        CANCELLED,
        CANCEL_REQUESTED
    }
}
