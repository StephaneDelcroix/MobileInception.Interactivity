//
// IAttachedObject.cs
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
	public interface IAttachedObject
	{
		NSObject AssociatedObject { get; }
		void Attach (NSObject target);
		void Detach ();
	}
}