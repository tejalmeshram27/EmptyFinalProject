using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EmptyFinalProject.Models
{
	public class Order
	{
		public int OrderId { get; set; }

		[Required(ErrorMessage = "PLease enter your first name")]
		[Display(Name="Customer Name")]
		[StringLength(30)]

		public string Name { get; set; }

		[Required(ErrorMessage ="Please enter your address") ]
		[StringLength(50)]
		public string Address1 { get; set; }

		public string Address2 { get; set; }

		[Required(ErrorMessage ="Please enter your country")]
		[StringLength(30)]

		public string Country { get; set; }

		[Required(ErrorMessage = "Please enter your state")]
		[StringLength(30)]

		public string State{ get; set; }

		[Required(ErrorMessage = "Please enter your city")]
		[StringLength (50)]

		public string City { get; set; }

		[Required(ErrorMessage = "Please enter your pincode")]
		[StringLength(10,MinimumLength =4)]
		//[RegularExpression()]
		public string Pincode { get; set; }

		[Required(ErrorMessage = "Please enter your phone number")]
		[StringLength(50)]
		[Display(Name ="Phone Number")]
		[DataType(DataType.PhoneNumber)]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Please enter your email")]
		[StringLength(50)]
		[Display(Name = "Email")]
		[DataType(DataType.EmailAddress)]

		public string Email { get; set; }


		[BindNever]
		[ScaffoldColumn(false)]
		public decimal OrderTotal { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public DateTime OrderPlaced { get; set; }	

	}
}
