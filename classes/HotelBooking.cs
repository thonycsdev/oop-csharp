namespace Classes
{
    class HotelBooking
    {
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;

        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            this.GuestName = guestName;
            this.StartDate = startDate;

            EndDate = startDate.AddDays(lengthOfStayInDays);
        }

        public void PrintInformation()
        {
            Console.WriteLine($@"
                Guest: {GuestName},
                StartDate: {StartDate},
                EndDate: {EndDate}
            ");
        }
    }
}