# Meeting Room Management — WinForms (.NET 10, C#)

Desktop application for the RRA Meeting Room Management System (see `docs/`).
Built with **Windows Forms**, a **SQLite** database and the **MVC** pattern with services and repositories.

## Run

1. Open `RoomManagement.slnx` in Visual Studio 2022/2026 (with the *.NET desktop development* workload).
2. Press **F5**.

Nothing else needs to be installed: no SQL Server, no LocalDB. On first run the app creates the
database file, its tables, the default administrator and the Rwanda public holidays (2025–2027).

Default administrator: **admin@rra.gov.rw / Admin@1234**

## Database

The whole database is one file inside the project:

```
RoomManagement/Data/Database/RoomManagement.db
```

* It is a **SQLite** database. The app opens the file directly, so it works on every Windows computer.
  Copy or zip the project folder and the data goes with it.
* `Data/DbConnection.cs` holds the connection (`DbConnection.GetConnection()`).
  The file name is in `App.config` (`DatabaseFileName`).
* Tables: `Users`, `Rooms`, `Bookings`, `Holidays`.
* To look at the tables, open the `.db` file with the free program **DB Browser for SQLite**.

## MVC structure

```
meeting room management.net/
├── RoomManagement.slnx   (open this in Visual Studio)
├── README.md
├── docs/                 26911_Daily_Project_Description.doc, auca-logo.png
└── RoomManagement/       the desktop app (below)

RoomManagement/
├── Models/         Entities: User, Room, Booking, Holiday, DashboardStats, enums
├── Views/          WinForms (each form = Form.cs + Form.Designer.cs + Form.resx, designed with drag and drop):
│                   LoginForm, RegisterForm, ForgotPasswordForm, ResetPasswordForm, ChangePasswordForm,
│                   MenuForm (main window), DashboardForm, RoomForm, BookingRequestForm, HolidayForm,
│                   AvailableRoomForm, BookRoomForm, RoomDetailsForm, MyBookingForm, CancelReasonForm
├── Controllers/    AuthController, RoomController, BookingController, HolidayController, DashboardController
│                   (receive the requests from the forms and call the services)
├── Services/       AuthService, RoomService, BookingService, HolidayService, DashboardService,
│                   EmailService, Validator  (all the business rules)
├── Repositories/   UserRepository, RoomRepository, BookingRepository, HolidayRepository  (all the SQL)
├── Data/           DbConnection (holds the database connection), DatabaseSetup (creates tables), DataSeeder
│   └── Database/   RoomManagement.db (the database file)
├── Utils/          Session (signed-in user), UiTheme (colors)
└── Program.cs      Creates the database and opens LoginForm
```

### How the layers talk to each other

```
 View  ──▶  Controller  ──▶  Service  ──▶  Repository  ──▶  DbConnection  ──▶  SQLite file
 (form)     (request)        (rules)       (SQL)
   ▲                            │
   └── returns data, or throws an Exception with a message that the form shows
```

| Layer | Folder | Its job | It never... |
|---|---|---|---|
| **View** | `Views/` | Shows data, sends the user's actions to a controller | uses services, repositories or the database |
| **Controller** | `Controllers/` | Receives the request from the form and calls the right service | contains rules or SQL |
| **Service** | `Services/` | Business rules: weekends, holidays, overlaps, 10-word limit, roles, passwords | uses forms or writes SQL |
| **Repository** | `Repositories/` | SQL for one table (SELECT, INSERT, UPDATE, DELETE) | contains rules |
| **Model** | `Models/` | The data classes (User, Room, Booking, Holiday) | depends on anything |

Example, booking a room:
`BookRoomForm` (View) → `BookingController.CreateBooking()` (Controller) →
`BookingService.CreateBooking()` (Service: checks weekend, holiday, overlap, purpose) →
`BookingRepository.Add()` (Repository: INSERT into the Bookings table).

## Features (from the System Description & Functional Requirements)

**Sign Up** (FR-1.1): full name, email, and **Register as: User or Administrator**.
The account gets the default password `RRA@2024` (also emailed when email is on, FR-1.2)
and must choose its own password at first sign in. Everyone can use **Forgot password?** and **Change Password**.

| Administrator | User |
|---|---|
| Dashboard: 8 statistic cards, recent booking requests with search, **View All**; the Cancel Requests card opens those requests | **Available Rooms**: every room with **Book** and **View Details** (popup, can start a booking) — FR-4 |
| **Add New Room**, Manage Rooms: add, edit, delete (location: Ground / 1st / 2nd / 3rd Floor) — FR-3 | **Book Room** (request a booking): date, start and end time, purpose (max 10 words) — FR-5 |
| Booking Requests: **Cancellation Requests** + **All Booking Status** with filter, search, sort by date and **pages of 10** — FR-7, FR-8.5, FR-10 | **My Bookings**: own bookings and their status — FR-10.6 |
| Approve / reject bookings, confirm or refuse cancellation requests — FR-7, FR-8 | Cancel own booking with a reason (max 10 words); approved bookings need the admin — FR-8 |
| Public holidays: pick day and month on a calendar, **year locked to the current year** — FR-9 | |

Business rules:
- No bookings on weekends or public holidays. Bookings in the past are also rejected.
- A booking can't overlap another active (pending/approved/cancel-requested) booking for the same room.
- Status flow: `PENDING → APPROVED | REJECTED | CANCELLED`, `APPROVED → CANCEL_REQUESTED → CANCELLED | APPROVED`.
- A user only sees rooms and their own bookings; admin functions refuse users (FR-2).
- Passwords are hashed with BCrypt. Sign-in failures never say whether the email or the password was wrong (FR-1.5).
- FR-1.6 / FR-1.7 (JWT tokens) secure web requests. A desktop app has no web requests, so every service checks
  the signed-in user and role instead (`Session.CheckLoggedIn()` / `Session.CheckAdmin()`).

## Forgot password email

"Forgot password?" creates a 6-digit reset code that is valid for 1 hour.

* `EmailEnabled = false` (default in `App.config`): the code is shown on the screen, so it works without internet.
* `EmailEnabled = true`: the code is sent by email. Put your Gmail address in `SmtpUser` and a Gmail
  **App password** in `SmtpPassword`.
