//
// Extensions.cs
//
// Author:
//       Stephane Delcroix <stephane@mi8.be>
//
// Copyright (c) 2013 Mobile Inception
//
using System;

using MonoTouch.Foundation;

namespace MobileInception.Interactivity
{
	public static class Extensions
	{
		public static void Attach (this NSObject target, IAttachedObject attachedObject)
		{
			attachedObject.Attach (target);
		}
	}
}