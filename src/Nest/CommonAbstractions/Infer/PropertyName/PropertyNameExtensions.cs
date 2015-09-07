﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nest
{
	public static class PropertyNameExtensions
	{
		internal static bool IsConditionless(this PropertyName property)
		{
			return property == null || (property.Name.IsNullOrEmpty() && property.Expression == null && property.Property == null);
		}
	}
}
