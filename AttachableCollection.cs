//
// AttachableCollection.cs
//
// Author:
//       Stephane Delcroix <stephane@mi8.be>
//
// Copyright (c) 2013 Mobile Inception
//
using System;
using MonoTouch.Foundation;

using System.Collections.Generic;

namespace MobileInception.Interactivity
{
	public abstract class AttachableCollection<T> : List<T>, IAttachedObject where T : IAttachedObject
	{
		public void Attach (NSObject target)
		{
			AssociatedObject = target;
			OnAttached ();
		}

		public void Detach ()
		{
			OnDetaching ();
			AssociatedObject = null;
		}

		public NSObject AssociatedObject { 
			get {
				NSObject @object;
				if (AssociatedObjectWeak.TryGetTarget (out @object))
					return @object;
				return null;
			}

			private set { AssociatedObjectWeak = new WeakReference<NSObject> (value); } 
		}

		WeakReference<NSObject> AssociatedObjectWeak { get; set; }

		protected abstract void OnAttached ();
		protected abstract void OnDetaching ();
	}
}