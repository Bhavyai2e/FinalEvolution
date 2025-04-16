namespace FinalAssignment.Models

{

	public enum BookingStatus
	{
		scheduled,
		inprogress,
		completed,
		cancelled
	}
	public class Booking
	{
		public int id { get; set; }
		public string CustomerName { get; set; }

		public string ContactNumber { get; set; }

		public string vehicleNumber { get; set; }

		public string vehicleType { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public string Notes { get; set; }

		public string ServiceType { get; set; }
		public DateTime BookingDate { get; set; }

		public DateTime? EstimateDeliveryDate { get; set; }

		public BookingStatus Status { get; set; }
	}
}
