using System;
using System.Drawing;
using RoomManagement.Models;

namespace RoomManagement.Utils
{
    // Colors that the code needs while the program runs.
    // The main color of the project is light blue.
    // (Button and grid colors are set in the Designer.)
    public class UiTheme
    {
        public static Color Primary = Color.FromArgb(2, 132, 199);        // main color (light blue)
        public static Color NavText = Color.FromArgb(75, 85, 99);        // menu text
        public static Color NavHover = Color.FromArgb(243, 244, 246);    // menu button under the mouse
        public static Color Grey = Color.FromArgb(107, 114, 128);
        public static Color Green = Color.FromArgb(22, 163, 74);
        public static Color Red = Color.FromArgb(220, 38, 38);
        public static Color Orange = Color.FromArgb(217, 119, 6);

        // Friendly text for a booking status, for example CANCEL_REQUESTED -> "Cancel Requested"
        public static string GetStatusText(BookingStatus status)
        {
            if (status == BookingStatus.PENDING)
            {
                return "Pending";
            }
            else if (status == BookingStatus.APPROVED)
            {
                return "Approved";
            }
            else if (status == BookingStatus.REJECTED)
            {
                return "Rejected";
            }
            else if (status == BookingStatus.CANCEL_REQUESTED)
            {
                return "Cancel Requested";
            }
            else
            {
                return "Cancelled";
            }
        }

        // Color used to show a booking status in the grids
        public static Color GetStatusColor(BookingStatus status)
        {
            if (status == BookingStatus.PENDING)
            {
                return Primary;
            }
            else if (status == BookingStatus.APPROVED)
            {
                return Green;
            }
            else if (status == BookingStatus.REJECTED)
            {
                return Red;
            }
            else if (status == BookingStatus.CANCEL_REQUESTED)
            {
                return Orange;
            }
            else
            {
                return Grey;
            }
        }
    }
}
