# How to Run the Application
1. clone the repo
2. run the program using IIS Express within Visual Studio
3. run the API endpoints within the Test/test.http file

# What feature included into this project?
1. Check all/available rooms
2. Create a list of rooms
3. Update room's details (Use Scenario: once the room is checked out and clean, the pic can need to change the room status)
4. Check all bookings
5. Create bookings along with updating the room status
6. Delete bookings along with updating the room status (Use scenario: once a booking is cancelled)

# Design decision explanation
This project is a simple hotel booking managemenet system built with ASP.NET Core. It follows Clean Architecture to separate concerns, uses Minimal APIs with IResult for lightweight endpoints and provides a .http file for quick API testing. Entities like Booking and Room were designed to reflect real-world scenarios with proper error handling to ensure robustness.
