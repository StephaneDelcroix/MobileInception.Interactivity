//
// Beahvior.cs
//
// Author:
//       Stephane Delcroix <stephane@mi8.be>
//
// Copyright (c) 2013 Mobile Inception
//
using System;

using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MobileInception.Interactivity
{
	public abstract class Behavior : IAttachedObject
	{
		public NSObject AssociatedObject { get; private set; }

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

		protected virtual void OnAttached ()
		{
		}

		protected virtual void OnDetaching ()
		{
		}
	}

	public abstract class Behavior<T> : Behavior where T : NSObject
	{
		protected new T AssociatedObject {
			get { return base.AssociatedObject as T; }
		}

		protected Behavior ()
		{
			
		}
	}
}