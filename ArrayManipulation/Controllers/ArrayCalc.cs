using ArrayManipulation.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArrayManipulation.Controllers
{
	[Route("api/[controller]")]
	public class ArrayCalc:Controller
	{
		// Reverses an array
		[Route("reverse")]
		[HttpGet]
		public int[] Reverse([FromQuery]int[] productIds)
		{
			ArrayManipulationServices.Reverse(productIds);
			return productIds;
		}

		// Deletes an element at a particular index in the array
		[Route("deletepart")]
		[HttpGet]
		public int[] DeletePart([FromQuery]int position, [FromQuery]int[] productIds)
		{
			ArrayManipulationServices.DeleteElement(ref productIds, position);
			return productIds;
		}
	}
}