﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Cinema
	{
        public int ID { get; set; }

		[Display(Name = "Cinema Logo")]
		[Required(ErrorMessage = "Cinema Logo is Required")]
		public string Logo { get; set; }

		[Display(Name = "Cinema NAme")]
		[Required(ErrorMessage = "Cinema name is Required")]
		public string Name { get; set; }
		[Display(Name = "Cinema Description")]
		[Required(ErrorMessage = "Cinema Description is Required")]
		public string Description { get; set; }

		//relationship
		public List<Movie> Movies { get; set; }
	}
}
