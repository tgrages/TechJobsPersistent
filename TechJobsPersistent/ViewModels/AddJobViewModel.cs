﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
	public class AddJobViewModel
	{
		[Required(ErrorMessage = "Name is required.")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Employer is required")]
		public int Id { get; set; }

		public List<SelectListItem> Employers { get; set; }

		public AddJobViewModel(List<Employer> employers)
		{
			Employers = new List<SelectListItem>();

			foreach (var item in employers)
			{
				Employers.Add(
					new SelectListItem
					{
						Value = item.Id.ToString(),
						Text = item.Name
					}
				); ;
			}
		}

		public AddJobViewModel()
		{
		}

	}
}
