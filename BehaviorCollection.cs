//
// BehaviorCollection.cs
//
// Author:
//       Stephane Delcroix <stephane@mi8.be>
//
// Copyright (c) 2013 Mobile Inception
//
using System;

namespace MobileInception.Interactivity
{
	public sealed class BehaviorCollection : AttachableCollection<Behavior>
	{
		protected override void OnAttached ()
		{
			foreach (var behavior in this)
				behavior.Attach (AssociatedObject);
		}

		protected override void OnDetaching ()
		{
			foreach (var behavior in this)
				behavior.Detach ();
		}
	}
}