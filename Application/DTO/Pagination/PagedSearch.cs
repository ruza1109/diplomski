﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO.Pagination
{
	public abstract class PagedSearch
	{
		public int PerPage { get; set; } = 5;
		public int Page { get; set; } = 1;
	}
}
